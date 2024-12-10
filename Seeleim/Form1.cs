namespace Seeleim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("แฮนโล้", "โค้ดเร็ว,ข้อความ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("จะออกจริงๆๆ?", "เจ้าแน่ใจ๋", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-----------------------------คำนวณพื้นที่วงกลม- Return----------------
        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าที่ป้อนใน TextBox
            if (double.TryParse(txtRaduis.Text, out double radius))
            {
                // เรียกใช้ Method แบบ return เพื่อคำนวณพื้นที่วงกลม
                double area = CalculateCircleArea(radius);

                // แสดงผลลัพธ์ใน Label
                lblResult.Text = area.ToString("0.00");
            }
            else
            {
                MessageBox.Show("ไม่ถูกค้าบ", "ห้ะ");
                txtRaduis.Focus(); // ให้ cursor อยู่ใน TextBox
                txtRaduis.Select(); // ให้เลือกข้อความใน TextBox
            }
        }

        // Method แบบ return สำหรับคำนวณพื้นที่วงกลม
        private double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2); // คืนค่าพื้นที่วงกลม
        }
      //-------------------------------------------------------------------
        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            double Height = 0;
            double Width = 0;

            if (double.TryParse(txtHeight.Text, out Height) == false)
            {
                MessageBox.Show("ไม่ถูกค้าบ", "ห้ะ");
                txtRaduis.Focus(); //ให้มี cursor ที่ Textbox 
                txtRaduis.Select(); //ให้มี Selected ข้อความใน Textbox

                return;
            }

            if (double.TryParse(txtWidth.Text, out Width) == false)
            {
                MessageBox.Show("ขอเป็นตัวเลขครับพี้", "ห้ะ");
                txtRaduis.Focus();
                txtRaduis.Select();
                return;
            }
            double TriangleArea = 0.5 * Height * Width;
            lblResult.Text = TriangleArea.ToString("0.00");
        }

        //--------------------------นวณพื้นที่หกเหลี่ยม---Void---------------------
        private void Hahaha(double sideLength)
        {
            // คำนวณพื้นที่หกเหลี่ยม
            double hexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(sideLength, 2);

            // แสดงผลใน Label
            lblResult.Text = hexagonArea.ToString("0.00");
        }
        private void btn_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าที่ป้อนใน TextBox ว่าเป็นตัวเลขไหม
            if (double.TryParse(txtHexagonWidth.Text, out double hexagonSideLength))
            {
                // เรียกใช้ Method แบบ void สำหรับการคำนวณและแสดงผล
                Hahaha(hexagonSideLength);
            }
            else
            {
                MessageBox.Show("กรุณาป้อนตัวเลขที่ถูกต้อง", "ข้อผิดพลาด");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
            }
        }
     //------------------------------------------------------------------
    }
}
