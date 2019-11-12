namespace ConsoleApplication1.Feedback
{
    using System;
    public class Feedback
    {
        public Feedback()
        {
            text = "You have ordered: \n";
        }
        public string text;
        public static int Main(string[] args)
        {
            Feedback test = new Feedback();
            
            System.Text.StringBuilder SB = new System.Text.StringBuilder(test.text);

            for (int i = 0; i < 50000; i++)
            {
                SB.Append("blue_toothbrush");
            }

            System.Console.Out.WriteLine("done");
            return 0;
        }
    }
}