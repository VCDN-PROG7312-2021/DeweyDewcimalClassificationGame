using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDewcimalClassificationGame
{
    public partial class ReplacingBooks : Form
    {
        List<string> listValues;
        string[] sortArray;
        public ReplacingBooks()
        {
            InitializeComponent();

            //Allows drag and drop text
            listUsersAnswer.AllowDrop = true;
            listRightAnswer.Visible = false;
            listValues = new List<string>();

            XP.Text = TotalXP.XP.ToString() + " xp";

            populateTextBox();
        }
        
        //Triggers drag-drop event when user drops the call number textbox in the middle box
        /*--The following code was adapted from Rod Stephens on C# Helper website 
            Author: Rod Stephens
            Site:  http://csharphelper.com/blog/2019/09/let-the-user-drag-listbox-items-in-c/ */
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            listUsersAnswer.Items.Add(e.Data.GetData(DataFormats.Text));
        }
        
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();

            listUsersAnswer.DoDragDrop(textBox1.Text, DragDropEffects.All);
        }
        
        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.SelectAll();

            listUsersAnswer.DoDragDrop(textBox2.Text, DragDropEffects.All);
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.SelectAll();

            listUsersAnswer.DoDragDrop(textBox3.Text, DragDropEffects.All);
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox4.SelectAll();

            listUsersAnswer.DoDragDrop(textBox4.Text, DragDropEffects.All);
        }

        private void textBox5_MouseDown(object sender, MouseEventArgs e)
        {
            textBox5.SelectAll();

            listUsersAnswer.DoDragDrop(textBox5.Text, DragDropEffects.All);
        }

        private void textBox6_MouseDown(object sender, MouseEventArgs e)
        {
            textBox6.SelectAll();

            listUsersAnswer.DoDragDrop(textBox6.Text, DragDropEffects.All);
        }

        private void textBox7_MouseDown(object sender, MouseEventArgs e)
        {
            textBox7.SelectAll();

            listUsersAnswer.DoDragDrop(textBox7.Text, DragDropEffects.All);
        }

        private void textBox8_MouseDown(object sender, MouseEventArgs e)
        {
            textBox8.SelectAll();

            listUsersAnswer.DoDragDrop(textBox8.Text, DragDropEffects.All);
        }

        private void textBox9_MouseDown(object sender, MouseEventArgs e)
        {
            textBox9.SelectAll();

            listUsersAnswer.DoDragDrop(textBox9.Text, DragDropEffects.All);
        }

        private void textBox10_MouseDown(object sender, MouseEventArgs e)
        {
            textBox10.SelectAll();

            listUsersAnswer.DoDragDrop(textBox10.Text, DragDropEffects.All);
        }
        
        /*----------------------------END----------------------------*/
        
        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            listRightAnswer.Items.Clear();
            SortNumbers();
            CheckAnswer();
            labelRight.Visible = true;
            listRightAnswer.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTheGame();

            populateTextBox();
        }

        private void ResetTheGame()
        {
            listUsersAnswer.Items.Clear();
            listRightAnswer.Items.Clear();
            listValues.Clear();
            sortArray = null;
            resultText.Text = "";
        }

        private void populateTextBox()
        {          
            GenerateCallNumbers();
        
            int n = 1;
            
            foreach (var item in listValues)
            {
                //runs through textboxes and populates with call numbers
                if (n <= listValues.Count)
                {
                    TextBox txtb = panel1.Controls.Find("textBox" + n, false).FirstOrDefault() as TextBox;
                    txtb.Text = item.ToString();
                    n++;
                }
            }
        }

        //generates 10 doubles and 10 three letter strings and concatenates them
        private void GenerateCallNumbers()
        {
            Random random = new Random();
            string[] number = new string[10];

            for (int i = 0; i < 10; i++)
            {
                number[i] = random.Next(0, 9999) + "." + random.Next(0, 999);
            }

            string[] authSurnames = new string[10];

            for (int p = 0; p < 10; p++)
            {
                string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                char[] chars = new char[3];
                for (int i = 0; i < 3; i++)
                {
                    chars[i] = letters[random.Next(letters.Length)];
                }
                authSurnames[p] = new string(chars);
            }

            for (int s = 0; s < 10; s++)
            {
                listValues.Add(number[s] + " " + authSurnames[s]);
            }
        }

        public void SortNumbers()
        {
            //Bubble sorts numbers and rearranges into a list
            sortArray = listValues.ToArray();
            string temp;
            
            for (int j = 0; j <= sortArray.Length - 2; j++)
            {
                for (int i = 0; i <= sortArray.Length - 2; i++)
                {
                    double value1 = Convert.ToDouble(sortArray[i].Split(' ').First());
                    double value2 = Convert.ToDouble(sortArray[i + 1].Split(' ').First());

                    if (!(value1 > value2)) continue;
                    temp = sortArray[i + 1];
                    sortArray[i + 1] = sortArray[i];
                    sortArray[i] = temp;
                }
            }
            
            foreach (var item in sortArray)
            {
                listRightAnswer.Items.Add(item);
            }
        }

        public void CheckAnswer()
        {
            //compares the list and checks if it in correct order
            var correct = true;
            for(var a = 0; a < 10; a++)
            {
                if(listUsersAnswer.FindString(sortArray[a]).Equals(a))
                {
                    continue;
                }
                else
                {
                    correct = false;
                }
            }
            //Gamification feature
            if(correct == false)
            {
                resultText.Text = "Sorting incorrect.";
            }
            else
            {
                resultText.Text = "Sorting is correct. you've earned 50xp!";
                TotalXP.XP += 50;
                XP.Text = TotalXP.XP.ToString() + " xp";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ReplacingBooks_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}