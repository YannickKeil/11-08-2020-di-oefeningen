using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToevoegem_Click(object sender, EventArgs e)
        {
            lbInactief.Items.Add(tbToevoegen.Text);
        }

        private void btnNaarActief_Click(object sender, EventArgs e)
        {
            if (lbInactief.SelectedItems.Count > 0 )
            {
                lbActief.Items.Add(lbInactief.SelectedItem);
                lbInactief.Items.Remove(lbInactief.SelectedItem);
            }
            else
            {
                MessageBox.Show("oops geen item selected");
            }
            
            
  
        }

        private void btnNaarInactief_Click(object sender, EventArgs e)
        {
            if (lbActief.SelectedItems.Count > 0)
            {
                lbInactief.Items.Add(lbActief.SelectedItem);
                lbActief.Items.Remove(lbActief.SelectedItem);
            }
            else
            {
                MessageBox.Show("oops geen item selected");
            }
        }
    }
}
