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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            XP.Text = TotalXP.XP.ToString() + " XP";
        }
       
        //Allows user to go back to home screen 
        private void btnReplacingBooks_Click(object sender, EventArgs e)
        {
            ReplacingBooks replacingBooks = new ReplacingBooks();
            replacingBooks.FormClosed += new FormClosedEventHandler(replacingBooks_FormClosed);
            this.Hide();
            replacingBooks.Show();
        }

        private void replacingBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            XP.Text = TotalXP.XP.ToString() + " XP";
        }

        //Allows user to go back to home screen 
        private void btnIdentifyingAreas_Click(object sender, EventArgs e)
        {
            IdentifyingAreas identifyingAreas = new IdentifyingAreas();
            identifyingAreas.FormClosed += new FormClosedEventHandler(identifyingAreas_FormClosed);
            this.Hide();
            identifyingAreas.Show();
        }

        private void identifyingAreas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            XP.Text = TotalXP.XP.ToString() + " XP";
        }

        //Allows user to go back to home screen 
        private void btnFindingCallNumbers_Click(object sender, EventArgs e)
        {
            FindingCallNumbers findingCallNumbers = new FindingCallNumbers();
            findingCallNumbers.FormClosed += new FormClosedEventHandler(findingCallNumbers_FormClosed);
            this.Hide();
            findingCallNumbers.Show();
        }

        private void findingCallNumbers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            XP.Text = TotalXP.XP.ToString() + " XP";
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

public static class TotalXP
{
    public static int XP;
}