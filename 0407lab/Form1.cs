using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0407lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadText(string path)
        {
            StreamReader reader = new StreamReader(path, Encoding.UTF8);
            while (!reader.EndOfStream)
            {
                text.Text = reader.ReadLine();
            }
            reader.Close();
            textprogress.Minimum = 0;
            textprogress.Maximum = 1000;
            textprogress.Value += text.Text.Length;
        }

        private void textbutton_Click(object sender, EventArgs e)
        {
            
            LoadText(path.Text);
        }
    }
}
