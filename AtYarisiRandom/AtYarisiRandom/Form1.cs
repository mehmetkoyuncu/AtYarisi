using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisiRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        int firstHorseDistanceLeft, secondHorseDistanceLeft, thirdHorseDistanceLeft;
        Random r = new Random();
      
        
        int number = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            number++;
          
            lblTime.Text = number.ToString();
          
        }

    

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int firstHorseDistanceLeft = pbxHorse1.Width;
            int secondHorseDistenceLeft = pbxHorse2.Width;
            int thirdHorseDistanceLEft = pbxHorse3.Width;


            pbxHorse1.Left = pbxHorse1.Left + r.Next(0, 10);
            pbxHorse2.Left = pbxHorse2.Left + r.Next(0, 10);
            pbxHorse3.Left = pbxHorse3.Left + r.Next(0, 10);
         

            int finish = lblFiinish.Left;

            if(firstHorseDistanceLeft+ pbxHorse1.Left>=finish)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("Birinci At Yarışı Kazandı");
                lblLastFinishTime.Text = number.ToString();
                lblLastWinnerHorse.Text = "Birinci At";
                pbxHorse1.Left = 0;
                pbxHorse2.Left = 0;
                pbxHorse3.Left = 0;
                
                number = 0;
              
            }
            if (secondHorseDistenceLeft + pbxHorse2.Left >= finish)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("İkinci At Yarışı Kazandı");
                lblLastFinishTime.Text = number.ToString();
                lblLastWinnerHorse.Text = "İkinci At";
                pbxHorse1.Left = 0;
                pbxHorse2.Left = 0;
                pbxHorse3.Left = 0;
               
                number = 0;
            }
            if (thirdHorseDistanceLEft + pbxHorse3.Left >= finish)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("Üçüncü At Yarışı Kazandı");
                lblLastFinishTime.Text = number.ToString();
                lblLastWinnerHorse.Text = "Üçüncü At";
                pbxHorse1.Left = 0;
                pbxHorse2.Left = 0;
                pbxHorse3.Left = 0;
               
                number = 0;
            }

            if (pbxHorse1.Left > pbxHorse2.Left && pbxHorse1.Left > pbxHorse3.Left)
            {
                lblCanli.Text="Birinci at yarışı ilk sırada  sürdürüyor";
            }
            if (pbxHorse2.Left > pbxHorse1.Left && pbxHorse2.Left > pbxHorse3.Left)
            {
                lblCanli.Text = "İkinci at yarışı ilk sırada sürdürüyor";
            }
            if (pbxHorse3.Left > pbxHorse1.Left && pbxHorse3.Left > pbxHorse2.Left)
            {
                lblCanli.Text = "Üçüncü at yarışı ilk sırada sürdürüyor";
            }


           


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            firstHorseDistanceLeft = pbxHorse1.Left;
            secondHorseDistanceLeft = pbxHorse2.Left;
            thirdHorseDistanceLeft = pbxHorse3.Left;
        }
    }
}
