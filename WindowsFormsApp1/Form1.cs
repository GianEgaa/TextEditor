using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // this.Text = "cek";
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // openFileDialog1.ShowDialog(); //Shows the dialog   
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Contains(".txt")) //Checks if it's all ok and if the file name contains .txt  
            {
                string name = openFileDialog1.FileName;
                string open = File.ReadAllText(openFileDialog1.FileName); //Reads the text from file  
                richTextBox1.Text = open; //Shows the reded text in the textbox
                Form1.ActiveForm.Text = name;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.ShowDialog(); //Opens the Show File Dialog  
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) //Check if it's all ok  
            {
                string name = saveFileDialog1.FileName + ".txt"; //Just to make sure the extension is .txt  
                File.WriteAllText(name, richTextBox1.Text); //Writes the text to the file and saves it            
                Form1.ActiveForm.Text = name;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // fontDialog1.ShowDialog(); //Shows the font dialog 
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font; //Sets the font to the one selected in the dialog  
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1 .Copy();

            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox1.Paste();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();

            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                // Undo the last operation.
                richTextBox1.Undo();
                // Clear the undo buffer to prevent last action from being redone.
                // richTextBox1.ClearUndo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Determines if a Redo operation can be performed.
            if (richTextBox1.CanRedo == true)
                // System.Windows.Forms.MessageBox.Show("Masuk");
            {
                // Determines if the redo operation deletes text.
                if (richTextBox1.RedoActionName != "Delete")
                {
                    // System.Windows.Forms.MessageBox.Show(richTextBox1.RedoActionName);
                    // Perform the redo.
                    richTextBox1.Redo();
                }
                    

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.CanSelect == true)
            {
                richTextBox1.SelectAll();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(); //Opens the Show File Dialog  
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) //Check if it's all ok  
            {
                string name = saveFileDialog1.FileName + ".txt"; //Just to make sure the extension is .txt  
                File.WriteAllText(name, richTextBox1.Text); //Writes the text to the file and saves it               
            }
        }
    }
}
