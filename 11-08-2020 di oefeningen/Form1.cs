using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_08_2020_di_oefeningen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // cbMijnCheckbox.Checked == true (kan je ook gebruiken)
            if (cbMijnCheckbox.CheckState == CheckState.Checked)
            {
                MessageBox.Show("jij hebt mij aangevinkt");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pbProgress.Minimum = 0;
            //pbProgress.Maximum = 100;
            //pbProgress.Value = 40;

            cblbMijnList.Items.Add("Latha");
            cblbMijnList.Items.Add("Benjamin");
            cblbMijnList.Items.Add("Sergio");
            cblbMijnList.Items.Add("Antal");

            cblbMijnList.SetItemCheckState(1, CheckState.Checked);
            cblbMijnList.SetItemCheckState(2, CheckState.Checked);
            cblbMijnList.SetItemCheckState(3, CheckState.Checked);

            int aantalAangevinkt = 0;
            foreach (var item in cblbMijnList.CheckedItems)
            {             
                aantalAangevinkt += 1;
            }
            string namenAangevinkt = "";
            foreach (var item in cblbMijnList.CheckedItems)
            {
                namenAangevinkt += item.ToString() + " ";
            }

            MessageBox.Show(aantalAangevinkt.ToString());
            MessageBox.Show(namenAangevinkt);

            pbProgress.Minimum = 0;
            pbProgress.Maximum = cblbMijnList.Items.Count;

            pbProgress.Value = aantalAangevinkt;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cblbMijnList_SelectedValueChanged(object sender, EventArgs e)
        {
            int aantalAangevinkt = 0;
            foreach (var item in cblbMijnList.CheckedItems)
            {
                aantalAangevinkt += 1;
            }

            pbProgress.Value = aantalAangevinkt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
