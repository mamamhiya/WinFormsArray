namespace WinFormsArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            int[] number = new int[data.Length];
            int max = 0, min = 0;
            for (int i = 0; i < data.Length; i++)
            {

                if (int.TryParse(data[i], out int num))
                {
                    number[i] = num;

                }
                else
                {
                    num = 0;
                }

            }
            min = number[0];
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
                if (max < number[i])
                {
                    max = number[i];

                }
                
                if (min > number[i])
                {
                    min = number[i];
                }
            }



            double average = (double)sum / number.Length;
            lblnum.Text = $"จำนวนสามาชิกข้อมูล : {number.Length}";
            lblsum.Text = $"ผลรวม : {sum}";
            lblavg.Text = $"ค่าเฉลี่ย : {average}";
            lblmax.Text = $"ค่าสูงสุด : {max}";
            lblmin.Text = $"ค่าต่ำสุด : {min}";


        }

        private void btnArray2d_Click(object sender, EventArgs e)
        {
            string[,] data = new string[5, 3]
            {
                {"ธันวา","ท้อบ","หนองคาย"},
                {"ณัฐภูมิ","น้อต","หนองคาย"},
                {"วัชชิระ","สเน็ค","อุดรธานี"},
                {"ภูริณัฐ","ทินนี่","อุดรธานี"},
                {"อินทิรา","เอ็มมี่", "อุดรธานี"}
            };
            int row = data.GetLength(0);
            int col = data.GetLength(1);
            string result = "";
            for (int i = 0;i< row; i++)
            {
                result += "ข้อมูลที่ " + (i + 1) + " :";
                result += "ชื่อจริง " + data[i , 0] + " :";
                result += "ชื่อเล่น " + data[i ,1] + " :";
                result += "จังหวัด " + data[i , 2] + Environment.NewLine;

            }
            tbxArray2d.Text = $"{result}";
        }
    }
}