using System.ComponentModel;

namespace Joe_s_Automotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double OilLubeCharges()
        {
            double charges = 0;
            if (oilChange.Checked)
            {
                charges += 26;
            }
            if (lubeJob.Checked)
            {
                charges += 18;
            }
            return charges;
        }

        private double FlushesCharges()
        {
            double charges = 0;
            if (radiatorFlush.Checked)
            {
                charges += 30;
            }
            if (transmissionBox.Checked)
            {
                charges += 80;
            }
            return charges;
        }

        private double MiscCharges()
        {
            double charges = 0;
            if (inspectionBox.Checked)
            {
                charges += 15;
            }
            if (mufflerBox.Checked)
            {
                charges += 100;
            }
            if (tireBox.Checked)
            {
                charges += 20;
            }
            return charges;
        }

        private double OtherCharges()
        {
            double charges = 0;
            double partCost = double.Parse(partBox.Text);
            double laborCost = double.Parse(laborBox.Text) * 20;
            charges += partCost + laborCost;
            return charges;
        }

        private double TaxCharges()
        {
            const double taxRate = 0.06;
            double baseAmount = double.Parse(partBox.Text);
            double tax = baseAmount * taxRate;
            return tax;
        }

        private double TotalCharges()
        {
            double totalCharge = 0;
            totalCharge += OilLubeCharges() + FlushesCharges() + MiscCharges() + OtherCharges() + TaxCharges();
            return totalCharge;
        }

        private void ClearOilLube()
        {
            oilChange.Checked = false;
            lubeJob.Checked = false;
        }
        private void ClearFlushes()
        {
            radiatorFlush.Checked = false;
            transmissionBox.Checked = false;
        }
        private void ClearMisc()
        {
            inspectionBox.Checked = false;
            mufflerBox.Checked = false;
            tireBox.Checked = false;
        }
        private void ClearOther()
        {
            partBox.Text = string.Empty;
            laborBox.Text = string.Empty;
        }
        private void ClearFees()
        {
            serviceFeeBox.Text = string.Empty;
            partFeeBox.Text = string.Empty;
            taxBox.Text = string.Empty;
            totalFeeBox.Text = string.Empty;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            double totalCharges = TotalCharges();
            serviceFeeBox.Text = (OilLubeCharges() + MiscCharges() + FlushesCharges() + int.Parse(laborBox.Text)*20).ToString();
            partFeeBox.Text = partBox.Text;
            taxBox.Text = TaxCharges().ToString();
            totalFeeBox.Text = totalCharges.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFlushes();
            ClearMisc();
            ClearOilLube();
            ClearOther();
            ClearFees();
        }
    }
}