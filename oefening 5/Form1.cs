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

namespace oefening_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbText.Items.Add(tbBijvoegen.Text);
            tbBijvoegen.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbText.Items.RemoveAt(lbText.SelectedIndex);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("oefening5.txt"))
            {
                foreach (var item in lbText.Items)
                {
                    writer.WriteLine(item);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lbText.Items.Clear();
            using (StreamReader reader = new StreamReader("oefening5.txt"))
            {
                while (!reader.EndOfStream)
                {
                    lbText.Items.Add(reader.ReadLine());
                }
            }
        }
    }
}
