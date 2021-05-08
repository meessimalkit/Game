using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunGame
{
    public partial class Form1 : Form
    {
        Gungameclass mclass = new Gungameclass(); //class added here
        public Form1()
        {
            InitializeComponent();
        }
        int blt;
        int chance = 2;
        int num;
        int point;

      

        SoundPlayer load = new SoundPlayer();
        SoundPlayer fire = new SoundPlayer(@"media.wav"); // sound 

        string message;
        //arrey
        int[] chamber = { 0, 0, 0, 0, 0, 0, };
        int points;
        int num1, num2, add;
        private void LOADBTN_Click(object sender, EventArgs e)
        {
            blt = 1;  //blt

            chance = 2;  //chances

            txtBullet.Text = blt.ToString();
            txtChances.Text = chance.ToString();
            message = "Bullet is loaded";   // message box show when  blt is loaded 
            textBox.Text = Convert.ToString(message);
            load.Play();//  load gun sound play 
            SABTN.Enabled = false;
            SHOOTBTN.Enabled = false;
            SPINBTN.Enabled = true;
            LOADBTN.Enabled = false;
        }

        private void SPINBTN_Click(object sender, EventArgs e)
        {
            Random myfun = new Random();  // random num fuction
            int random = myfun.Next(1, 7);
            txtBullet.Text = random.ToString();
            message = "Chamber is running "; // message box show when blt place ina random place
            textBox.Text = Convert.ToString(message);
            load.Play(); // spinner sound play
            LOADBTN.Enabled = true;
            SPINBTN.Enabled = false;

            SHOOTBTN.Enabled = true;
            SABTN.Enabled = true;




            num = random;

        }
       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            num1 = Convert.ToInt32(Convert.ToString(textBox1.Text));
            num2 = Convert.ToInt32(Convert.ToString(textBox2.Text));    
            add = num1 - num2;
        }
       
        private void Exitbtn_Click(object sender, EventArgs e)
        {
           mclass.exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mclass.restart();
        }

        private void SHOOTBTN_Click(object sender, EventArgs e)
        {
            point += 10; //add 10 points each win

            points += 5;

            fire.Play();// fire  sound play
            num--;
            txtBullet.Text = num.ToString();
            message = "Firing "; //  messagebox show 
            textBox1.Text = point.ToString();
            textBox.Text = Convert.ToString(message);
            textBox3.Text = add.ToString();

            if (num == 0)
            {
                message = "You Loose";
                textBox.Text = Convert.ToString(message);


                SHOOTBTN.Enabled = false;
            }
            else
            {

            }

        }

        private void SABTN_Click(object sender, EventArgs e)
        {

            point += 10;

            points += 5;

            load.Play();// sound play
            chance--;  // chance minus on each click
            num--;
            txtBullet.Text = num.ToString();
            textBox3.Text = add.ToString();
            if (num == 1)


            {
                message = " Winner";
                textBox.Text = Convert.ToString(message);
                textBox1.Text = point.ToString();
                load.Play();
                SABTN.Enabled = false;
                SHOOTBTN.Enabled = false;
            }
            else if (chance == 0)
            {
                message = " Loose Game";
                SABTN.Enabled = false;
                textBox2.Text = points.ToString();
                load.Play();

            }

            textBox.Text = Convert.ToString(message);

            txtChances.Text = chance.ToString();
        }
    }
}
