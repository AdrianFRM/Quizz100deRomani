﻿using System;
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
    public partial class QUIZ1 : Form
    {
        int Punctaj;
        int NumarIntrebari = 0;
        string[] raspunsuri;
        string[] intrebari;
        int TotalChestionare = 0;
        int CronometruTicks;
        int RaspunsuriCorecte = 0;

        public QUIZ1()
        {
            InitializeComponent();
            raspunsuri = new string[8] {
                raspuns1.Text ,
                raspuns2.Text ,
                raspuns3.Text ,
                raspuns4.Text ,
                raspuns5.Text ,
                raspuns6.Text ,
                raspuns7.Text ,
                raspuns8.Text
            };

            intrebari = new string[]
            {
                "Care este cel mai des intalnit animal de companie ?",
                "Ce beau romanii cel mai mult la o petrecere ?",
                "Pe ce cheltuie cel mai mult romanii salariul ?",
                "Cea mai intalnita masina in Romania ?"
            };
            Cronometru.Start();
            PanouScor.Hide();
            BackToMenu.Hide();
            
            RESTART.Hide();
            Intrebare.Text = intrebari[NumarIntrebari];
        }


        private void QUIZZ_Load(object sender, EventArgs e)
        {

        }

        private void QUIZZ_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (raspunsuri[0].ToLower() == IntroduRaspuns.Text.ToLower())
                {
                    raspuns1.ForeColor = Color.White;
                    IntroduRaspuns.Clear();
                    Punctaj += 29;
                    raspunsuri[0] = " ";
                    RaspunsuriCorecte++;
                }
                else if (raspunsuri[1].ToLower() == IntroduRaspuns.Text.ToLower())
                {
                    raspuns2.ForeColor = Color.White;
                    IntroduRaspuns.Clear();
                    Punctaj += 20;
                    raspunsuri[1] = " ";
                    RaspunsuriCorecte++;
                }

                else if (raspunsuri[2].ToLower() == IntroduRaspuns.Text.ToLower())
                {
                    raspuns3.ForeColor = Color.White;
                    IntroduRaspuns.Clear();
                    Punctaj += 15;
                    raspunsuri[2] = " ";
                    RaspunsuriCorecte++;
                }

                else if (raspunsuri[3].ToLower() == IntroduRaspuns.Text.ToLower())
                {
                    raspuns4.ForeColor = Color.White;
                    IntroduRaspuns.Clear();
                    Punctaj += 12;
                    raspunsuri[3] = " ";
                    RaspunsuriCorecte++;
                }

                else if (raspunsuri[4].ToLower() == IntroduRaspuns.Text.ToLower())
                {
                    raspuns5.ForeColor = Color.White;
                    IntroduRaspuns.Clear();
                    Punctaj += 10;
                    raspunsuri[4] = " ";
                    RaspunsuriCorecte++;
                }

                else if (raspunsuri[5].ToLower() == IntroduRaspuns.Text.ToLower())
                {
                    raspuns6.ForeColor = Color.White;
                    IntroduRaspuns.Clear();
                    Punctaj += 8;
                    raspunsuri[5] = " ";
                    RaspunsuriCorecte++;
                }

                else if (raspunsuri[6].ToLower() == IntroduRaspuns.Text.ToLower())
                {
                    raspuns7.ForeColor = Color.White;
                    IntroduRaspuns.Clear();
                    Punctaj += 5;
                    raspunsuri[6] = " ";
                    RaspunsuriCorecte++;
                }

                else if (raspunsuri[7].ToLower() == IntroduRaspuns.Text)
                {
                    raspuns8.ForeColor = Color.White;
                    IntroduRaspuns.Clear();
                    Punctaj += 1;
                    raspunsuri[7] = " ";
                    RaspunsuriCorecte++;
                }
            LabelScor.Text = Punctaj.ToString();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (raspunsuri[0].ToLower() == IntroduRaspuns.Text.ToLower())
            {
                raspuns1.ForeColor = Color.White;
                IntroduRaspuns.Clear();
                Punctaj += 29;
                raspunsuri[0] = " ";
                RaspunsuriCorecte++;
            }
            else if (raspunsuri[1].ToLower() == IntroduRaspuns.Text.ToLower())
            {
                raspuns2.ForeColor = Color.White;
                IntroduRaspuns.Clear();
                Punctaj += 20;
                raspunsuri[1] = " ";
                RaspunsuriCorecte++;
            }

            else if (raspunsuri[2].ToLower() == IntroduRaspuns.Text.ToLower())
            {
                raspuns3.ForeColor = Color.White;
                IntroduRaspuns.Clear();
                Punctaj += 15;
                raspunsuri[2] = " ";
                RaspunsuriCorecte++;
            }

            else if (raspunsuri[3].ToLower() == IntroduRaspuns.Text.ToLower())
            {
                raspuns4.ForeColor = Color.White;
                IntroduRaspuns.Clear();
                Punctaj += 12;
                raspunsuri[3] = " ";
                RaspunsuriCorecte++;
            }

            else if (raspunsuri[4].ToLower() == IntroduRaspuns.Text.ToLower())
            {
                raspuns5.ForeColor = Color.White;
                IntroduRaspuns.Clear();
                Punctaj += 10;
                raspunsuri[4] = " ";
                RaspunsuriCorecte++;
            }

            else if (raspunsuri[5].ToLower() == IntroduRaspuns.Text.ToLower())
            {
                raspuns6.ForeColor = Color.White;
                IntroduRaspuns.Clear();
                Punctaj += 8;
                raspunsuri[5] = " ";
                RaspunsuriCorecte++;
            }

            else if (raspunsuri[6].ToLower() == IntroduRaspuns.Text.ToLower())
            {
                raspuns7.ForeColor = Color.White;
                IntroduRaspuns.Clear();
                Punctaj += 5;
                raspunsuri[6] = " ";
                RaspunsuriCorecte++;
            }

            else if (raspunsuri[7].ToLower() == IntroduRaspuns.Text)
            {
                raspuns8.ForeColor = Color.White;
                IntroduRaspuns.Clear();
                Punctaj += 1;
                raspunsuri[7] = " ";
                RaspunsuriCorecte++;
            }

            LabelScor.Text = Punctaj.ToString();

        }


        public void Urmatoarea_Runda()
        {
            if (NumarIntrebari < intrebari.Length - 1)
            {
                NumarIntrebari++;
                Intrebare.Text = intrebari[NumarIntrebari];
                CronometruTicks = 0;
                raspuns1.ForeColor = Color.MediumPurple;
                raspuns2.ForeColor = Color.MediumPurple;
                raspuns3.ForeColor = Color.MediumPurple;
                raspuns4.ForeColor = Color.MediumPurple;
                raspuns5.ForeColor = Color.MediumPurple;
                raspuns6.ForeColor = Color.MediumPurple;
                raspuns7.ForeColor = Color.MediumPurple;
                raspuns8.ForeColor = Color.MediumPurple;
            }
            else if (NumarIntrebari == intrebari.Length - 1)
            {
                raspuns1.Hide();
                raspuns2.Hide();
                raspuns3.Hide();
                raspuns4.Hide();
                raspuns5.Hide();
                raspuns6.Hide();
                raspuns7.Hide();
                raspuns8.Hide();
                Intrebare.Hide();
                button_WOC1.Hide();
                urm.Hide();
                IntroduRaspuns.Hide();
                Cronometru.Stop();
                LabelScor.Hide();
                CronometruLabel.Hide();
                BackToMenu.Show();
                RESTART.Show();
                PanouScor.Text = "Felicitar , ai strans un total de  " + Punctaj + " puncte"
                    + Environment.NewLine
                    + "Ai avut " + RaspunsuriCorecte + " raspunsuri corecte";
                PanouScor.Show();
            }

            if (NumarIntrebari == 1)
            {
                raspuns1.Text = "Bere"; raspunsuri[0] = "Bere";
                raspuns2.Text = "Alcool"; raspunsuri[1] = "Alcool";
                raspuns3.Text = "Vin"; raspunsuri[2] = "Vin";
                raspuns4.Text = "Apa"; raspunsuri[3] = "Apa";
                raspuns5.Text = "Suc"; raspunsuri[4] = "Suc";
                raspuns6.Text = "Tuica"; raspunsuri[5] = "Tuica";
                raspuns7.Text = "Palinca"; raspunsuri[6] = "Palinca";
                raspuns8.Text = "Visinata"; raspunsuri[7] = "Visinata";
            }
            if (NumarIntrebari == 2)
            {
                raspuns1.Text = "Tigari"; raspunsuri[0] = "Tigari";
                raspuns2.Text = "Alimente"; raspunsuri[1] = "Alimente";
                raspuns3.Text = "Benzina"; raspunsuri[2] = "Benzina";
                raspuns4.Text = "Apa"; raspunsuri[3] = "Apa";
                raspuns5.Text = "Chirie"; raspunsuri[4] = "Chirie";
                raspuns6.Text = "Masini"; raspunsuri[5] = "Masini";
                raspuns7.Text = "Distractii"; raspunsuri[6] = "Distractii";
                raspuns8.Text = "Pariuri"; raspunsuri[7] = "Pariuri";
            }
            if (NumarIntrebari == 3)
            {
                raspuns1.Text = "Volswagen"; raspunsuri[0] = "Volswagen";
                raspuns2.Text = "BMW"; raspunsuri[1] = "BMW";
                raspuns3.Text = "Audi"; raspunsuri[2] = "Audi";
                raspuns4.Text = "Mercedes"; raspunsuri[3] = "Mercedes";
                raspuns5.Text = "Renault"; raspunsuri[4] = "Renault";
                raspuns6.Text = "Peugeot"; raspunsuri[5] = "Peugeot";
                raspuns7.Text = "Toyota"; raspunsuri[6] = "Toyota";
                raspuns8.Text = "Fiat"; raspunsuri[7] = "Fiat";
            }


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            CronometruTicks++;
            CronometruLabel.Text = (60 * 3 - CronometruTicks).ToString();
            if (CronometruTicks == 60 * 3)
            {
                CronometruTicks = 0;
                Urmatoarea_Runda();
            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Urmatoarea_Runda();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void restart(object sender, EventArgs e)
        {

        }

        private void Urm_Runda(object sender, EventArgs e)
        {
            Urmatoarea_Runda();
        }
    }
}
