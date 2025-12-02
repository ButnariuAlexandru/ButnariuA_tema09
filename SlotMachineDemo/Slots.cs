using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachineDemo
{
        public partial class Slots : Form
        {
            private List<System.Drawing.Image> imagini;
            private Random rnd = new Random();
            private Timer timer;
            private int cicluriRamase;
            private int credits = 500;


        public Slots()
            {
                InitializeComponent();


            TbCredits.Text = credits.ToString();
            imagini = new List<System.Drawing.Image>()
            {
                Properties.Resources.img1,
                Properties.Resources.img2,
                Properties.Resources.img3,
                Properties.Resources.img4,
                Properties.Resources.img5,
                Properties.Resources.img6
            };
                timer = new Timer();
                timer.Interval = 500;
                timer.Tick += Timer_Tick;

                BPull.Click += BPull_Click;
            }

            private void BPull_Click(object sender, EventArgs e)
            {
            if (credits < 50)
            {
                MessageBox.Show("Nu mai ai suficient credite pentru a trage!",
                                "Credit insuficient",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; 
            }
            credits -= 50;
            TbCredits.Text = credits.ToString();

            cicluriRamase = (int)UDCycles.Value;
                BPull.Enabled = false;

                timer.Start();
            }

            private void Timer_Tick(object sender, EventArgs e)
            {
                // rulează până se termină ciclurile
                if (cicluriRamase > 0)
                {
                    cicluriRamase--;
                    RuleazaSloturi();
                }
                else
                {
                    timer.Stop();
                    BPull.Enabled = true;
                    VerificaRezultat();
                }
            }

            private void RuleazaSloturi()
            {
                pb1.Image = imagini[rnd.Next(imagini.Count)];
                pb2.Image = imagini[rnd.Next(imagini.Count)];
                pb3.Image = imagini[rnd.Next(imagini.Count)];
                pb4.Image = imagini[rnd.Next(imagini.Count)];
                pb5.Image = imagini[rnd.Next(imagini.Count)];
                pb6.Image = imagini[rnd.Next(imagini.Count)];
                pb7.Image = imagini[rnd.Next(imagini.Count)];
                pb8.Image = imagini[rnd.Next(imagini.Count)];
                pb9.Image = imagini[rnd.Next(imagini.Count)];
        }

            private void VerificaRezultat()
            {
            if (pb1.Image == pb2.Image && pb2.Image == pb3.Image)
            {
                TbMesaj.Text = "🎉 Ai câștigat! Toate imaginile sunt identice!";
                credits += 75;
            }
            else
            {
                TbMesaj.Text = "Ai pierdut! Poți încerca din nou!";
            }

            TbCredits.Text = credits.ToString();

            // Permite o nouă tragere
            BPull.Enabled = true;
        }
        }
    }


