using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual_task
{
    public partial class Form1 : Form
    {
        CEmblem eminem;
        int count = 0;

        Pen penYellow = new Pen(Color.Yellow, 3);
        Pen penClear = new Pen(Color.White, 3);
        public Form1()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CEmblem ob = new CEmblem(new Random().Next(0, 500), new Random().Next(0, 435), "Emblem #" + " " + count, 80);
            comboBox1.Items.Add(ob);
            count++;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;


                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);

                }
                else
                {
                    emblem.Draw(pic, penClear);

                }

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Draw(pic, penYellow);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);
                    emblem.ScalePlus();
                    emblem.Rotate(pic, penYellow);
                }
                else
                {
                    emblem.Draw(pic, penClear);
                    emblem.ScalePlus();
                    emblem.Draw(pic, penYellow);
                }


            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;


                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);
                    emblem.ScaleMinus();
                    emblem.Rotate(pic, penYellow);
                }
                else
                {
                    emblem.Draw(pic, penClear);
                    emblem.ScaleMinus();
                    emblem.Draw(pic, penYellow);
                }

            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);
                    emblem.MoveRightMax();
                    emblem.Rotate(pic, penYellow);
                }
                else
                {
                    emblem.Draw(pic, penClear);
                    emblem.MoveRightMax();
                    emblem.Draw(pic, penYellow);
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);
                    emblem.MoveRight();
                    emblem.Rotate(pic, penYellow);
                }
                else
                {
                    emblem.Draw(pic, penClear);
                    emblem.MoveRight();
                    emblem.Draw(pic, penYellow);
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);
                    emblem.MoveDown();
                    emblem.Rotate(pic, penYellow);
                }
                else
                {
                    emblem.Draw(pic, penClear);
                    emblem.MoveDown();
                    emblem.Draw(pic, penYellow);
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);
                    emblem.MoveUpMax();
                    emblem.Rotate(pic, penYellow);
                }
                else
                {
                    emblem.Draw(pic, penClear);
                    emblem.MoveUpMax();
                    emblem.Draw(pic, penYellow);
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);
                    emblem.Draw(pic, penYellow);
                }
                else
                {

                    emblem.Draw(pic, penClear);
                    emblem.Rotate(pic, penYellow);
                }



            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);
                    emblem.MoveLeftMax();
                    emblem.Rotate(pic, penYellow);
                }
                else
                {
                    emblem.Draw(pic, penClear);
                    emblem.MoveLeftMax();
                    emblem.Draw(pic, penYellow);
                }
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;


                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);
                    emblem.MoveUp();
                    emblem.Rotate(pic, penYellow);
                }
                else
                {
                    emblem.Draw(pic, penClear);
                    emblem.MoveUp();
                    emblem.Draw(pic, penYellow);
                }
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);
                    emblem.MoveDownMax();
                    emblem.Rotate(pic, penYellow);
                }
                else
                {
                    emblem.Draw(pic, penClear);
                    emblem.MoveDownMax();
                    emblem.Draw(pic, penYellow);
                }
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if (emblem.RE)
                {
                    emblem.Rotate(pic, penClear);
                    emblem.MoveLeft();
                    emblem.Rotate(pic, penYellow);
                }
                else
                {
                    emblem.Draw(pic, penClear);
                    emblem.MoveLeft();
                    emblem.Draw(pic, penYellow);
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
