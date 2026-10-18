namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (txtHomework.Text == "") txtHomework.Text = "0";
            if (txtHomeworkWeight.Text == "") txtHomeworkWeight.Text = "0";
            if (txtLab.Text == "") txtLab.Text = "0";
            if (txtLabWeight.Text == "") txtLabWeight.Text = "0";
            if (txtMidterm.Text == "") txtMidterm.Text = "0";
            if (txtMidtermWeight.Text == "") txtMidtermWeight.Text = "0";
            if (txtFinal.Text == "") txtFinal.Text = "0";
            if (txtFinalWeight.Text == "") txtFinalWeight.Text = "0";

            double homeworkNotu = Convert.ToDouble(txtHomework.Text);
            double homeworkAgirligi = Convert.ToDouble(txtHomeworkWeight.Text);
            double labNotu = Convert.ToDouble(txtLab.Text);
            double labAgirligi = Convert.ToDouble(txtLabWeight.Text);
            double midtermNotu = Convert.ToDouble(txtMidterm.Text);
            double midtermAgirligi = Convert.ToDouble(txtMidtermWeight.Text);
            double finalNotu = Convert.ToDouble(txtFinal.Text);
            double finalAgirligi = Convert.ToDouble(txtFinalWeight.Text);
            double toplamAgirlik = homeworkAgirligi + labAgirligi + midtermAgirligi + finalAgirligi;

            if (toplamAgirlik != 100)
            {
                MessageBox.Show("Ders Ağırlıkları Toplamı 100 olmalıdır!");
                return;
            }

            double ortalama = (homeworkNotu * homeworkAgirligi / 100) +
                              (labNotu * labAgirligi / 100) +
                              (midtermNotu * midtermAgirligi / 100) +
                              (finalNotu * finalAgirligi / 100);

            lblAverage.Text = ortalama.ToString("0.00");

            if (ortalama >= 90)
            {
                lblLetterGrade.Text = "AA";
            }
            else if (ortalama >= 80)
            {
                lblLetterGrade.Text = "BA";
            }
            else if (ortalama >= 75)
            {
                lblLetterGrade.Text = "BB";
            }
            else if (ortalama >= 70)
            {
                lblLetterGrade.Text = "CB";
            }
            else if (ortalama >= 60)
            {
                lblLetterGrade.Text = "CC";
            }
            else if (ortalama >= 55)
            {
                lblLetterGrade.Text = "DC";
            }
            else if (ortalama >= 50)
            {
                lblLetterGrade.Text = "DD";
            }
            else if (ortalama >= 40)
            {
                lblLetterGrade.Text = "FD";
            }
            else
            {
                lblLetterGrade.Text = "FF";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLab.Clear();
            txtLabWeight.Clear();
            txtHomework.Clear();
            txtHomeworkWeight.Clear();
            txtMidterm.Clear();
            txtMidtermWeight.Clear();
            txtFinal.Clear();
            txtFinalWeight.Clear();

            lblAverage.Text = "0.00";
            lblLetterGrade.Text = "--";
        }
    }
}
