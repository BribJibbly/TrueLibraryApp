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
    public partial class IdentifyingAreasForms : Form
    {
        string btnCol1Sel = null;
        string btnCol2Sel = null;
        string btnName1 = null;
        string btnName2 = null;
        int clickCount = 0;
        int x = 1;
        int y = 1;
        int z = 1;
        int z2 = 1;
        int num = 1;

        //lists that hold random numbers for randomizing
        public List<int> numRep1 = new List<int>();
        public List<int> numRep2 = new List<int>();
        public List<int> numRep3 = new List<int>();

        public IdentifyingAreasForms()
        {
            InitializeComponent();
        }

        private void IdentifyingAreasForms_Load(object sender, EventArgs e)
        {
            GamePRG.Maximum = 4;

            gameStore();

            var ranNum = new Random();

            //MessageBox.Show(gameStore().ElementAt(setNum).Value.ToString());
            //these are random number generators that generate numbers
            //but do not generate repeat numbers.
            // code provided by user George616 on Oct 27,2020 at ASPForums
            //URL:https://www.aspsnippets.com/questions/439597/Generate-random-numbers-without-repeat-using-C-and-VBNet-in-ASPNet/
            while (x < 5)
            {
                int setNum = ranNum.Next(0, 5);
                if (!numRep1.Contains(setNum))
                {
                    numRep1.Add(setNum);
                    x++;
                }
            }
            while (y < 4)
            {
                int setNum2 = ranNum.Next(5, 9);
                if (!numRep2.Contains(setNum2))
                {
                    numRep2.Add(setNum2);
                    y++;
                }
            }
            while (num < 5)
            {
                int eleName = ranNum.Next(0, 4);
                if (!numRep3.Contains(eleName))
                {
                    numRep3.Add(eleName);
                    num++;
                }
            }

            int setNum3 = ranNum.Next(1, 3);
            int setNum4 = ranNum.Next(1, 3);
            z = setNum3;
            z2 = setNum4;
            bool ranGame = z == 1;
            bool ranGame2 = z2 == 1;
            
            //these following if statements are made so that the questions always have a correct answer
            //as well as switches the game up randomly
            if (ranGame.Equals(true) && ranGame2.Equals(true))
            {
                Col1BTN1.Text = gameStore().ElementAt(numRep1.ElementAt(0)).Key.ToString();
                Col1BTN2.Text = gameStore().ElementAt(numRep1.ElementAt(1)).Key.ToString();
                Col1BTN3.Text = gameStore().ElementAt(numRep1.ElementAt(2)).Key.ToString();
                Col1BTN4.Text = gameStore().ElementAt(numRep1.ElementAt(3)).Key.ToString();
                Col2BTN1.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(0))).Value.ToString();
                Col2BTN2.Text = gameStore().ElementAt(numRep2.ElementAt(0)).Value.ToString();
                Col2BTN3.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(1))).Value.ToString();
                Col2BTN4.Text = gameStore().ElementAt(numRep2.ElementAt(1)).Value.ToString();
                Col2BTN5.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(2))).Value.ToString();
                Col2BTN6.Text = gameStore().ElementAt(numRep2.ElementAt(2)).Value.ToString();
                Col2BTN7.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(3))).Value.ToString();
            }
            if (ranGame.Equals(true) && ranGame2.Equals(false))
            {
                Col1BTN1.Text = gameStore().ElementAt(numRep1.ElementAt(0)).Key.ToString();
                Col1BTN2.Text = gameStore().ElementAt(numRep1.ElementAt(1)).Key.ToString();
                Col1BTN3.Text = gameStore().ElementAt(numRep1.ElementAt(2)).Key.ToString();
                Col1BTN4.Text = gameStore().ElementAt(numRep1.ElementAt(3)).Key.ToString();
                Col2BTN2.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(0))).Value.ToString();
                Col2BTN3.Text = gameStore().ElementAt(numRep2.ElementAt(0)).Value.ToString();
                Col2BTN5.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(1))).Value.ToString();
                Col2BTN7.Text = gameStore().ElementAt(numRep2.ElementAt(1)).Value.ToString();
                Col2BTN4.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(2))).Value.ToString();
                Col2BTN1.Text = gameStore().ElementAt(numRep2.ElementAt(2)).Value.ToString();
                Col2BTN6.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(3))).Value.ToString();
            }
            else if (ranGame.Equals(false) && ranGame2.Equals(true))
            {
                Col1BTN1.Text = gameStore().ElementAt(numRep1.ElementAt(0)).Value.ToString();
                Col1BTN2.Text = gameStore().ElementAt(numRep1.ElementAt(1)).Value.ToString();
                Col1BTN3.Text = gameStore().ElementAt(numRep1.ElementAt(2)).Value.ToString();
                Col1BTN4.Text = gameStore().ElementAt(numRep1.ElementAt(3)).Value.ToString();
                Col2BTN7.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(0))).Key.ToString();
                Col2BTN3.Text = gameStore().ElementAt(numRep2.ElementAt(0)).Key.ToString();
                Col2BTN6.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(1))).Key.ToString();
                Col2BTN5.Text = gameStore().ElementAt(numRep2.ElementAt(1)).Key.ToString();
                Col2BTN1.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(2))).Key.ToString();
                Col2BTN4.Text = gameStore().ElementAt(numRep2.ElementAt(2)).Key.ToString();
                Col2BTN2.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(3))).Key.ToString();
            }
            else if (ranGame.Equals(false) && ranGame2.Equals(false))
            {
                Col1BTN1.Text = gameStore().ElementAt(numRep1.ElementAt(0)).Value.ToString();
                Col1BTN2.Text = gameStore().ElementAt(numRep1.ElementAt(1)).Value.ToString();
                Col1BTN3.Text = gameStore().ElementAt(numRep1.ElementAt(2)).Value.ToString();
                Col1BTN4.Text = gameStore().ElementAt(numRep1.ElementAt(3)).Value.ToString();
                Col2BTN3.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(0))).Key.ToString();
                Col2BTN4.Text = gameStore().ElementAt(numRep2.ElementAt(0)).Key.ToString();
                Col2BTN1.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(1))).Key.ToString();
                Col2BTN5.Text = gameStore().ElementAt(numRep2.ElementAt(1)).Key.ToString();
                Col2BTN6.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(2))).Key.ToString();
                Col2BTN2.Text = gameStore().ElementAt(numRep2.ElementAt(2)).Key.ToString();
                Col2BTN7.Text = gameStore().ElementAt(numRep1.ElementAt(numRep3.ElementAt(3))).Key.ToString();
            }


        }
        //this is the dictionary that holds our values we will be using to compare
        public Dictionary<string, string> gameStore()
        {
            Dictionary<string, string> game = new Dictionary<string, string>();
            game.Add("000-099","General Information");
            game.Add("100-199", "Philosophy & Psychology");
            game.Add("200-299", "Religion");
            game.Add("300-399", "Social Sciences");
            game.Add("400-499", "Language");
            game.Add("500-599", "Science");
            game.Add("600-699", "Technology");
            game.Add("700-799", "Arts & Recreation");
            game.Add("800-899", "Literature");
            game.Add("900-999", "History & Geography");

            return game;
        }

        //the following buttons all have practically the same code therefore comments will be limited
        //to one button.
        private void Col1BTN1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            btnCol1Sel = Col1BTN1.Text.ToString();
            Col1BTN1.FlatStyle = FlatStyle.Flat;
            Col1BTN1.FlatAppearance.BorderColor = Color.RoyalBlue;
            Col1BTN1.FlatAppearance.BorderSize = 3;
            Col1BTN2.FlatStyle = FlatStyle.Standard;
            Col1BTN3.FlatStyle = FlatStyle.Standard;
            Col1BTN4.FlatStyle = FlatStyle.Standard;
            btnName1 = "Col1BTN1";
            clickCount++;
            //this if statement makes sure that 2 buttons have been clicked other wise it does nothing
            if (!String.IsNullOrEmpty(btnCol1Sel) && !String.IsNullOrEmpty(btnCol2Sel))
            {
                Control btn = this.Controls.Find(btnName2, true)[0] as Control;
                //if two buttons have been clicked this if statement makes sure that they are compared
                if (z == 1)
                {
                    //here it basically says if they are the same disable the buttons so they cannot
                    //be clicked again and then change their colour to green to show they are correct
                    //and increase the progress bar
                    if (btnCol2Sel.Equals(gameStore()[btnCol1Sel].ToString()))
                    {
                        Col1BTN1.Enabled = false;

                        btn.Enabled = false;

                        Col1BTN1.BackColor = Color.GreenYellow;

                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
                //this is the same as the if statement above but this is for if the game
                //has been randomised in a certain for comparing.
                else if (z == 2)
                {
                    if (btnCol1Sel.Equals(gameStore()[btnCol2Sel].ToString()))
                    {
                        Col1BTN1.Enabled = false;

                        btn.Enabled = false;

                        Col1BTN1.BackColor = Color.GreenYellow;

                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
            }
        }

        private void Col1BTN2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            btnCol1Sel = Col1BTN2.Text.ToString();
            Col1BTN2.FlatStyle = FlatStyle.Flat;
            Col1BTN2.FlatAppearance.BorderColor = Color.RoyalBlue;
            Col1BTN2.FlatAppearance.BorderSize = 3;
            Col1BTN1.FlatStyle = FlatStyle.Standard;
            Col1BTN3.FlatStyle = FlatStyle.Standard;
            Col1BTN4.FlatStyle = FlatStyle.Standard;
            btnName1 = "Col1BTN2";
            clickCount++;

            if (!String.IsNullOrEmpty(btnCol1Sel) && !String.IsNullOrEmpty(btnCol2Sel))
            {
                Control btn = this.Controls.Find(btnName2, true)[0] as Control;
                if(z == 1)
                {
                    if (btnCol2Sel.Equals(gameStore()[btnCol1Sel].ToString()))
                    {

                        Col1BTN2.Enabled = false;
                        btn.Enabled = false;
                        Col1BTN2.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
               else if (z == 2)
                {
                    if (btnCol1Sel.Equals(gameStore()[btnCol2Sel].ToString()))
                    {

                        Col1BTN2.Enabled = false;
                        btn.Enabled = false;
                        Col1BTN2.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }

            }
        }

        private void Col1BTN3_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            btnCol1Sel = Col1BTN3.Text.ToString();
            Col1BTN3.FlatStyle = FlatStyle.Flat;
            Col1BTN3.FlatAppearance.BorderColor = Color.RoyalBlue;
            Col1BTN3.FlatAppearance.BorderSize = 3;
            Col1BTN2.FlatStyle = FlatStyle.Standard;
            Col1BTN1.FlatStyle = FlatStyle.Standard;
            Col1BTN4.FlatStyle = FlatStyle.Standard;
            btnName1 = "Col1BTN3";
            clickCount++;

            if (!String.IsNullOrEmpty(btnCol1Sel) && !String.IsNullOrEmpty(btnCol2Sel))
            {
                Control btn = this.Controls.Find(btnName2, true)[0] as Control;
                if(z == 1)
                {
                    if (btnCol2Sel.Equals(gameStore()[btnCol1Sel].ToString()))
                    {

                        Col1BTN3.Enabled = false;
                        btn.Enabled = false;
                        Col1BTN3.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
                else if (z == 2)
                {
                    if (btnCol1Sel.Equals(gameStore()[btnCol2Sel].ToString()))
                    {

                        Col1BTN3.Enabled = false;
                        btn.Enabled = false;
                        Col1BTN3.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }

            }
        }

        private void Col1BTN4_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            btnCol1Sel = Col1BTN4.Text.ToString();
            Col1BTN4.FlatStyle = FlatStyle.Flat;
            Col1BTN4.FlatAppearance.BorderColor = Color.RoyalBlue;
            Col1BTN4.FlatAppearance.BorderSize = 3;
            Col1BTN2.FlatStyle = FlatStyle.Standard;
            Col1BTN3.FlatStyle = FlatStyle.Standard;
            Col1BTN1.FlatStyle = FlatStyle.Standard;
            btnName1 = "Col1BTN4";
            clickCount++;

            if (!String.IsNullOrEmpty(btnCol1Sel) && !String.IsNullOrEmpty(btnCol2Sel))
            {
                Control btn = this.Controls.Find(btnName2, true)[0] as Control;
                if(z == 1)
                {
                    if (btnCol2Sel.Equals(gameStore()[btnCol1Sel].ToString()))
                    {

                        Col1BTN4.Enabled = false;
                        btn.Enabled = false;
                        Col1BTN4.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
                else if (z == 2)
                {
                    if (btnCol1Sel.Equals(gameStore()[btnCol2Sel].ToString()))
                    {

                        Col1BTN4.Enabled = false;
                        btn.Enabled = false;
                        Col1BTN4.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }

            }
        }

        private void Col2BTN1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            btnCol2Sel = Col2BTN1.Text.ToString();

            Col2BTN1.FlatStyle = FlatStyle.Flat;
            Col2BTN1.FlatAppearance.BorderColor = Color.RoyalBlue;
            Col2BTN1.FlatAppearance.BorderSize = 3;
            Col2BTN2.FlatStyle = FlatStyle.Standard;
            Col2BTN3.FlatStyle = FlatStyle.Standard;
            Col2BTN4.FlatStyle = FlatStyle.Standard;
            Col2BTN5.FlatStyle = FlatStyle.Standard;
            Col2BTN6.FlatStyle = FlatStyle.Standard;
            Col2BTN7.FlatStyle = FlatStyle.Standard;
            btnName2 = "Col2BTN1";
            clickCount++;

            if (!String.IsNullOrEmpty(btnCol1Sel) && !String.IsNullOrEmpty(btnCol2Sel))
            {
                Control btn = this.Controls.Find(btnName1, true)[0] as Control;
                if(z == 1)
                {
                    if (btnCol2Sel.Equals(gameStore()[btnCol1Sel].ToString()))
                    {
                        Col2BTN1.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN1.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
                else if (z == 2)
                {
                    if (btnCol1Sel.Equals(gameStore()[btnCol2Sel].ToString()))
                    {
                        Col2BTN1.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN1.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }

            }
        }

        private void Col2BTN2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            btnCol2Sel = Col2BTN2.Text.ToString();

            Col2BTN2.FlatStyle = FlatStyle.Flat;
            Col2BTN2.FlatAppearance.BorderColor = Color.RoyalBlue;
            Col2BTN2.FlatAppearance.BorderSize = 3;
            Col2BTN1.FlatStyle = FlatStyle.Standard;
            Col2BTN3.FlatStyle = FlatStyle.Standard;
            Col2BTN4.FlatStyle = FlatStyle.Standard;
            Col2BTN5.FlatStyle = FlatStyle.Standard;
            Col2BTN6.FlatStyle = FlatStyle.Standard;
            Col2BTN7.FlatStyle = FlatStyle.Standard;
            btnName2 = "Col2BTN2";
            clickCount++;

            if (!String.IsNullOrEmpty(btnCol1Sel) && !String.IsNullOrEmpty(btnCol2Sel))
            {
                Control btn = this.Controls.Find(btnName1, true)[0] as Control;
                if (z == 1)
                {
                    if (btnCol2Sel.Equals(gameStore()[btnCol1Sel].ToString()))
                    {
                        Col2BTN2.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN2.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
                else if(z == 2)
                {
                    if (btnCol1Sel.Equals(gameStore()[btnCol2Sel].ToString()))
                    {
                        Col2BTN2.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN2.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }


            }
        }

        private void Col2BTN3_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            btnCol2Sel = Col2BTN3.Text.ToString();

            Col2BTN3.FlatStyle = FlatStyle.Flat;
            Col2BTN3.FlatAppearance.BorderColor = Color.RoyalBlue;
            Col2BTN3.FlatAppearance.BorderSize = 3;
            Col2BTN2.FlatStyle = FlatStyle.Standard;
            Col2BTN1.FlatStyle = FlatStyle.Standard;
            Col2BTN4.FlatStyle = FlatStyle.Standard;
            Col2BTN5.FlatStyle = FlatStyle.Standard;
            Col2BTN6.FlatStyle = FlatStyle.Standard;
            Col2BTN7.FlatStyle = FlatStyle.Standard;
            btnName2 = "Col2BTN3";
            clickCount++;

            if (!String.IsNullOrEmpty(btnCol1Sel) && !String.IsNullOrEmpty(btnCol2Sel))
            {
                Control btn = this.Controls.Find(btnName1, true)[0] as Control;
                if (z == 1)
                {
                    if (btnCol2Sel.Equals(gameStore()[btnCol1Sel].ToString()))
                    {
                        Col2BTN3.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN3.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
                else if (z == 2)
                {
                    if (btnCol1Sel.Equals(gameStore()[btnCol2Sel].ToString()))
                    {
                        Col2BTN3.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN3.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }


            }
        }

        private void Col2BTN4_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            btnCol2Sel = Col2BTN4.Text.ToString();

            Col2BTN4.FlatStyle = FlatStyle.Flat;
            Col2BTN4.FlatAppearance.BorderColor = Color.RoyalBlue;
            Col2BTN4.FlatAppearance.BorderSize = 3;
            Col2BTN2.FlatStyle = FlatStyle.Standard;
            Col2BTN3.FlatStyle = FlatStyle.Standard;
            Col2BTN1.FlatStyle = FlatStyle.Standard;
            Col2BTN5.FlatStyle = FlatStyle.Standard;
            Col2BTN6.FlatStyle = FlatStyle.Standard;
            Col2BTN7.FlatStyle = FlatStyle.Standard;
            btnName2 = "Col2BTN4";
            clickCount++;

            if (!String.IsNullOrEmpty(btnCol1Sel) && !String.IsNullOrEmpty(btnCol2Sel))
            {
                Control btn = this.Controls.Find(btnName1, true)[0] as Control;
                if (z == 1)
                {
                    if (btnCol2Sel.Equals(gameStore()[btnCol1Sel].ToString()))
                    {
                        Col2BTN4.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN4.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
                else if (z == 2)
                {
                    if (btnCol1Sel.Equals(gameStore()[btnCol2Sel].ToString()))
                    {
                        Col2BTN4.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN4.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }


            }
        }

        private void Col2BTN5_Click(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;

            btnCol2Sel = Col2BTN5.Text.ToString();

            Col2BTN5.FlatStyle = FlatStyle.Flat;
            Col2BTN5.FlatAppearance.BorderColor = Color.RoyalBlue;
            Col2BTN5.FlatAppearance.BorderSize = 3;
            Col2BTN2.FlatStyle = FlatStyle.Standard;
            Col2BTN3.FlatStyle = FlatStyle.Standard;
            Col2BTN4.FlatStyle = FlatStyle.Standard;
            Col2BTN1.FlatStyle = FlatStyle.Standard;
            Col2BTN6.FlatStyle = FlatStyle.Standard;
            Col2BTN7.FlatStyle = FlatStyle.Standard;
            btnName2 = "Col2BTN5";
            clickCount++;

            if (!String.IsNullOrEmpty(btnCol1Sel) && !String.IsNullOrEmpty(btnCol2Sel))
            {
                Control btn = this.Controls.Find(btnName1, true)[0] as Control;
                if (z == 1)
                {
                    if (btnCol2Sel.Equals(gameStore()[btnCol1Sel].ToString()))
                    {
                        Col2BTN5.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN5.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
                else if (z == 2)
                {
                    if (btnCol1Sel.Equals(gameStore()[btnCol2Sel].ToString()))
                    {
                        Col2BTN5.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN5.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }

                }


            }
        }

        private void Col2BTN6_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            btnCol2Sel = Col2BTN6.Text.ToString();

            Col2BTN6.FlatStyle = FlatStyle.Flat;
            Col2BTN6.FlatAppearance.BorderColor = Color.RoyalBlue;
            Col2BTN6.FlatAppearance.BorderSize = 3;
            Col2BTN2.FlatStyle = FlatStyle.Standard;
            Col2BTN3.FlatStyle = FlatStyle.Standard;
            Col2BTN4.FlatStyle = FlatStyle.Standard;
            Col2BTN5.FlatStyle = FlatStyle.Standard;
            Col2BTN1.FlatStyle = FlatStyle.Standard;
            Col2BTN7.FlatStyle = FlatStyle.Standard;
            btnName2 = "Col2BTN6";
            clickCount++;

            if (!String.IsNullOrEmpty(btnCol1Sel) && !String.IsNullOrEmpty(btnCol2Sel))
            {
                Control btn = this.Controls.Find(btnName1, true)[0] as Control;
                if (z == 1)
                {
                    if (btnCol2Sel.Equals(gameStore()[btnCol1Sel].ToString()))
                    {
                        Col2BTN6.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN6.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
                else if (z == 2)
                {
                    if (btnCol1Sel.Equals(gameStore()[btnCol2Sel].ToString()))
                    {
                        Col2BTN6.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN6.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }


            }
        }

        private void Col2BTN7_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            btnCol2Sel = Col2BTN7.Text.ToString();

            Col2BTN7.FlatStyle = FlatStyle.Flat;
            Col2BTN7.FlatAppearance.BorderColor = Color.RoyalBlue;
            Col2BTN7.FlatAppearance.BorderSize = 3;
            Col2BTN2.FlatStyle = FlatStyle.Standard;
            Col2BTN3.FlatStyle = FlatStyle.Standard;
            Col2BTN4.FlatStyle = FlatStyle.Standard;
            Col2BTN5.FlatStyle = FlatStyle.Standard;
            Col2BTN6.FlatStyle = FlatStyle.Standard;
            Col2BTN1.FlatStyle = FlatStyle.Standard;
            btnName2 = "Col2BTN7";
            clickCount++;

            if (!String.IsNullOrEmpty(btnCol1Sel) && !String.IsNullOrEmpty(btnCol2Sel))
            {
                Control btn = this.Controls.Find(btnName1, true)[0] as Control;
                if (z == 1)
                {
                    if (btnCol2Sel.Equals(gameStore()[btnCol1Sel].ToString()))
                    {
                        Col2BTN7.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN7.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }
                else if (z == 2)
                {
                    if (btnCol1Sel.Equals(gameStore()[btnCol2Sel].ToString()))
                    {
                        Col2BTN7.Enabled = false;
                        btn.Enabled = false;
                        Col2BTN7.BackColor = Color.GreenYellow;
                        btn.BackColor = Color.GreenYellow;
                        GamePRG.Value++;
                        if (GamePRG.Value == 4)
                        {
                            MessageBox.Show("Congratulations" + "\r\n" + "you won in " + clickCount + " clicks");
                            this.Close();
                            Hub giveUp = new Hub();
                            giveUp.Show();
                        }
                        return;
                    }
                }


            }
        }

        //this is the function that allows the user to exit the gamee when they want
        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GoodBye" + "\r\n" + "Please return soon!");
            this.Close();
            Hub giveUp = new Hub();
            giveUp.Show();
        }
    }
}
