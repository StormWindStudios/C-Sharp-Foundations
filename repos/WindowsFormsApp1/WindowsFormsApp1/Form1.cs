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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(textBox1.Text);
                int j = int.Parse(textBox2.Text);

                int x = i / j;

                MessageBox.Show(x.ToString());
            }
            catch (FormatException exFormat)
            {
                MessageBox.Show("Format: " + exFormat.ToString());
            }
            catch (DivideByZeroException exZero)
            {
                MessageBox.Show("Divide by zero: " + exZero.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("General: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 10;
            int total = 0;

            switch (i)
            {
                case 0:
                    total += 25;
                    break;
                case 10:
                    total += 50;
                    goto case 0;
                case 20:
                    total += 100;
                    goto case 0;
                default:
                    MessageBox.Show("Other");
                    break;
            }

            MessageBox.Show(total.ToString());
        }

        private int Test() {

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine(i.ToString());

                if (i == 15) {
                    return i;
                }
            }

            return 0;
        }
    }

    [Serializable()]
    public class TestException : System.Exception
    {
        public TestException() : base() { }
        public TestException(string message) : base(message) { }
        public TestException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected TestException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
