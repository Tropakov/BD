using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarpushinDZ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students Win = new Students();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progress Win = new progress();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lesson Win = new Lesson();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Proffession Win = new Proffession();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Faculty Win = new Faculty();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
