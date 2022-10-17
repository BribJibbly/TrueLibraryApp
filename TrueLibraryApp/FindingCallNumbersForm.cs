using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrueLibraryApp.Tree_items;

namespace TrueLibraryApp
{
    public partial class FindingCallNumbersForm : Form
    {
        //lists and names used within the application
        string compName;
        int lvlTrack = 0;
        int point = 0;
        private int _time = 0;
        List<string> randomListLvl1 = new List<string>();
        List<string> randomListLvl2 = new List<string>();
        List<string> randomListLvl3 = new List<string>();
        List<int> numList = new List<int>();
        List<string> descList = new List<string>();
        List<string> btnList = new List<string>();
        string line;

        public FindingCallNumbersForm()
        {
            InitializeComponent();
        }

        //this makes it so that when the application is loaded it stats level one and the timer
        private void FindingCallNumbersForm_Load(object sender, EventArgs e)
        {
            lvlOne();
            timer1.Start();
        }
        //this method is the method that has evrything for level one
        private void lvlOne()
        {
            var ranNum = new Random();
            //this gets the file path for the text file with all the data for the game
            string filePath = System.IO.Path.GetFullPath("Dewey.txt");
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            //this while loop loops through every item in the text file and adds
            //them to three lists based on the level they are for
            while ((line = file.ReadLine()) != null)
            {
                if (randomListLvl1.Count < 10)
                {
                    randomListLvl1.Add(line);
                }
                else if (randomListLvl1.Count == 10 && randomListLvl2.Count < 30)
                {
                    randomListLvl2.Add(line);
                }
                else
                {
                    randomListLvl3.Add(line);
                }
            }
            file.Close();

            //this seperates the call numbers from the descriptions so that it can display only the 
            //description and then the numbers are used to compare with the answer to see if it is in the answer chosens range
            foreach (var item in randomListLvl2)
            {
                string name = item;

                int length = name.Length - 4;

                int num = Int32.Parse(name.Remove(4, length));

                string desc = name.Remove(0, 4);

                numList.Add(num);

                descList.Add(desc);
            }
            var randomized = randomListLvl1.OrderBy(item => ranNum.Next());

            int pos = ranNum.Next(0, 30);

            //this gives us the answers for the question and puts it in a list with 3 random answers to make sure
            //that there is always a right answer. we can also use this to compare if the answer selected is correct
            quesLbl.Text = descList.ElementAt(pos);
            if (numList.ElementAt(pos) >= 0 && numList.ElementAt(pos) < 100)
            {
                compName = "000 Computer science, information & general works ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 100 && numList.ElementAt(pos) < 200)
            {
                compName = "100 Philosophy & psychology ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 200 && numList.ElementAt(pos) < 300)
            {
                compName = "200 Religion ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 300 && numList.ElementAt(pos) < 400)
            {
                compName = "300 Social sciences";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 400 && numList.ElementAt(pos) < 500)
            {
                compName = "400 Language ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 500 && numList.ElementAt(pos) < 600)
            {
                compName = "500 Science ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 600 && numList.ElementAt(pos) < 700)
            {
                compName = "600 Technology";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 700 && numList.ElementAt(pos) < 800)
            {
                compName = "700 Arts & recreation ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 800 && numList.ElementAt(pos) < 900)
            {
                compName = "800 Literature ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 900 && numList.ElementAt(pos) < 1000)
            {
                compName = "900 History & geography";
                btnList.Add(compName);
            }
            while (btnList.Count < 4)
            {
                string hold = randomized.ElementAt(0);
                if (!btnList.Contains(hold))
                {
                    btnList.Add(hold);
                }
            }
            //this sorts the possible answers from lowest to highest and then puts them in the buttons
            btnList.Sort();
            ansBtn1.Text = btnList.ElementAt(0);
            ansBtn2.Text = btnList.ElementAt(1);
            ansBtn3.Text = btnList.ElementAt(2);
            ansBtn4.Text = btnList.ElementAt(3);
        }
        //this is the method that has all the functions for level two
        //NOTE: the functions are the same as level one except what the questions could be
        private void lvlTwo()
        {
            var ranNum = new Random();
            System.IO.StreamReader file = new System.IO.StreamReader(@"D:\Bryces Work\New folder\PROG7312 FINAL POE 18002305\18002305_PROG7312-Final-master\18002305_PROG7312-Final-master\TrueLibraryApp\bin\Debug\net5.0-windows\Dewey.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (randomListLvl1.Count < 10)
                {
                    randomListLvl1.Add(line);
                }
                else if (randomListLvl1.Count == 10 && randomListLvl2.Count < 30)
                {
                    randomListLvl2.Add(line);
                }
                else
                {
                    randomListLvl3.Add(line);
                }
            }
            file.Close();


            foreach (var item in randomListLvl3)
            {
                string name = item;

                int length = name.Length - 4;

                int num = Int32.Parse(name.Remove(4, length));

                string desc = name.Remove(0, 4);

                numList.Add(num);

                descList.Add(desc);
            }
            var randomized = randomListLvl1.OrderBy(item => ranNum.Next());

            int pos = ranNum.Next(0, 30);

            quesLbl.Text = descList.ElementAt(pos);
            if (numList.ElementAt(pos) >= 0 && numList.ElementAt(pos) < 100)
            {
                compName = "000 Computer science, information & general works ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 100 && numList.ElementAt(pos) < 200)
            {
                compName = "100 Philosophy & psychology ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 200 && numList.ElementAt(pos) < 300)
            {
                compName = "200 Religion ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 300 && numList.ElementAt(pos) < 400)
            {
                compName = "300 Social sciences";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 400 && numList.ElementAt(pos) < 500)
            {
                compName = "400 Language ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 500 && numList.ElementAt(pos) < 600)
            {
                compName = "500 Science ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 600 && numList.ElementAt(pos) < 700)
            {
                compName = "600 Technology";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 700 && numList.ElementAt(pos) < 800)
            {
                compName = "700 Arts & recreation ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 800 && numList.ElementAt(pos) < 900)
            {
                compName = "800 Literature ";
                btnList.Add(compName);
            }
            else if (numList.ElementAt(pos) >= 900 && numList.ElementAt(pos) < 1000)
            {
                compName = "900 History & geography";
                btnList.Add(compName);
            }
            while (btnList.Count < 4)
            {
                string hold = randomized.ElementAt(0);
                if (!btnList.Contains(hold))
                {
                    btnList.Add(hold);
                }
            }
            btnList.Sort();
            ansBtn1.Text = btnList.ElementAt(0);
            ansBtn2.Text = btnList.ElementAt(1);
            ansBtn3.Text = btnList.ElementAt(2);
            ansBtn4.Text = btnList.ElementAt(3);
        }

        //these methods are for what the buttons do when they are clicked
        private async void ansBtn1_Click(object sender, EventArgs e)
        {
            //this is the if statement that checks if the answer chosen is right or wrong and what the system
            //must do dependent on this
            if (ansBtn1.Text.Equals(compName))
            {
                //this adds to the level tracker letting the system know what  level the player is on
                lvlTrack++;
                //this disables the buttons to prevent spam clicking
                ansBtn1.Enabled = false;
                ansBtn2.Enabled = false;
                ansBtn3.Enabled = false;
                ansBtn4.Enabled = false;
                //this makes the button turn green to show that it is correct
                ansBtn1.BackColor = Color.GreenYellow;
                //this delays the application so that people can have enough time to see if they are correct or not
                await Task.Delay(1000);
                //this re-enables buttons for use
                ansBtn1.Enabled = true;
                ansBtn2.Enabled = true;
                ansBtn3.Enabled = true;
                ansBtn4.Enabled = true;
                //this changes the button back to normal color
                ansBtn1.BackColor = Color.White;
                //and then the lists are cleared for the next game
                randomListLvl1.Clear();
                randomListLvl2.Clear();
                randomListLvl3.Clear();
                numList.Clear();
                descList.Clear();
                btnList.Clear();
                //this if either puts you up to level 2 or, if you are already level 2, it will end the game and tell you your score
                if(lvlTrack == 1)
                {
                    lvlTwo();
                    lvlLbl.Text = "Current level: 2";
                    point++;
                }
                else
                {
                    point++;
                    timer1.Stop();
                    MessageBox.Show("You did it you smart cookie" + "\r\n" + "Clicks used: " + point + "\r\n" + "Time Taken: " + _time + " Seconds");
                    this.Close();
                    Hub giveUp = new Hub();
                    giveUp.Show();
                }
            }
            //this is for if the answer is incorrect
            else
            {
                ansBtn1.Enabled = false;
                ansBtn2.Enabled = false;
                ansBtn3.Enabled = false;
                ansBtn4.Enabled = false;
                //this makes the button turn red to show that it is incorrect
                ansBtn1.BackColor = Color.Red;

                await Task.Delay(1000);

                ansBtn1.Enabled = true;
                ansBtn2.Enabled = true;
                ansBtn3.Enabled = true;
                ansBtn4.Enabled = true;

                ansBtn1.BackColor = Color.White;
                randomListLvl1.Clear();
                randomListLvl2.Clear();
                randomListLvl3.Clear();
                numList.Clear();
                descList.Clear();
                btnList.Clear();
                // this makes it so that if you are on level one it will reload new lvel one questions 
                //and if you are on level 2 you will get new level 2 questions
                if (lvlTrack == 0)
                {
                    point++;
                    lvlOne();
                }
                else
                {
                    point++;
                    lvlTwo();
                }
            }
        }

        private async void ansBtn2_Click(object sender, EventArgs e)
        {
            if (ansBtn2.Text.Equals(compName))
            {
                lvlTrack++;
                ansBtn1.Enabled = false;
                ansBtn2.Enabled = false;
                ansBtn3.Enabled = false;
                ansBtn4.Enabled = false;

                ansBtn2.BackColor = Color.GreenYellow;

                await Task.Delay(1000);

                ansBtn1.Enabled = true;
                ansBtn2.Enabled = true;
                ansBtn3.Enabled = true;
                ansBtn4.Enabled = true;

                ansBtn2.BackColor = Color.White;
                randomListLvl1.Clear();
                randomListLvl2.Clear();
                randomListLvl3.Clear();
                numList.Clear();
                descList.Clear();
                btnList.Clear();
                if (lvlTrack == 1)
                {
                    lvlTwo();
                    lvlLbl.Text = "Current level: 2";
                    point++;
                }
                else
                {
                    point++;
                    timer1.Stop();
                    MessageBox.Show("You did it you smart cookie" + "\r\n" + "Clicks used: " + point + "\r\n" + "Time Taken: " + _time + " Seconds");
                    this.Close();
                    Hub giveUp = new Hub();
                    giveUp.Show();
                }
            }
            else
            {
                ansBtn1.Enabled = false;
                ansBtn2.Enabled = false;
                ansBtn3.Enabled = false;
                ansBtn4.Enabled = false;

                ansBtn2.BackColor = Color.Red;

                await Task.Delay(1000);

                ansBtn1.Enabled = true;
                ansBtn2.Enabled = true;
                ansBtn3.Enabled = true;
                ansBtn4.Enabled = true;

                ansBtn2.BackColor = Color.White;
                randomListLvl1.Clear();
                randomListLvl2.Clear();
                randomListLvl3.Clear();
                numList.Clear();
                descList.Clear();
                btnList.Clear();
                if (lvlTrack == 0)
                {
                    point++;
                    lvlOne();
                }
                else
                {
                    point++;
                    lvlTwo();
                }
            }
        }

        private async void ansBtn3_Click(object sender, EventArgs e)
        {
            if (ansBtn3.Text.Equals(compName))
            {
                lvlTrack++;
                ansBtn1.Enabled = false;
                ansBtn2.Enabled = false;
                ansBtn3.Enabled = false;
                ansBtn4.Enabled = false;

                ansBtn3.BackColor = Color.GreenYellow;

                await Task.Delay(1000);

                ansBtn1.Enabled = true;
                ansBtn2.Enabled = true;
                ansBtn3.Enabled = true;
                ansBtn4.Enabled = true;

                ansBtn3.BackColor = Color.White;
                randomListLvl1.Clear();
                randomListLvl2.Clear();
                randomListLvl3.Clear();
                numList.Clear();
                descList.Clear();
                btnList.Clear();
                if (lvlTrack == 1)
                {
                    lvlTwo();
                    lvlLbl.Text = "Current level: 2";
                    point++;
                }
                else
                {
                    point++;
                    timer1.Stop();
                    MessageBox.Show("You did it you smart cookie" + "\r\n" + "Clicks used: " + point + "\r\n" + "Time Taken: " + _time + " Seconds");
                    this.Close();
                    Hub giveUp = new Hub();
                    giveUp.Show();
                }
            }
            else
            {
                ansBtn1.Enabled = false;
                ansBtn2.Enabled = false;
                ansBtn3.Enabled = false;
                ansBtn4.Enabled = false;

                ansBtn3.BackColor = Color.Red;

                await Task.Delay(1000);

                ansBtn1.Enabled = true;
                ansBtn2.Enabled = true;
                ansBtn3.Enabled = true;
                ansBtn4.Enabled = true;

                ansBtn3.BackColor = Color.White;
                randomListLvl1.Clear();
                randomListLvl2.Clear();
                randomListLvl3.Clear();
                numList.Clear();
                descList.Clear();
                btnList.Clear();
                if (lvlTrack == 0)
                {
                    point++;
                    lvlOne();
                }
                else
                {
                    point++;
                    lvlTwo();
                }
            }
        }

        private async void ansBtn4_Click(object sender, EventArgs e)
        {
            if (ansBtn4.Text.Equals(compName))
            {
                lvlTrack++;
                ansBtn1.Enabled = false;
                ansBtn2.Enabled = false;
                ansBtn3.Enabled = false;
                ansBtn4.Enabled = false;

                ansBtn4.BackColor = Color.GreenYellow;

                await Task.Delay(1000);

                ansBtn1.Enabled = true;
                ansBtn2.Enabled = true;
                ansBtn3.Enabled = true;
                ansBtn4.Enabled = true;

                ansBtn4.BackColor = Color.White;
                randomListLvl1.Clear();
                randomListLvl2.Clear();
                randomListLvl3.Clear();
                numList.Clear();
                descList.Clear();
                btnList.Clear();
                if (lvlTrack == 1)
                {
                    lvlTwo();
                    lvlLbl.Text = "Current level: 2";
                    point++;
                }
                else
                {
                    point++;
                    timer1.Stop();
                    MessageBox.Show("You did it you smart cookie" + "\r\n" + "Clicks used: " + point + "\r\n" + "Time Taken: " + _time + " Seconds");
                    this.Close();
                    Hub giveUp = new Hub();
                    giveUp.Show();
                }
            }
            else
            {
                ansBtn1.Enabled = false;
                ansBtn2.Enabled = false;
                ansBtn3.Enabled = false;
                ansBtn4.Enabled = false;

                ansBtn4.BackColor = Color.Red;

                await Task.Delay(1000);

                ansBtn1.Enabled = true;
                ansBtn2.Enabled = true;
                ansBtn3.Enabled = true;
                ansBtn4.Enabled = true;

                ansBtn4.BackColor = Color.White;
                randomListLvl1.Clear();
                randomListLvl2.Clear();
                randomListLvl3.Clear();
                numList.Clear();
                descList.Clear();
                btnList.Clear();
                if (lvlTrack == 0)
                {
                    point++;
                    lvlOne();
                }
                else
                {
                    point++;
                    lvlTwo();
                }
            }
        }
        //this will exit the game and send you bac to the hub
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Hub giveUp = new Hub();
            giveUp.Show();
        }
        //this method displays the timer on the application
        private void timer1_Tick(object sender, EventArgs e)
        {
            _time++;
            time.Text = _time.ToString();
        }
    }
}
