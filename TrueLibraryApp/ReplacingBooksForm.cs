using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueLibraryApp
{
    public partial class ReplacingBooksForm : Form
    {
        //this is the variable for counting how many switches have been made
        public int switches = 0;

        //these are the variables that will hold what appears on thelabels
        public string lbl1 = null;
        public string lbl2 = null;
        public string lbl3 = null;
        public string lbl4 = null;
        public string lbl5 = null;
        public string lbl6 = null;
        public string lbl7 = null;
        public string lbl8 = null;
        public string lbl9 = null;
        public string lbl10 = null;

        //these are the lists for the order that the user made and the correct order that will be compared
        public List<string> listMain = new List<string>();
        public List<string> listComp = new List<string>();

        //these main and comp variables are for holding the items in the 2 lists for comparing
        public string Main1 = null;
        public string Main2 = null;
        public string Main3 = null;
        public string Main4 = null;
        public string Main5 = null;
        public string Main6 = null;
        public string Main7 = null;
        public string Main8 = null;
        public string Main9 = null;
        public string Main10 = null;

        public string Comp1 = null;
        public string Comp2 = null;
        public string Comp3 = null;
        public string Comp4 = null;
        public string Comp5 = null;
        public string Comp6 = null;
        public string Comp7 = null;
        public string Comp8 = null;
        public string Comp9 = null;
        public string Comp10 = null;


        
        public int ProgNum1 = 0;
        public int ProgNum2 = 0;
        public int ProgNum3 = 0;
        public int ProgNum4 = 0;
        public int ProgNum5 = 0;
        public int ProgNum6 = 0;
        public int ProgNum7 = 0;
        public int ProgNum8 = 0;
        public int ProgNum9 = 0;
        public int ProgNum10 = 0;


        public ReplacingBooksForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ReplacingBooksForm_Load(object sender, EventArgs e)
        {

            int length = 3;


            int x = 0;



            ProgBar.Maximum = 10;


            Random random = new Random();

            char letter;
            //this while loop creates all the dewey numbers for the game
            while(x < 10)
            {
                string rng1 = null;
                // creating a StringBuilder object()
                StringBuilder str_build1 = new StringBuilder();

                int r1 = (new Random()).Next(000, 1000);
                for (int i = 0; i < length; i++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    str_build1.Append(letter);
                    rng1 = r1.ToString();
                    if (rng1.Length == 2)
                    {
                        rng1 = "0" + rng1;
                    }
                    else if (rng1.Length == 1)
                    {
                        rng1 = "00" + rng1;
                    }
                }

                listComp.Add(rng1 + str_build1.ToString());
                listComp.Sort();
                listMain.Add(rng1 + str_build1.ToString());
                x++;
            }



            label1.Text = listMain.ElementAt(0);
            label2.Text = listMain.ElementAt(1);
            label3.Text = listMain.ElementAt(2);
            label4.Text = listMain.ElementAt(3);
            label5.Text = listMain.ElementAt(4);
            label6.Text = listMain.ElementAt(5);
            label7.Text = listMain.ElementAt(6);
            label8.Text = listMain.ElementAt(7);
            label9.Text = listMain.ElementAt(8);
            label10.Text = listMain.ElementAt(9);

            lbl1 = label1.Text;
            lbl2 = label2.Text;
            lbl3 = label3.Text;
            lbl4 = label4.Text;
            lbl5 = label5.Text;
            lbl6 = label6.Text;
            lbl7 = label7.Text;
            lbl8 = label8.Text;
            lbl9 = label9.Text;
            lbl10 = label10.Text;


            //will sort the list in to proper order for comparison
            //listComp.Sort();
            ProgProb();
        }

        private void giveUpBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Hub giveUp = new Hub();
            giveUp.Show();
            
        }
        //this void handles all the probability for the gaem
        private void ProgProb()
        {
            Main1 = listMain.ElementAt(0);
            Comp1 = listComp.ElementAt(0);
            Main2 = listMain.ElementAt(1);
            Comp2 = listComp.ElementAt(1);
            Main3 = listMain.ElementAt(2);
            Comp3 = listComp.ElementAt(2);
            Main4 = listMain.ElementAt(3);
            Comp4 = listComp.ElementAt(3);
            Main5 = listMain.ElementAt(4);
            Comp5 = listComp.ElementAt(4);
            Main6 = listMain.ElementAt(5);
            Comp6 = listComp.ElementAt(5);
            Main7 = listMain.ElementAt(6);
            Comp7 = listComp.ElementAt(6);
            Main8 = listMain.ElementAt(7);
            Comp8 = listComp.ElementAt(7);
            Main9 = listMain.ElementAt(8);
            Comp9 = listComp.ElementAt(8);
            Main10 = listMain.ElementAt(9);
            Comp10 = listComp.ElementAt(9);


            if (Main1.Equals(Comp1))
            {
                ProgNum1 = 1;
            }
            else
            {
                ProgNum1 = 0;
            }

            if (Main2.Equals(Comp2))
            {
                ProgNum2 = 1;
            }
            else
            {
                ProgNum2 = 0;
            }

            if (Main3.Equals(Comp3))
            {
                ProgNum3 = 1;
            }
            else
            {
                ProgNum3 = 0;
            }

            if (Main4.Equals(Comp4))
            {
                ProgNum4 = 1;
            }
            else
            {
                ProgNum4 = 0;
            }

            if (Main5.Equals(Comp5))
            {
                ProgNum5 = 1;
            }
            else
            {
                ProgNum5 = 0;
            }

            if (Main6.Equals(Comp6))
            {
                ProgNum6 = 1;
            }
            else
            {
                ProgNum6 = 0;
            }

            if (Main7.Equals(Comp7))
            {
                ProgNum7 = 1;
            }
            else
            {
                ProgNum7 = 0;
            }

            if (Main8.Equals(Comp8))
            {
                ProgNum8 = 1;
            }
            else
            {
                ProgNum8 = 0;
            }

            if (Main9.Equals(Comp9))
            {
                ProgNum9 = 1;
            }
            else
            {
                ProgNum9 = 0;
            }

            if (Main10.Equals(Comp10))
            {
                ProgNum10 = 1;
            }
            else
            {
                ProgNum10 = 0;
            }


            ProgBar.Value = ProgNum1+ProgNum2+ProgNum3+ProgNum4+ProgNum5+ProgNum6+ProgNum7+ProgNum8+ProgNum9+ProgNum10;

            if(ProgBar.Value == 10 && switches <= 5)
            {
                MessageBox.Show("Congrats you have finnished with" + "\r\n" + switchNum.Text + " Switches" + "\r\n" + "Lady luck Smiles Upon you", "CONGRATULATIONS");
                this.Close();
                Hub giveUp = new Hub();
                giveUp.Show();
            }
            else if (ProgBar.Value == 10 && 5 < switches && switches <= 10)
            {
                MessageBox.Show("Congrats you have finnished with" + "\r\n" + switchNum.Text + " Switches" + "\r\n" + "You're Such a Smarty", "CONGRATULATIONS");
                this.Close();
                Hub giveUp = new Hub();
                giveUp.Show();
            }
            else if (ProgBar.Value == 10 && 10 < switches && switches <= 49)
            {
                MessageBox.Show("Congrats you have finnished with" + "\r\n" + switchNum.Text + " Switches" + "\r\n" + "You Did It!", "CONGRATULATIONS");
                this.Close();
                Hub giveUp = new Hub();
                giveUp.Show();
            }
            else if (ProgBar.Value == 10 && 49 < switches && switches <= 99)
            {
                MessageBox.Show("Congrats you have finnished with" + "\r\n" + switchNum.Text + " Switches" + "\r\n" + "You Are Gonna Need More Practice", "CONGRATULATIONS");
                this.Close();
                Hub giveUp = new Hub();
                giveUp.Show();
            }
            else if (ProgBar.Value == 10 && 99 < switches)
            {
                MessageBox.Show("Congrats you have finnished with" + "\r\n" + switchNum.Text + " Switches" + "\r\n" + "You're gonna need to google this", "CONGRATULATIONS");
                this.Close();
                Hub giveUp = new Hub();
                giveUp.Show();
            }
        }
        //these voids for the switches handles where the progress bar should be
        private void switch1_Click(object sender, EventArgs e)
        {
            switches++;
            switchNum.Text = switches.ToString();
            label1.Text = lbl2;
            label2.Text = lbl1;
            lbl1 = label1.Text;
            lbl2 = label2.Text;

            listMain.Clear();

            listMain.Add(lbl1);
            listMain.Add(lbl2);
            listMain.Add(lbl3);
            listMain.Add(lbl4);
            listMain.Add(lbl5);
            listMain.Add(lbl6);
            listMain.Add(lbl7);
            listMain.Add(lbl8);
            listMain.Add(lbl9);
            listMain.Add(lbl10);

            ProgProb();

        }

        private void switch2_Click(object sender, EventArgs e)
        {
            switches++;
            switchNum.Text = switches.ToString();
            label2.Text = lbl3;
            label3.Text = lbl2;
            lbl2 = label2.Text;
            lbl3 = label3.Text;

            listMain.Clear();

            listMain.Add(lbl1);
            listMain.Add(lbl2);
            listMain.Add(lbl3);
            listMain.Add(lbl4);
            listMain.Add(lbl5);
            listMain.Add(lbl6);
            listMain.Add(lbl7);
            listMain.Add(lbl8);
            listMain.Add(lbl9);
            listMain.Add(lbl10);


            ProgProb();
        }

        private void switch3_Click(object sender, EventArgs e)
        {
            switches++;
            switchNum.Text = switches.ToString();
            label3.Text = lbl4;
            label4.Text = lbl3;
            lbl3 = label3.Text;
            lbl4 = label4.Text;

            listMain.Clear();

            listMain.Add(lbl1);
            listMain.Add(lbl2);
            listMain.Add(lbl3);
            listMain.Add(lbl4);
            listMain.Add(lbl5);
            listMain.Add(lbl6);
            listMain.Add(lbl7);
            listMain.Add(lbl8);
            listMain.Add(lbl9);
            listMain.Add(lbl10);

            ProgProb();
        }

        private void switch4_Click(object sender, EventArgs e)
        {
            switches++;
            switchNum.Text = switches.ToString();
            label4.Text = lbl5;
            label5.Text = lbl4;
            lbl4 = label4.Text;
            lbl5 = label5.Text;

            listMain.Clear();

            listMain.Add(lbl1);
            listMain.Add(lbl2);
            listMain.Add(lbl3);
            listMain.Add(lbl4);
            listMain.Add(lbl5);
            listMain.Add(lbl6);
            listMain.Add(lbl7);
            listMain.Add(lbl8);
            listMain.Add(lbl9);
            listMain.Add(lbl10);

            ProgProb();
        }

        private void switch5_Click(object sender, EventArgs e)
        {
            switches++;
            switchNum.Text = switches.ToString();
            label5.Text = lbl6;
            label6.Text = lbl5;
            lbl5 = label5.Text;
            lbl6 = label6.Text;

            listMain.Clear();

            listMain.Add(lbl1);
            listMain.Add(lbl2);
            listMain.Add(lbl3);
            listMain.Add(lbl4);
            listMain.Add(lbl5);
            listMain.Add(lbl6);
            listMain.Add(lbl7);
            listMain.Add(lbl8);
            listMain.Add(lbl9);
            listMain.Add(lbl10);

            ProgProb();
        }

        private void switch6_Click(object sender, EventArgs e)
        {
            switches++;
            switchNum.Text = switches.ToString();
            label6.Text = lbl7;
            label7.Text = lbl6;
            lbl6 = label6.Text;
            lbl7 = label7.Text;

            listMain.Clear();

            listMain.Add(lbl1);
            listMain.Add(lbl2);
            listMain.Add(lbl3);
            listMain.Add(lbl4);
            listMain.Add(lbl5);
            listMain.Add(lbl6);
            listMain.Add(lbl7);
            listMain.Add(lbl8);
            listMain.Add(lbl9);
            listMain.Add(lbl10);

            ProgProb();
        }

        private void switch7_Click(object sender, EventArgs e)
        {
            switches++;
            switchNum.Text = switches.ToString();
            label7.Text = lbl8;
            label8.Text = lbl7;
            lbl7 = label7.Text;
            lbl8 = label8.Text;

            listMain.Clear();

            listMain.Add(lbl1);
            listMain.Add(lbl2);
            listMain.Add(lbl3);
            listMain.Add(lbl4);
            listMain.Add(lbl5);
            listMain.Add(lbl6);
            listMain.Add(lbl7);
            listMain.Add(lbl8);
            listMain.Add(lbl9);
            listMain.Add(lbl10);

            ProgProb();
        }

        private void switch8_Click(object sender, EventArgs e)
        {
            switches++;
            switchNum.Text = switches.ToString();
            label8.Text = lbl9;
            label9.Text = lbl8;
            lbl8 = label8.Text;
            lbl9 = label9.Text;

            listMain.Clear();

            listMain.Add(lbl1);
            listMain.Add(lbl2);
            listMain.Add(lbl3);
            listMain.Add(lbl4);
            listMain.Add(lbl5);
            listMain.Add(lbl6);
            listMain.Add(lbl7);
            listMain.Add(lbl8);
            listMain.Add(lbl9);
            listMain.Add(lbl10);

            ProgProb();
        }

        private void switch9_Click(object sender, EventArgs e)
        {
            switches++;
            switchNum.Text = switches.ToString();
            label9.Text = lbl10;
            label10.Text = lbl9;
            lbl9 = label9.Text;
            lbl10 = label10.Text;

            listMain.Clear();

            listMain.Add(lbl1);
            listMain.Add(lbl2);
            listMain.Add(lbl3);
            listMain.Add(lbl4);
            listMain.Add(lbl5);
            listMain.Add(lbl6);
            listMain.Add(lbl7);
            listMain.Add(lbl8);
            listMain.Add(lbl9);
            listMain.Add(lbl10);

            ProgProb();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
