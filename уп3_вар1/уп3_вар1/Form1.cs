using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace уп3_вар1
{
    public partial class Form1 : Form
    {
        private List<Eat> eat;
        public Form1()
        {
            InitializeComponent();
            eat=new List<Eat>();
        }
        private void AddEat(string name, double belok, double yglevods)
        {
            Eat prod=new Eat(name,belok,yglevods);
            eat.Add(prod);
        }

        private void AddKal(string name, double belok, double yglevods,double kkal)
        {
            Kallorii prod = new Kallorii(name, belok, yglevods,kkal);
            eat.Add(prod);
        }

        private void Refreshing()
        {
            listBox1.Items.Clear();
            foreach(var z in eat)
            {
                listBox1.Items.Add(z.Name);
            }
        }

        private void DelStr()
        {
            if(listBox1.SelectedIndex!=-1)
            {
                eat.RemoveAt(listBox1.SelectedIndex);
                Refreshing();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nazv = textBox1.Text;
                double belok = double.Parse(textBox2.Text);
                double yglevods = double.Parse(textBox3.Text);
                AddEat(nazv, belok, yglevods);
                Refresh();
            }
            catch
            {
                MessageBox.Show("неверные данные", "error");
            }
        }
    }
}
