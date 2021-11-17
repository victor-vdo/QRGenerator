using System;
using System.Drawing;
using System.Windows.Forms;

namespace QRGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txbWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txbLink.Text == string.Empty || txbHeight.Text == string.Empty || txbWidth.Text == string.Empty)
            {
                MessageBox.Show("Invalid informations. Complete the nulable fields to generate the QR Code");
                txbLink.Focus();
                return;
            }
            try
            {
                int width = Convert.ToInt32(txbWidth.Text);
                int height = Convert.ToInt32(txbHeight.Text);
                width = width > 200 ? 200 : width; // if width is heigher than 200px the width will be equal 200px
                height = height > 200 ? 200 : height; // if height is heigher than 200px the height will be equal 200px
                pcbQR.Image = GenerateQRCode(width, height, txbLink.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Bitmap GenerateQRCode(int width, int height, string text)
        {
            try
            {
                var bw = new ZXing.BarcodeWriter();
                var encOptions = new ZXing.Common.EncodingOptions() { Width = width, Height = height, Margin = 0 };
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;
                var result = new Bitmap(bw.Write(text));
                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
