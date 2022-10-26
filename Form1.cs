using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_elkuld_Click(object sender, EventArgs e)
        {
            bool hibae = false;
            string hiba = "Hiba!\nA következőket nem adtad meg:";
            if (numeric_azonosito.Value == 0)
            {
                hiba += " Hiányzó azonositó!";
                hibae = true;
            }
            if (string.IsNullOrEmpty(textbox_nev.Text))
            {
                hiba += " Hiányzó név!";
                hibae = true;
            }
            if (radio_angol.Checked == false && radio_francia.Checked == false & radio_nemet.Checked == false && radio_olasz.Checked == false)
            {
                hiba += " Nem választottál nyelvet!";
                hibae = true;
            }
            if (string.IsNullOrEmpty(combobox_holszuletett.Text))
            {
                hiba += " Hiányzó születési hely!";
                hibae = true;
            }
            if (hibae)
            {
                MessageBox.Show(hiba, "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Sikeresen megadtál minden adatot!", "Sikeres kitöltés!", MessageBoxButtons.OK);
            }
        }
    }
}
