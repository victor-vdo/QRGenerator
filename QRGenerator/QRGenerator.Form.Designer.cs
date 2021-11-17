
namespace QRGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbQR = new System.Windows.Forms.PictureBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.txbLink = new System.Windows.Forms.TextBox();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbQR
            // 
            this.pcbQR.Location = new System.Drawing.Point(10, 46);
            this.pcbQR.Margin = new System.Windows.Forms.Padding(1);
            this.pcbQR.Name = "pcbQR";
            this.pcbQR.Size = new System.Drawing.Size(200, 200);
            this.pcbQR.TabIndex = 0;
            this.pcbQR.TabStop = false;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLink.Location = new System.Drawing.Point(231, 51);
            this.lblLink.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(30, 15);
            this.lblLink.TabIndex = 1;
            this.lblLink.Text = "Link";
            // 
            // txbLink
            // 
            this.txbLink.Location = new System.Drawing.Point(231, 69);
            this.txbLink.Name = "txbLink";
            this.txbLink.Size = new System.Drawing.Size(309, 19);
            this.txbLink.TabIndex = 2;
            // 
            // txbHeight
            // 
            this.txbHeight.Location = new System.Drawing.Point(231, 135);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(140, 19);
            this.txbHeight.TabIndex = 3;
            this.txbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbHeight_KeyPress);
            // 
            // txbWidth
            // 
            this.txbWidth.Location = new System.Drawing.Point(400, 135);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(140, 19);
            this.txbWidth.TabIndex = 4;
            this.txbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbWidth_KeyPress);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(231, 202);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(309, 42);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate QR Code";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHeight.Location = new System.Drawing.Point(231, 114);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(45, 15);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWidth.Location = new System.Drawing.Point(400, 114);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 15);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Width";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 256);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txbWidth);
            this.Controls.Add(this.txbHeight);
            this.Controls.Add(this.txbLink);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.pcbQR);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pcbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbQR;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txbLink;
        private System.Windows.Forms.TextBox txbHeight;
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
    }
}

