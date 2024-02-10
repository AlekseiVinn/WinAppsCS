using System.Text;

namespace Eratosphen
{
    public partial class Form1 : Form
    {
        Thread EratosphenA;
        Thread EratosphenB;
        StringBuilder resA;
        StringBuilder resB;
        

        public Form1()
        {
            InitializeComponent();
        }

        public void GoButt(object obj)
        {
            dataGrid results = (dataGrid)obj;
            uint num = results.num;
            StringBuilder res = results.str;
            
            for (uint trial = 2; trial <= num; trial++)
            {
                bool isPrime = true;
                for (uint divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                {
                    if (trial % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    res.AppendFormat("{0} ", trial);
                }
            }
            //return res.ToString();
            
            Invoke(() => results.rt.Text = res.ToString());

        }


        private void btòA_Click(object sender, EventArgs e)
        {
            uint num = uint.Parse(MaxValueA.Text);
            resA = new StringBuilder();
            dataGrid dataGridA = new dataGrid(num, resA, richTextBoxA);

            //var result = await Task.Run(() => {
            //    return GoButt(dataGridA);
            //    });
            //richTextBoxA.Text = result.ToString();
            
            EratosphenA = new Thread(new ParameterizedThreadStart(GoButt));
            EratosphenA.Start(dataGridA);
        }

        private void btòB_Click(object sender, EventArgs e)
        {
            uint num = uint.Parse(MaxValueB.Text);
            resB = new StringBuilder();
            dataGrid dataGridB = new dataGrid(num, resB, richTextBoxB);

            EratosphenB = new Thread(new ParameterizedThreadStart(GoButt));
            EratosphenB.Start(dataGridB);
            
            //EratosphenB.Join();
            //richTextBoxB.Text = resB.ToString();
        }

        public class dataGrid
        {
            public uint num;
            public StringBuilder str;
            public RichTextBox rt;

            public dataGrid(uint num, StringBuilder str, RichTextBox rt)
            {
                this.num = num;
                this.str = str;
                this.rt = rt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.Text);
        }
    }
}
