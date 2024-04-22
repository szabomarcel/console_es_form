using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _form_dolgozo_egyszeru_;

namespace _form_dolgozo_egyszeru_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //textBox_Belepesev; textBox_Ber; textBox_Neme; textBox_Nev; textBox_Reszleg;
        private void listBox_Dolgozok_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Betoltes_Click(sender, e);
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_Nev.Clear();
            textBox_Neme.Clear();
            textBox_Reszleg.Clear();
            textBox_Belepesev.Clear();
            textBox_Ber.Clear();
        }

        private void button_Feltoltes_Click(object sender, EventArgs e)
        {
            // Felhasználók listája vagy más adatforrás
            List<Dolgozo> employees = new List<Dolgozo>(); // Az adatok beszerzése valahonnan

            // A kiválasztott elem megjelenítése a szövegdobozokban
            Dolgozo selectedEmployee = (Dolgozo)listBox_Dolgozok.SelectedItem;

            if (selectedEmployee != null)
            {
                textBox_Nev.Text = selectedEmployee.nev;
                textBox_Neme.Text = selectedEmployee.neme;
                textBox_Reszleg.Text = selectedEmployee.reszleg;
                textBox_Belepesev.Text = selectedEmployee.belepesev.ToString();
                textBox_Ber.Text = selectedEmployee.ber.ToString();
            }
        }

        private void button_Betoltes_Click(object sender, EventArgs e)
        {
            button_Feltoltes_Click(sender, e);
        }
    }
}
