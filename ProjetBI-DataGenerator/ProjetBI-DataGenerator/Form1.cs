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
            Config config = new Config(types, colors, variants, textures, conditionings);

            Order order = new Order(config);

            textBox1.Text = order.ToString();
        }
    }
}
