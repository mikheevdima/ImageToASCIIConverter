using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ImageToASCIIConverter.Converter;

namespace ImageToASCIIConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            DialogResult diag = openFileDialog1.ShowDialog();
            if (diag == DialogResult.OK)
            {
                PathtextBox.Text = openFileDialog1.FileName;
            }
        }

        private void Convertbutton_Click(object sender, EventArgs e)
        {
            Converter image = new Converter(PathtextBox.Text);
            Content = image.ConvertToAscii(trackBar1.Value);
            webBrowser1.DocumentText = "<pre>" + "<Font size=0>" + Content + "</Font></pre>";
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File (*.txt)|.txt";
            DialogResult diag = saveFileDialog1.ShowDialog();
            if (diag == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(Content);
                sw.Flush();
                sw.Close();
            }
        }
    }
}
