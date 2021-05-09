using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ForbiddenWords : Form
    {
        bool needrem = true;
        InputBox InputBox = new InputBox("Enter forbidden word");
        Thread Replaceth;
        public List<DicFile> TxtFile;
        static private int TxtCount = 0; 

        public ForbiddenWords()
        {
            TxtFile = new List<DicFile>();

            InitializeComponent();

            if (File.Exists("ForbiddenWords.txt"))
            {
                using (FileStream fstream = File.OpenRead($"ForbiddenWords.txt"))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);
                    string textFromFile = Encoding.Default.GetString(array);
                    List<string> result = textFromFile.Split(new char[] { ',' }).ToList();
                    for (int i = 0; i < result.Count; i++)
                    {
                        ForbiddenWordsListBox.Items.Add(result[i]);
                    }
                }
            }

            TxtFilesListBox.Items.Clear();
            TxtFilesListBox.Items.AddRange(TxtFile.ToArray());
        }
        private void Replace()
        {
            AbortButton.Enabled = true;
            PauStaButton.Enabled = true;
            TimerProgressBar.Maximum = 1;


            foreach (DicFile item in TxtFile)
            {
                string path = item.path;
                using (StreamReader sr = new StreamReader(path))
                {
                    string text = sr.ReadToEnd();
                    for (int i = 0; i < ForbiddenWordsListBox.Items.Count; i++)
                    {
                        TimerProgressBar.Maximum += text.Length;
                    }
                }
            }
            List<Logs> logs = new List<Logs>();
            TimerProgressBar.Value = 0;
            foreach (DicFile item in TxtFile)
            {
                string path = item.path;
                string text = "";

                using (StreamReader sr = new StreamReader(path))
                {
                    text = sr.ReadToEnd();
                }
                string Ttext = text;
                Logs thlogs = new Logs(item.Name, System.Text.ASCIIEncoding.Unicode.GetByteCount(text));

                for (int i = 0, c = 0; i < ForbiddenWordsListBox.Items.Count; i++, c = 0)
                {
                    string Ftext = "";
                    string ForbiddenWord = (ForbiddenWordsListBox.Items[i] as string);
                    int l = ForbiddenWord.Length;
                    int prev = TimerProgressBar.Value;
                    for (int j = 0; j < Ttext.Length; j++)
                    {
                        TimerProgressBar.Value = (prev + j < TimerProgressBar.Maximum ? prev + j : TimerProgressBar.Maximum - 1);
                        string tmpword = "";
                        for (int k = 0; k < l && j + k < Ttext.Length; k++)
                            tmpword += Ttext[j + k];
                        if (tmpword == ForbiddenWord)
                        {
                            c++;
                            j += l - 1;
                            for (int k = 0; k < 7; k++)
                                Ftext += '*';
                        }
                        else Ftext += Ttext[j];
                    }
                    TimerProgressBar.Value = prev + text.Length;
                    Ttext = Ftext;
                    thlogs.infos.Add(new Info(ForbiddenWordsListBox.Items[i] as string, c));
                }
                if (!Directory.Exists("Repleced Words")) Directory.CreateDirectory("Repleced Words");
                string newpath = "Repleced Words\\" + Path.GetFileName(path);
                if (File.Exists(newpath)) File.Delete(newpath);
                using (FileStream fstream = new FileStream(newpath, FileMode.OpenOrCreate))
                {
                    byte[] array = Encoding.Default.GetBytes(Ttext);
                    fstream.Write(array, 0, array.Length);
                }

                logs.Add(thlogs);
            }

            TimerProgressBar.Value = 0;
            AbortButton.Enabled = false;
            PauStaButton.Enabled = false;
            ReplaceButton.Enabled = true;

            LogTextBox.Text = "";

            foreach (var item in logs)
            {
                LogTextBox.Text += item.ToString();
            }
            LogTextBox.Text += "Top files" + Environment.NewLine;
            foreach (var item in logs.OrderByDescending(x => x.sumc()))
            {
                LogTextBox.Text += item.name + " - " + item.sumc() + Environment.NewLine;
            }
            LogTextBox.Text += "Top words" + Environment.NewLine;
            List<Info> tif = new List<Info>(logs[0].infos);
            foreach (var item in logs)
            {
                if (item == logs[0]) continue;
                for (int i = 0; i < ForbiddenWordsListBox.Items.Count; i++)
                {
                    tif[i].count += item.infos[i].count;
                    tif[i].name = item.infos[i].name;
                }
            }
            foreach (var item in tif.OrderByDescending(x => x.count))
            {
                LogTextBox.Text += item.name + " - " + item.count + Environment.NewLine;
            }

            if (!Directory.Exists("Logs")) Directory.CreateDirectory("Logs");
            string newlpath = "Logs\\logs.txt";
            if (File.Exists(newlpath)) File.Delete(newlpath);
            using (FileStream fstream = new FileStream(newlpath, FileMode.OpenOrCreate))
            {
                byte[] array = Encoding.Default.GetBytes(LogTextBox.Text);
                fstream.Write(array, 0, array.Length);
            }
            RemoveButton.Enabled = ForbiddenWordsListBox.SelectedIndex != -1;
            needrem = true;
            AddButton.Enabled = true;
        }
        private void AddTreeView(string path)
        {
            var root = new TreeNode() { Text = Path.GetFileName(path), Tag = path };
            DirectoryTreeView.Nodes.Clear();
            DirectoryTreeView.Nodes.Add(root);

            TxtFile.Clear();
            Build(root);

            root.Expand();
        }
        private void Build(TreeNode parent)
        {
            var path = parent.Tag as string;
            parent.Nodes.Clear();

            try
            {
                foreach (var dir in Directory.GetDirectories(path))
                    parent.Nodes.Add(new TreeNode(Path.GetFileName(dir), new[] { new TreeNode("...") }) { Tag = dir });
                foreach (var file in Directory.GetFiles(path))
                {
                    if (Path.GetExtension(file) == ".txt")
                    {
                        parent.Nodes.Add(new TreeNode(Path.GetFileName(file), 1, 1) { Tag = file });
                        TxtFile.Add(new DicFile(file));
                        TxtCount++;
                    }
                }

                foreach (var node in parent.Nodes)
                {
                    Build(node as TreeNode);
                }

            }
            catch { }

            InfoTextBox.Text = $"Txt files count: {TxtCount}";

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (Replaceth != null) if (Replaceth.IsAlive || Replaceth.ThreadState == System.Threading.ThreadState.Stopped) Replaceth.Abort();
            if (File.Exists(@"ForbiddenWords.txt"))File.Delete(@"ForbiddenWords.txt");
            using (FileStream fstream = new FileStream($"ForbiddenWords.txt", FileMode.OpenOrCreate))
            {
                string text = "";
                for (int i = 0; i < ForbiddenWordsListBox.Items.Count; i++)
                {
                    text += ForbiddenWordsListBox.Items[i] + ((i == ForbiddenWordsListBox.Items.Count - 1) ? "" : ",");
                }
                byte[] array = Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
            }
            base.OnClosing(e);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            InputBox.ShowDialog();
            if (InputBox.NeedSet)
            {
                AddForbiddenWord(InputBox.AnswerTextBox.Text);
                InputBox.AnswerTextBox.Text = "";
            }
            InputBox.NeedSet = false;
        }
        private void AddForbiddenWord(string fw)
        {
            ForbiddenWordsListBox.Items.Add(fw);
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ForbiddenWordsListBox.Items.Remove(ForbiddenWordsListBox.SelectedItem);
        }
        private void ViewButton_Click(object sender, EventArgs e)
        {
            InfoTextBox.Text = "Files Loading PLease Wait...";
            AddTreeView(DirectoryTextBox.Text);
            TxtFilesListBox.Items.Clear();
            TxtFilesListBox.Items.AddRange(TxtFile.ToArray());
            ReplaceButton.Enabled = TxtFilesListBox.Items.Count != 0;
        }
        private void DirectoryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTreeView(DirectoryTextBox.Text);
            }
        }
        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            needrem = false;
            AddButton.Enabled = false;
            RemoveButton.Enabled = false;
            ReplaceButton.Enabled = false;
            Replaceth = new Thread(Replace);
            Replaceth.Start();
        }
        private void ViewReplacedButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Repleced Words")) Directory.CreateDirectory("Repleced Words");
            Process.Start("explorer.exe", Path.GetDirectoryName(this.GetType().Assembly.Location) + "\\Repleced Words");
        }
        private void ViewLogsButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Logs")) Directory.CreateDirectory("Logs");
            Process.Start("explorer.exe", Path.GetDirectoryName(this.GetType().Assembly.Location) + "\\Logs");
        }
        private void DirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            ViewButton.Enabled = Directory.Exists(DirectoryTextBox.Text);
        }
        private void ForbiddenWordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (needrem)
                RemoveButton.Enabled = ForbiddenWordsListBox.SelectedIndex != -1;
        }
        private void AbortButton_Click(object sender, EventArgs e)
        {
            try
            {
                Replaceth.Abort();
            }
            catch { }
            AbortButton.Enabled = false;
            PauStaButton.Enabled = false;
            ReplaceButton.Enabled = true;
            RemoveButton.Enabled = true;
            needrem = true;
            AddButton.Enabled = true;
            TimerProgressBar.Maximum = 0;
        }
        private void PauStaButton_Click(object sender, EventArgs e)
        {
            if (Replaceth.ThreadState == System.Threading.ThreadState.Running)
            {
                Replaceth.Suspend();
            }
            else if (Replaceth.ThreadState == System.Threading.ThreadState.Suspended)
            {
                Replaceth.Resume();
            }
        }
        private void TxtFilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewOrginalTxtButton.Enabled = TxtFilesListBox.SelectedIndex != -1;
            ViewReplecedTxtButton.Enabled = TxtFilesListBox.SelectedIndex != -1;
        }
        private void ViewOrginalButton_Click(object sender, EventArgs e)
        {
            string p = TxtFile[TxtFilesListBox.SelectedIndex].path;
            if (File.Exists(p))
                Process.Start(p);
        }
        private void ViewReplecedButton_Click(object sender, EventArgs e)
        {
            string p = Path.GetDirectoryName(this.GetType().Assembly.Location) + "\\Repleced Words\\" + TxtFile[TxtFilesListBox.SelectedIndex].Name + ".txt";
            if (File.Exists(p)) Process.Start(p);
        }
    }
}