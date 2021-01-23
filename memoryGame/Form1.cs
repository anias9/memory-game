using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<Image> heroes = Heroes.getHeroes();
        private PictureBox[] pictureBoxes => Controls.OfType<PictureBox>().ToArray();

        public Form1()
        {
            InitializeComponent();

            setRandomHero();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

  
        private void clickImage(object sender, EventArgs e)
        {

        }


        private void setRandomHero()
        {
            foreach (var hero in heroes)
            {
                getFreeCard().Image = hero;
                getFreeCard().Image = hero;
            }
        }

        private PictureBox getFreeCard()
        {
            int num;

            do
                num = random.Next(0, pictureBoxes.Count());
            while (pictureBoxes[num].Image != null);

            return pictureBoxes[num];
        }
    }
}
