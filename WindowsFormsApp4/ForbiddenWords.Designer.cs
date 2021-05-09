namespace WindowsFormsApp4
{
    partial class ForbiddenWords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ForbiddenWordsListBox = new System.Windows.Forms.ListBox();
            this.DirectoryTreeView = new System.Windows.Forms.TreeView();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.TimerProgressBar = new System.Windows.Forms.ProgressBar();
            this.ViewReplacedButton = new System.Windows.Forms.Button();
            this.ViewLogsButton = new System.Windows.Forms.Button();
            this.TxtFilesListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.AbortButton = new System.Windows.Forms.Button();
            this.PauStaButton = new System.Windows.Forms.Button();
            this.ViewOrginalTxtButton = new System.Windows.Forms.Button();
            this.ViewReplecedTxtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forbidden words";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 413);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Location = new System.Drawing.Point(93, 413);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ForbiddenWordsListBox
            // 
            this.ForbiddenWordsListBox.FormattingEnabled = true;
            this.ForbiddenWordsListBox.Location = new System.Drawing.Point(12, 28);
            this.ForbiddenWordsListBox.Name = "ForbiddenWordsListBox";
            this.ForbiddenWordsListBox.Size = new System.Drawing.Size(156, 381);
            this.ForbiddenWordsListBox.TabIndex = 4;
            this.ForbiddenWordsListBox.SelectedIndexChanged += new System.EventHandler(this.ForbiddenWordsListBox_SelectedIndexChanged);
            // 
            // DirectoryTreeView
            // 
            this.DirectoryTreeView.Location = new System.Drawing.Point(174, 57);
            this.DirectoryTreeView.Name = "DirectoryTreeView";
            this.DirectoryTreeView.Size = new System.Drawing.Size(258, 352);
            this.DirectoryTreeView.TabIndex = 5;
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Location = new System.Drawing.Point(174, 28);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(177, 20);
            this.DirectoryTextBox.TabIndex = 6;
            this.DirectoryTextBox.TextChanged += new System.EventHandler(this.DirectoryTextBox_TextChanged);
            this.DirectoryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DirectoryTextBox_KeyDown);
            // 
            // ViewButton
            // 
            this.ViewButton.Enabled = false;
            this.ViewButton.Location = new System.Drawing.Point(357, 26);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 7;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Directory";
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Enabled = false;
            this.InfoTextBox.Location = new System.Drawing.Point(174, 415);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(258, 20);
            this.InfoTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Txt files";
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Enabled = false;
            this.ReplaceButton.Location = new System.Drawing.Point(439, 357);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(212, 23);
            this.ReplaceButton.TabIndex = 13;
            this.ReplaceButton.Text = "Replace the Forbidden words";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // TimerProgressBar
            // 
            this.TimerProgressBar.Location = new System.Drawing.Point(438, 412);
            this.TimerProgressBar.Name = "TimerProgressBar";
            this.TimerProgressBar.Size = new System.Drawing.Size(212, 23);
            this.TimerProgressBar.TabIndex = 14;
            // 
            // ViewReplacedButton
            // 
            this.ViewReplacedButton.Location = new System.Drawing.Point(657, 386);
            this.ViewReplacedButton.Name = "ViewReplacedButton";
            this.ViewReplacedButton.Size = new System.Drawing.Size(182, 23);
            this.ViewReplacedButton.TabIndex = 15;
            this.ViewReplacedButton.Text = "View the replaced Forbidden words";
            this.ViewReplacedButton.UseVisualStyleBackColor = true;
            this.ViewReplacedButton.Click += new System.EventHandler(this.ViewReplacedButton_Click);
            // 
            // ViewLogsButton
            // 
            this.ViewLogsButton.Location = new System.Drawing.Point(657, 412);
            this.ViewLogsButton.Name = "ViewLogsButton";
            this.ViewLogsButton.Size = new System.Drawing.Size(182, 23);
            this.ViewLogsButton.TabIndex = 16;
            this.ViewLogsButton.Text = "View Logs";
            this.ViewLogsButton.UseVisualStyleBackColor = true;
            this.ViewLogsButton.Click += new System.EventHandler(this.ViewLogsButton_Click);
            // 
            // TxtFilesListBox
            // 
            this.TxtFilesListBox.FormattingEnabled = true;
            this.TxtFilesListBox.Location = new System.Drawing.Point(438, 28);
            this.TxtFilesListBox.Name = "TxtFilesListBox";
            this.TxtFilesListBox.Size = new System.Drawing.Size(212, 290);
            this.TxtFilesListBox.TabIndex = 17;
            this.TxtFilesListBox.SelectedIndexChanged += new System.EventHandler(this.TxtFilesListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Info";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(657, 28);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(182, 352);
            this.LogTextBox.TabIndex = 19;
            // 
            // AbortButton
            // 
            this.AbortButton.Enabled = false;
            this.AbortButton.Location = new System.Drawing.Point(438, 386);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(103, 23);
            this.AbortButton.TabIndex = 20;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // PauStaButton
            // 
            this.PauStaButton.Enabled = false;
            this.PauStaButton.Location = new System.Drawing.Point(547, 386);
            this.PauStaButton.Name = "PauStaButton";
            this.PauStaButton.Size = new System.Drawing.Size(103, 23);
            this.PauStaButton.TabIndex = 21;
            this.PauStaButton.Text = "Pause/Start";
            this.PauStaButton.UseVisualStyleBackColor = true;
            this.PauStaButton.Click += new System.EventHandler(this.PauStaButton_Click);
            // 
            // ViewOrginalTxtButton
            // 
            this.ViewOrginalTxtButton.Enabled = false;
            this.ViewOrginalTxtButton.Location = new System.Drawing.Point(439, 328);
            this.ViewOrginalTxtButton.Name = "ViewOrginalTxtButton";
            this.ViewOrginalTxtButton.Size = new System.Drawing.Size(103, 23);
            this.ViewOrginalTxtButton.TabIndex = 22;
            this.ViewOrginalTxtButton.Text = "View Orginal";
            this.ViewOrginalTxtButton.UseVisualStyleBackColor = true;
            this.ViewOrginalTxtButton.Click += new System.EventHandler(this.ViewOrginalButton_Click);
            // 
            // ViewReplecedTxtButton
            // 
            this.ViewReplecedTxtButton.Enabled = false;
            this.ViewReplecedTxtButton.Location = new System.Drawing.Point(548, 328);
            this.ViewReplecedTxtButton.Name = "ViewReplecedTxtButton";
            this.ViewReplecedTxtButton.Size = new System.Drawing.Size(102, 23);
            this.ViewReplecedTxtButton.TabIndex = 23;
            this.ViewReplecedTxtButton.Text = "View Replaced";
            this.ViewReplecedTxtButton.UseVisualStyleBackColor = true;
            this.ViewReplecedTxtButton.Click += new System.EventHandler(this.ViewReplecedButton_Click);
            // 
            // ForbiddenWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(850, 441);
            this.Controls.Add(this.ViewReplecedTxtButton);
            this.Controls.Add(this.ViewOrginalTxtButton);
            this.Controls.Add(this.PauStaButton);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFilesListBox);
            this.Controls.Add(this.ViewLogsButton);
            this.Controls.Add(this.ViewReplacedButton);
            this.Controls.Add(this.TimerProgressBar);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.DirectoryTextBox);
            this.Controls.Add(this.DirectoryTreeView);
            this.Controls.Add(this.ForbiddenWordsListBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Name = "ForbiddenWords";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox ForbiddenWordsListBox;
        private System.Windows.Forms.TreeView DirectoryTreeView;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.ProgressBar TimerProgressBar;
        private System.Windows.Forms.Button ViewReplacedButton;
        private System.Windows.Forms.Button ViewLogsButton;
        private System.Windows.Forms.ListBox TxtFilesListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button PauStaButton;
        private System.Windows.Forms.Button ViewOrginalTxtButton;
        private System.Windows.Forms.Button ViewReplecedTxtButton;
    }
}

