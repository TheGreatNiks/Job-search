using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Job_search.Core;
using Job_search.Sites;

namespace Job_search
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;
        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                    new HeadHunterParser()
                    );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All work done!");
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            //ListTitles.Items.Clear();
            //ListTitles.Items.AddRange(arg2);
            richTextBox1.Text = string.Join(" ", arg2);
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            parser.Settings = new HeadHunterSettings((int)NumericStart.Value, (int)NumericEnd.Value, (string)VacancyTB.Text);
            parser.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Control || e.KeyCode == Keys.C)
            //{
            //    Clipboard.SetText("Илья Молодец", TextDataFormat.UnicodeText);
            //    //Clipboard.SetText((string)ListTitles.SelectedItem);
            //}
        }

    }
}
