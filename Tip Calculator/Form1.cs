using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Minus_btn_Click(object sender, EventArgs e)
        {
            float tip = float.Parse(Tip_text.Text);
            float bill = float.Parse(Bill_text.Text);
            float people = float.Parse(People_text.Text);

            if (tip > 0)
            {
                tip -= 1;
            }


            float tip_per_person = ((bill * tip) / (float)100) / people;
            float total_per_person = (bill / people) + tip_per_person;

            Tip_text.Text = tip.ToString();
            Tipperperson.Text = tip_per_person.ToString();
            Totalperperson.Text = total_per_person.ToString();
        }

        private void Plus_btn_Click(object sender, EventArgs e)
        {
            float tip = float.Parse(Tip_text.Text);
            float bill = float.Parse(Bill_text.Text);
            float people = float.Parse(People_text.Text);

            if (tip < 100)
            {
                tip += 1;
            }


            float tip_per_person = ((bill * tip) / (float)100) / people;
            float total_per_person = (bill / people) + tip_per_person;

            Tip_text.Text = tip.ToString();
            Tipperperson.Text = tip_per_person.ToString();
            Totalperperson.Text = total_per_person.ToString();
        }

        private void Pplminus_btn_Click(object sender, EventArgs e)
        {
            float tip = float.Parse(Tip_text.Text);
            float bill = float.Parse(Bill_text.Text);
            float people = float.Parse(People_text.Text);

            if (people > 0)
            {
                people -= 1;
            }


            float tip_per_person = ((bill * tip) / (float)100) / people;
            float total_per_person = (bill / people) + tip_per_person;

            People_text.Text = people.ToString();
            Tipperperson.Text = tip_per_person.ToString();
            Totalperperson.Text = total_per_person.ToString();
        }

        private void pplplus_btn_Click(object sender, EventArgs e)
        {
            float tip = float.Parse(Tip_text.Text);
            float bill = float.Parse(Bill_text.Text);
            float people = float.Parse(People_text.Text);

            if (people < 100)
            {
                people += 1;
            }


            float tip_per_person = ((bill * tip) / (float)100) / people;
            float total_per_person = (bill / people) + tip_per_person;

            People_text.Text = people.ToString();
            Tipperperson.Text = tip_per_person.ToString();
            Totalperperson.Text = total_per_person.ToString();
        }

        private void Bill_text_TextChanged(object sender, EventArgs e)
        {
            if (Bill_text.Text == "" || Bill_text.Text == ".")
            {
                Bill_text.Text = ".00";
            }

            float tip = float.Parse(Tip_text.Text);
            float bill = float.Parse(Bill_text.Text);
            float people = float.Parse(People_text.Text);


            float tip_per_person = ((bill * tip) / (float)100) / people;
            float total_per_person = (bill / people) + tip_per_person;


            Tipperperson.Text = tip_per_person.ToString();
            Totalperperson.Text = total_per_person.ToString();
        }

        private void Tip_text_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
