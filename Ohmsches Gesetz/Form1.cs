using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohmsches_Gesetz
{
    public partial class Form1 : Form
    {
        Widerstand Ohm = new Widerstand();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Möchten Sie das Programm wirklich beenden?", "Programm beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit(); // Wenn "Ja" wird das Programm beendet
            }
        }

        private void rbChanged(object sender, EventArgs e)
        {
            /**
             *      U       |
             *     ---      |   U R I Rechnungsformel!
             *     R*I      |
             *     
             *     Widerstand = U / I
             *     Strom = U / R
             *     Spannung = I * R   
             **/

            if (rB_widerstand.Checked)
            {
                dlbl_wert1.Text = "Spannung [U]";
                dlbl_wert2.Text = "Strom [I]";
            }
            else if (rb_strom.Checked)
            {
                dlbl_wert1.Text = "Widerstand [R]";
                dlbl_wert2.Text = "Spannung [U]";
            }
            else if (rB_spannung.Checked)
            {
                dlbl_wert1.Text = "Widerstand [R]";
                dlbl_wert2.Text = "Strom [I]";
            }
        }

        private void btn_Berechnen_Click(object sender, EventArgs e)
        {
            if (rB_widerstand.Checked)
            {
                double spannung = Convert.ToDouble(tB_wert1.Text);
                double strom = Convert.ToDouble(tB_wert2.Text);
                Ohm.spannung = spannung;
                Ohm.strom = strom;
                Ohm.widerstand = Ohm.berechneWiderstand();
                MessageBox.Show("Der Widerstand beträgt: " + Ohm.widerstand + " Ohm");
            }
            else if (rb_strom.Checked)
            {
                double widerstand = Convert.ToDouble(tB_wert1.Text);
                double spannung = Convert.ToDouble(tB_wert2.Text);
                Ohm.widerstand = widerstand;
                Ohm.spannung = spannung;
                Ohm.strom = Ohm.berechneStrom();
                MessageBox.Show("Der Strom beträgt: " + Ohm.strom + " Ampere");
            }
            else if (rB_spannung.Checked)
            {
                double widerstand = Convert.ToDouble(tB_wert1.Text);
                double strom = Convert.ToDouble(tB_wert2.Text);
                Ohm.widerstand = widerstand;
                Ohm.strom = strom;
                Ohm.spannung = Ohm.berechneSpannung();
                MessageBox.Show("Die Spannung beträgt: " + Ohm.spannung + " Volt");
            }
        }
    }
    class Widerstand
    {
        public double widerstand;
        public double spannung;
        public double strom;
        private double Ergebnis;

        public double berechneWiderstand()
        {
            Ergebnis = spannung / strom;
            return Ergebnis;
        }

        public double berechneStrom()
        {
            Ergebnis = spannung / widerstand;
            return Ergebnis;
        }

        public double berechneSpannung()
        {
            Ergebnis = strom * widerstand;
            return Ergebnis;
        }
    }
}