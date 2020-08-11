using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Notitieboekje notitieboekje = new Notitieboekje();
        private void btnToevoegen_Click(object sender, EventArgs e)
        {

            //Notities newNotitie = new Notities {$"Notitie {lbNotitieboekje.Items.Count + 1}", tbBijschrijven.Text, lbNotitieboekje.Items.Count + 1 });
            lbNotitieboekje.Items.Add($"Notitie {lbNotitieboekje.Items.Count + 1}");     
            
            notitieboekje.Aanmaken(tbBijschrijven.Text /*, lbNotitieboekje.Items.Count + 1*/);
        }

        private void btnUitscheuren_Click(object sender, EventArgs e)
        {
            notitieboekje.MijnNotities.RemoveAt(lbNotitieboekje.SelectedIndex);
            lbNotitieboekje.Items.Remove(lbNotitieboekje.SelectedItem);
            for (int i = 0; i < lbNotitieboekje.Items.Count; i++)
            {               
                    lbNotitieboekje.Items[i] = $"Notitie {i + 1}"; 
            }
        }

        private void btnBijschrijven_Click(object sender, EventArgs e)
        {
            tbNotities.Text = notitieboekje.NotitieBijschrijven(lbNotitieboekje.SelectedIndex, tbBijschrijven.Text);
        }

        private void btnLamineren_Click(object sender, EventArgs e)
        {
            //methode 1 
            //btnBijschrijven.Enabled = false;
            //btnUitscheuren.Enabled = false;
            //btnToevoegen.Enabled = false;
            //btnLamineren.Enabled = false;
            // methode 2
            //foreach (Control c in Controls)
            //{
            //    Button b = c as Button;
            //    if (b != null)
            //    {
            //        b.Enabled = false;
            //    }
            //}
            //methode 3 (benjamin gevonden)
            foreach (var item in ActiveForm.Controls.OfType<Button>())
            {
                item.Enabled = false;
            }
        }
        private void lbNotitieboekje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNotitieboekje.SelectedIndex >-1)
            {
                tbNotities.Text = notitieboekje.BekijkNotitie(lbNotitieboekje.SelectedIndex);
            }     
        }
    }
}
