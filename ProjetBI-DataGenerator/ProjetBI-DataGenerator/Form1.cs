using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBI_DataGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void generateClick(object sender, EventArgs e)
        {
            String[] types = { "Acidofilo", "Bouteille cola", "Brazil pik", "Color Schtroummpf pik", "Langues acides", "London pik" };
            String[] colors = { "Rouge", "Orange", "Jaune" };
            String[] variants = { "Acide", "Sucré", "Gélifié" };
            String[] textures = { "Mou", "Dur" };
            String[] conditionings = { "Sachet", "Boite", "échantillon" };
            String[,] countries = {{"Royaume-Uni", "Camion"}, {"Slovaquie", "Camion"}, {"Slovénie", "Camion"}, {"Suède", "Camion"}, {"USA", "Avion"}, {"Canada", "Avion"}, {"Mexique", "Avion"}, {"Japon", "Bateau"}, {"Chine", "Avion"}, {"Afrique du sud",  "Bateau"}};
            Config config = new Config(types, colors, variants, textures, conditionings, countries);

            RandomPicker randPick = new RandomPicker(config);

            Order order = new Order(randPick);

            textBox1.Text = order.ToString();
        }
    }
}
