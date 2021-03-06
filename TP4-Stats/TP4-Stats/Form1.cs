﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace TP4_Stats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Calculer_Click(object sender, EventArgs e)
        {
            if (TB_EcartType.Text != "" && TB_Moyenne.Text != "" && TB_a.Text != "")
            {
                if (double.Parse(TB_EcartType.Text) > 0)
                    if (RB_1.Checked && TB_b.Text != "")
                    {
                        if (double.Parse(TB_a.Text) < double.Parse(TB_b.Text))
                            CalculerProb1(double.Parse(TB_a.Text), double.Parse(TB_b.Text));
                        else
                            MessageBox.Show("Erreur, le 'a' doit être plus petit que le 'b'");
                    }
                    else if (RB_2.Checked)
                    {
                        CalculerProb2(double.Parse(TB_a.Text));
                    }
                    else if (RB_3.Checked)
                    {
                        CalculerProb3(double.Parse(TB_a.Text));
                    }
                    else
                        MessageBox.Show("Erreur, l'écart type doit être positif");

            }
            else
            {
                MessageBox.Show("Erreur, veuillez entrer les informations nécéssaires");
            }
        }

        private void RB_1_CheckedChanged(object sender, EventArgs e)
        {
            ChangerTB_b();
        }

        private void RB_2_CheckedChanged(object sender, EventArgs e)
        {
            ChangerTB_b();
        }

        private void RB_3_CheckedChanged(object sender, EventArgs e)
        {
            ChangerTB_b();
        }

        private void ChangerTB_b()
        {
            if (!RB_1.Checked)
            {
                TB_b.ReadOnly = true;
            }
            else
            {
                TB_b.ReadOnly = false;
            }
        }

        private void CalculerProb1(double a, double b)
        {
            // Calculer la CoteZ
            double CoteZA = CalculerCoteZ(a);
            double CoteZB = CalculerCoteZ(b);

            // Prendre la Dernière décimale de la CoteZA
            double HorizontalA = (CoteZA - Math.Truncate(CoteZA)) * 10;
            HorizontalA = Math.Round(HorizontalA, 2);
            HorizontalA = (HorizontalA - Math.Truncate(HorizontalA)) * 10;
            HorizontalA = Math.Round(HorizontalA, 2);
            HorizontalA = Math.Truncate(HorizontalA);
            HorizontalA = Math.Abs(HorizontalA);
            // Prendre les 2 premières décimales de la CoteZA
            double VerticalA = CoteZA * 10;
            VerticalA = Math.Truncate(VerticalA);
            VerticalA = Math.Abs(VerticalA);

            // Prendre la Dernière décimale de la CoteZB
            double HorizontalB = (CoteZB - Math.Truncate(CoteZB)) * 10;
            HorizontalB = Math.Round(HorizontalB, 2);
            HorizontalB = (HorizontalB - Math.Truncate(HorizontalB)) * 10;
            HorizontalB = Math.Round(HorizontalB, 2);
            HorizontalB = Math.Truncate(HorizontalB);
            HorizontalB = Math.Abs(HorizontalB);

            // Prendre les 2 premières décimales de la CoteZB
            double VerticalB = CoteZB * 10;
            VerticalB = Math.Truncate(VerticalB);
            VerticalB = Math.Abs(VerticalB);

            double Resultat1 = GetFromExcel(VerticalA, HorizontalA);
            double Resultat2 = GetFromExcel(VerticalB, HorizontalB);

            if (CoteZA < 0)
                if (Resultat1 != 0)
                    Resultat1 = 100 - Resultat1;
            if (CoteZB > 4)
                if(Resultat2 == 0 && CoteZA < 4)
                    Resultat2 = 100;

            double ResultatFinal;
            if (Resultat1 > Resultat2)
                ResultatFinal = Resultat1 - Resultat2;
            else
                ResultatFinal = Resultat2 - Resultat1;

            ResultatFinal = Math.Round(ResultatFinal, 2);
            TB_Resultat.Text = ResultatFinal.ToString() + "%";
        }

        private void CalculerProb2(double a)
        {
            // Calculer la CoteZ
            double CoteZ = CalculerCoteZ(a);

            // Prendre la Dernière décimale de la CoteZA
            double Horizontal = (CoteZ - Math.Truncate(CoteZ)) * 10;
            Horizontal = Math.Round(Horizontal, 2);
            Horizontal = (Horizontal - Math.Truncate(Horizontal)) * 10;
            Horizontal = Math.Round(Horizontal, 2);
            Horizontal = Math.Truncate(Horizontal);
            Horizontal = Math.Abs(Horizontal);

            // Prendre les 2 premières décimales de la CoteZA
            double Vertical = CoteZ * 10;
            Vertical = Math.Truncate(Vertical);
            Vertical = Math.Abs(Vertical);

            double Resultat = GetFromExcel(Vertical, Horizontal);

            if (CoteZ > 4)
                Resultat = 100;

            if (Resultat != 0 && CoteZ < 0)
                Resultat = 100 - Resultat;
            
            

            Resultat = Math.Round(Resultat, 2);
            TB_Resultat.Text = Resultat.ToString() + "%";
        }

        private void CalculerProb3(double a)
        {
            // Calculer La CoteZ
            double CoteZ = CalculerCoteZ(a);

            // Prendre la Dernière décimale de la CoteZA
            double Horizontal = (CoteZ - Math.Truncate(CoteZ)) * 10;
            Horizontal = Math.Round(Horizontal, 2);
            Horizontal = (Horizontal - Math.Truncate(Horizontal)) * 10;
            Horizontal = Math.Round(Horizontal, 2);
            Horizontal = Math.Truncate(Horizontal);
            Horizontal = Math.Abs(Horizontal);

            // Prendre les 2 premières décimales de la CoteZA
            double Vertical = CoteZ * 10;
            Vertical = Math.Truncate(Vertical);
            Vertical = Math.Round(Vertical);
            Vertical = Math.Abs(Vertical);

            double Resultat = GetFromExcel(Vertical, Horizontal);

            if (CoteZ > 4)
                Resultat = 100;

            if (Resultat != 0 && CoteZ < 0)
                Resultat = 100 - Resultat;

            Resultat = 100 - Resultat;

            Resultat = Math.Round(Resultat, 2);

            TB_Resultat.Text = Resultat.ToString() + "%";
        }

        private double CalculerCoteZ(double a)
        {
            double CoteZ;

            CoteZ = (a - double.Parse(TB_Moyenne.Text)) / double.Parse(TB_EcartType.Text);

            CoteZ = Math.Round(CoteZ, 2);
            return CoteZ;
        }

        private void BTN_Aide_Click(object sender, EventArgs e)
        {
            Aide aide = new Aide();
            aide.ShowDialog();
        }

        private double GetFromExcel(double Vertical, double Horizontal)
        {
            Microsoft.Office.Interop.Excel.Application myapp = new Microsoft.Office.Interop.Excel.Application();


            Microsoft.Office.Interop.Excel.Workbook wb = myapp.Workbooks.Open(@Directory.GetCurrentDirectory() + "\\tablenormale.xlsx");

            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets.get_Item(1);


            if(!double.IsNaN(Vertical) && !double.IsNaN(Horizontal))
            {
                var cell = ((Microsoft.Office.Interop.Excel.Range)sheet.Cells[Vertical + 2, Horizontal + 2]);

                double Valeur;

                if (cell.Value2 != null)
                    Valeur = double.Parse(cell.Value2.ToString()) * 100;
                else
                    Valeur = 0;
                Valeur = Math.Round(Valeur, 2);

                wb.Close(0);
                myapp.Quit();
                return Valeur;
            }
            else
            {
                wb.Close(0);
                myapp.Quit();
                return 0;
            }
        }

        private void BTN_Effacer_Click(object sender, EventArgs e)
        {
            TB_a.Text = "";
            TB_b.Text = "";
            TB_EcartType.Text = "";
            TB_Moyenne.Text = "";
            TB_Resultat.Text = "";
        }
    }
}
