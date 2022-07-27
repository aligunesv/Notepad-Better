
namespace NotepadBetter
{
    public partial class Form1 : Form
    {
        private string file = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Clear();
            }
            else
            {
                var result = MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    richTextBox1.Clear();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                DialogResult dr = openFileDialog1.ShowDialog();
                openFileDialog1.Filter = "Text Files |*.txt";
                if (dr == DialogResult.OK)
                {
                    StreamReader read = new StreamReader(openFileDialog1.FileName);
                    read.Close();
                    file = openFileDialog1.FileName;
                }
            }
            else
            {
                var result = MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DialogResult dr = openFileDialog1.ShowDialog();
                    openFileDialog1.Filter = "Text Files |*.txt";
                    if (dr == DialogResult.OK)
                    {
                        StreamReader read = new StreamReader(openFileDialog1.FileName);
                        read.Close();
                        file = openFileDialog1.FileName;
                    }
                }
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "Text File |*.txt";
            if (dr == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                write.Write(richTextBox1.Text);
                write.Close();
            }
            else
            {
                try
                {
                    StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                    write.Write(richTextBox1.Text);
                    write.Close();
                }
                catch
                {

                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {

            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)
            {
                richTextBox1.Redo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox1.Paste();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            richTextBox1.Text = dt.ToString();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = true;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Ali Gunes, It's open source and fully free! For more you can follow me on GitHub!", "About Notepad Better", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //THEMES
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(254, 254, 254);
            richTextBox1.ForeColor = Color.FromArgb(15, 14, 14);

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(15, 14, 14);
            richTextBox1.ForeColor = Color.FromArgb(254, 254, 254);
        }

        private void matrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(13, 2, 8);
            richTextBox1.ForeColor = Color.FromArgb(0, 255, 65);
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(175, 133, 133);
            richTextBox1.ForeColor = Color.FromArgb(68, 64, 78);
        }

        private void moneySpellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(130, 173, 139);
            richTextBox1.ForeColor = Color.FromArgb(249, 243, 214);
        }
        private void transparentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(69, 55, 48);
            richTextBox1.ForeColor = Color.FromArgb(15, 14, 14);
        }

        //TEMPLATES:DEV
        private void hTMLToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "<!doctype html>\r\n<html>\r\n<head>\r\n\r\n<title>Basic HTML Page</title>\r\n\r\n<!head>\r\n<body>\r\n\r\n <!--Content goes here--> \r\n\r\n<!body>\r\n<!html>";
            }
            else
            {
                var result = MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    richTextBox1.Text = "<!doctype html>\r\n<html>\r\n<head>\r\n\r\n<title>Basic HTML Page</title>\r\n\r\n<!head>\r\n<body>\r\n\r\n <!--Content goes here--> \r\n\r\n<!body>\r\n<!html>";
                }
            }
        }

        private void cSSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "*{\r\nmargin: 0;\r\npadding: 0;\r\nfont-family: sans-serif; \r\n}";
            }
            else
            {
                var result = MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    richTextBox1.Text = "*{\r\nmargin: 0;\r\npadding: 0;\r\nfont-family: sans-serif; \r\n}";
                }
            }
        }

        //TEMPLATES:SINGER

        private void findRhymesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Type the ryhyme you want to find.",
                    "Find Rhymes",
                    "Ali Gunes",
                    0,
                    0);
            //TODO:BURAYA BAK MUTLAKA (EKSÝK BULUYOR)
           //  foreach(string word in input)
           // {
                int startIndex = 0;
                while (startIndex < richTextBox1.TextLength)
                {
                    int wordStartIndex = richTextBox1.Find(input, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        richTextBox1.SelectionStart = wordStartIndex;
                        richTextBox1.SelectionLength = input.Length;
                        richTextBox1.SelectionBackColor = Color.Yellow;
                    }
                    else
                    {
                        break;
                    }
                    startIndex += wordStartIndex + input.Length;
              //  }
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string words;

            words = richTextBox1.Text;

            int i = 0;
            int myWords = 1;

            while (i <= words.Length - 1)
            {
                if (words[i] == ' ' || words[i] == '\n' || words[i] == '\t')
                {
                    myWords++;
                }
                i++;
            }
            this.words.Text = myWords.ToString();

            int ch;

            ch = words.Length;
            this.ch.Text = ch.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}