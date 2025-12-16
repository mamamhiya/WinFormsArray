namespace WinFormsArray
{
    public partial class FrmArrey : Form
    {
        public FrmArrey()
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
            for (int i = 0; i < row; i++)
            {
                result += "ข้อมูลที่ " + (i + 1) + " :";
                result += "ชื่อจริง " + data[i, 0] + " :";
                result += "ชื่อเล่น " + data[i, 1] + " :";
                result += "จังหวัด " + data[i, 2] + Environment.NewLine;

            }
            tbxArray2d.Text = $"{result}";
        }

        int[][] myArray = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,12}
            };
        private void btnJagged_Click(object sender, EventArgs e)
        {
            

            int totalA = myArray[0].Sum();
            int totalB = myArray[1].Sum();
            int totalC = myArray[2].Sum();
            MessageBox.Show($"ผลรวมของแถวที่ 1 มี {totalA} \nผลรวมของแถวที่ 2 มี {totalB} \nผลรวมของแถวที่ 3 มี {totalC} ");
        }

        private void ok_MouseHover(object sender, EventArgs e)
        {

        }

        private void ok_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btm_DisArrey_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ในarreyนี้แถวที่ 1 มีสามาชิก {myArray[0].Length} ประกอบไปด้วย {string.Join(",", myArray[0])}" +
                $"\nในarreyนี้แถวที่ 2 มีสามาชิก {myArray[1].Length} ประกอบไปด้วย {string.Join(",", myArray[1])}" +
                $"\nในarreyนี้แถวที่ 3 มีสามาชิก {myArray[2].Length} ประกอบไปด้วย {string.Join(",", myArray[2])}");
        }
    }
}