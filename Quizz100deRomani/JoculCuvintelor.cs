using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz100deRomani
{
    public partial class QUIZ2 : Form
    {
        int runda = 0;
        int raspuns_gresit = 0;
        int raspuns_corect = 0;
        int[] premii;
        string[] intrebari;
        public QUIZ2()
        {
            premii = new int[] { 1, 2, 4, 8, 16, 32, 64, 128 };
            intrebari = new string[] {
                "Care dintre următorii oameni de știință nu are un element chimic care să-i poarte numele?",
                "Sub ce nume a rămas cunoscut eroul național al Spaniei, Rodrigo Díaz de Bivar?",
                "Dacă ai fi Albert King, care ar fi profesia ta?",
                "În ce oraș s-a născut celebrul bluesman Alexis Korner?",
                "Ce insectă a scurtcircuitat unul dintre primele computere și a inspirat termenul de ‘bug'”?",
                "Care este cel mai înalt munte de pe glob?",
                "În ce an a intrat România în Uniunea Europeana?"
            };
            InitializeComponent();
            Panou.Hide();

        }
        public void verifica_raspuns()
        {
            if (raspuns_gresit == 2)
            {
                raspuns_gresit = 0;
                Schimba_Intrebarea();
                runda++;
            }
            else if (raspuns_corect == 1)
                premiu_1.ForeColor = Color.Green;
            else if (raspuns_corect == 2)
                premiu_2.ForeColor = Color.Green;
            else if (raspuns_corect == 3)
                premiu_3.ForeColor = Color.Green;
            else if (raspuns_corect == 4)
                premiu_4.ForeColor = Color.Green;
            else if (raspuns_corect == 5)
                premiu_5.ForeColor = Color.Green;
            else if (raspuns_corect == 6)
                premiu_6.ForeColor = Color.Green;
            else if (raspuns_corect == 7)
                premiu_7.ForeColor = Color.Green;
            else if (raspuns_corect == 8)
                premiu_8.ForeColor = Color.Green;


        }
        public void Schimba_Intrebarea()
        {
            if (runda == 0)
            {
                Intrebare.Text = intrebari[runda];
                raspuns_1.Text = "Albert Einstein";
                raspuns_2.Text = "Niels Bohr";
                raspuns_3.Text = "Isaac Newton";
                raspuns_4.Text = "Enrico Fermi";
                raspuns_1.Visible = true;
                raspuns_2.Visible = true;
                raspuns_3.Visible = true;
                raspuns_4.Visible = true;
            }
            else if (runda == 5)
            {

                Intrebare.Text = intrebari[runda];
                raspuns_1.Text = "Muntele Makalu";
                raspuns_2.Text = "Muntele Everest";
                raspuns_3.Text = "Muntele Lhotse";
                raspuns_4.Text = "Muntele Cho Oyu";
                raspuns_1.Visible = true;
                raspuns_2.Visible = true;
                raspuns_3.Visible = true;
                raspuns_4.Visible = true;
            }
            else if (runda == 6)
            {

                Intrebare.Text = intrebari[runda];
                raspuns_1.Text = "2003";
                raspuns_2.Text = "2007";
                raspuns_3.Text = "1988";
                raspuns_4.Text = "2012";
                raspuns_1.Visible = true;
                raspuns_2.Visible = true;
                raspuns_3.Visible = true;
                raspuns_4.Visible = true;

            }
            else if (runda == 1)
            {
                Intrebare.Text = intrebari[runda];
                raspuns_1.Text = "El Cano";
                raspuns_2.Text = "El Greco";
                raspuns_3.Text = "El Cid";
                raspuns_4.Text = "El Salvador";
                raspuns_1.Visible = true;
                raspuns_2.Visible = true;
                raspuns_3.Visible = true;
                raspuns_4.Visible = true;
            }
            else if (runda == 2)
            {

                Intrebare.Text = intrebari[runda];
                raspuns_1.Text = "Scriitor";
                raspuns_2.Text = "Jurnalist de televiziune";
                raspuns_3.Text = "Pilot de Formula 1";
                raspuns_4.Text = "Muzician";
                raspuns_1.Visible = true;
                raspuns_2.Visible = true;
                raspuns_3.Visible = true;
                raspuns_4.Visible = true;
            }
            else if (runda == 3)
            {
                Intrebare.Text = intrebari[runda];
                raspuns_1.Text = "Londra";
                raspuns_2.Text = "New York";
                raspuns_3.Text = "Budapesta";
                raspuns_4.Text = "Paris";
                raspuns_1.Visible = true;
                raspuns_2.Visible = true;
                raspuns_3.Visible = true;
                raspuns_4.Visible = true;

            }
            else if (runda == 4)
            {
                Intrebare.Text = intrebari[runda];
                raspuns_1.Text = "Molie";
                raspuns_2.Text = "Gândac de bucătărie";
                raspuns_3.Text = "Muscă";
                raspuns_4.Text = "Gândac japonez";
                raspuns_1.Visible = true;
                raspuns_2.Visible = true;
                raspuns_3.Visible = true;
                raspuns_4.Visible = true;
            }
        }
        private void raspuns_1_Click(object sender, EventArgs e)
        {
            if (runda == 0)
            {
                Schimba_Intrebarea();
                runda++;
                raspuns_corect++;
                raspuns_gresit = 0;
                verifica_raspuns();

            }
            else if (runda == 5)
            {

                Schimba_Intrebarea();
                runda++;

                raspuns_corect++;
                verifica_raspuns();
            }
            else
            {
                raspuns_1.Visible = false;
                raspuns_gresit++;
                verifica_raspuns();
            }
        }

        private void raspuns_2_Click(object sender, EventArgs e)
        {
            if (runda == 6)
            {
                Schimba_Intrebarea();
                runda++;
                raspuns_corect++;
                raspuns_gresit = 0;
                verifica_raspuns();

            }
            else if (runda == 7)
            {
                raspuns_corect++;
                verifica_raspuns();
                Panou.Text = "Felicitari , ati castigat minunata suma de " + premii[raspuns_corect - 1] + "RON";
                Panou.Show();
            }
            else
            {
                raspuns_2.Visible = false;
                raspuns_gresit++;
                verifica_raspuns();
            }
        }
        private void raspuns_3_Click(object sender, EventArgs e)
        {
            if (runda == 1)
            {

                Schimba_Intrebarea();
                runda++;
                raspuns_gresit = 0;
                raspuns_corect++;
                verifica_raspuns();

            }
            else if (runda == 2)
            {
                Schimba_Intrebarea();
                runda++;
                raspuns_corect++;
                raspuns_gresit = 0;
                verifica_raspuns();
            }
            else
            {
                raspuns_3.Visible = false;
                raspuns_gresit++;
                verifica_raspuns();
            }
        }
        private void raspuns_4_Click(object sender, EventArgs e)
        {
            if (runda == 3)
            {

                Schimba_Intrebarea();
                runda++;
                raspuns_gresit = 0;
                raspuns_corect++;
                verifica_raspuns();
            }
            else if (runda == 4)
            {

                Schimba_Intrebarea();
                runda++;
                raspuns_corect++;
                raspuns_gresit = 0;
                verifica_raspuns();
            }
            else
            {
                raspuns_4.Visible = false;
                raspuns_gresit++;
                verifica_raspuns();
            }
        }

        private void Indiciu_Click(object sender, EventArgs e)
        {
            if (runda == 0)
            {
                raspuns_2.Visible = false;
                raspuns_3.Visible = false;

            }
            else if (runda == 1)
            {
                raspuns_2.Visible = false;
                raspuns_1.Visible = false;
            }
            else if (runda == 2)
            {
                raspuns_2.Visible = false;
                raspuns_4.Visible = false;
            }
            else if (runda == 3)
            {
                raspuns_2.Visible = false;
                raspuns_1.Visible = false;
            }
            else if (runda == 4)
            {
                raspuns_3.Visible = false;
                raspuns_1.Visible = false;
            }
            else if (runda == 5)
            {
                raspuns_2.Visible = false;
                raspuns_3.Visible = false;
            }
            else if (runda == 6)
            {
                raspuns_4.Visible = false;
                raspuns_1.Visible = false;
            }
            else if (runda == 7)
            {
                raspuns_3.Visible = false;
                raspuns_1.Visible = false;
            }
        }
    }
}
