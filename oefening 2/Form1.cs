using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIndienen_Click(object sender, EventArgs e)
        {
            string geslacht = "";
            string provincie = "";
            foreach (RadioButton rb in gbProvincie.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    provincie = rb.Text;
                }    
            }
            foreach (RadioButton rb in gbGeslacht.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    geslacht = rb.Text;
                }
            }

            if (tbVoornaam.Text != "" $$ tbAchternaam.Text != "" $$ tbStraat.Text != "" $$ tbNummer.Text != "" $$ tbGemeente.Text != "" $$ tbPostcode.Text != "" )         
            MessageBox.Show($"uw naam is {tbVoornaam.Text} {tbAchternaam.Text}. \n Uw adress is {tbStraat.Text} {tbNummer.Text}, {tbGemeente.Text} {tbPostcode.Text} in {provincie}. \n Uw leeftijd is {nudLeeftijd.Text} en je bent een {geslacht}"); //nudLeeftijd.Text is eigenlijk fout zou nudLeeftijd.Value zijn.
            else
            MessageBox.Show("Vul alles in a.u.b.");
        }
    }
}
