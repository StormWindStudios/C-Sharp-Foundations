using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public delegate void Del(string message);

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            MessageBox.Show(message);
        }

        delegate void NumberChanger(int n);
       
        NumberChanger nc = delegate (int x) {
            MessageBox.Show($"Anonymous Method {x}");
        };

        public Form1()
        {
            InitializeComponent();
            this.Click += (s, e) =>
            {
                MessageBox.Show(((MouseEventArgs)e).Location.ToString());
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instantiate the delegate.
            Del handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nc(10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Double i = r.NextDouble();

            switch (i)
            {
                case double n when (n >= 0.00 && n <= 0.2):
                    MessageBox.Show(".2");
                    break;
                case double n when (n >= 0.2 && n <= 0.5):
                    MessageBox.Show(".5");
                    break;
                case double n when (n >= 0.5 && n <= 1):
                    MessageBox.Show("1");
                    break;
                default:
                    MessageBox.Show("unknown");
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Person per = new Person();
            MessageBox.Show(per.FullName);
        }
    }
    public class Test
    {
        public int Index = 0;
    }

}