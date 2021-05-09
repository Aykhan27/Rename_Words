using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class InputBox : Form
    {
        public bool NeedSet = false;
        public InputBox(string Question)
        {
            InitializeComponent();

            QuestionLabel.Text = Question;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            NeedSet = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NeedSet = false;
            Close();
        }

        private void AnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NeedSet = true;
                Close();
            }
        }
    }
}
