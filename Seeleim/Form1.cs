namespace Seeleim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //yes

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

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //input รับค่จาก Tex และแปลงเป็น double
            double Radius = 0;

            if (double.TryParse(txtRaduis.Text, out Radius) == false)
            {
                MessageBox.Show("ไม่ถูกค้าบ", "ห้ะ");
                txtRaduis.Focus(); //ให้มี cursor ที่ Textbox 
                txtRaduis.Select(); //ให้มี Selected ข้อความใน Textbox
                return;
            }
            // คำนวณหานสูตร วงกลม
            double CircleArea = Math.PI * Math.Pow(2, Radius);

            lblResult.Text = CircleArea.ToString("0.00");

            txtRaduis.Focus();
            txtRaduis.Select();
        }

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
                MessageBox.Show("ไม่ถูกค้าบ", "ห้ะ");
                txtRaduis.Focus();
                txtRaduis.Select();
                return;
            }
            double TriangleArea = 0.5 * Height * Width;
            lblResult.Text = TriangleArea.ToString("0.00");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            double hexagonSideLength = 0;

            // ตรวจสอบค่าที่ป้อน TextBox เป็นตัวเลข
            if (double.TryParse(txtHexagonWidth.Text, out hexagonSideLength) == false)
            {
                MessageBox.Show("กรุณาป้อนตัวเลขที่ถูกต้อง", "ข้อผิดพลาด");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }

            // คำนวณพื้นที่หกเหลี่ยม
            double hexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(hexagonSideLength, 2);

            
            lblResult.Text = hexagonArea.ToString("0.00");
        }
    }
}
