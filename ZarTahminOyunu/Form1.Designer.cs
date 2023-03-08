namespace ZarTahminOyunu
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
            this.components = new System.ComponentModel.Container();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.cmbSayilar = new System.Windows.Forms.ComboBox();
            this.btnDondur = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Enabled = false;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.Color.Red;
            this.btn1.Location = new System.Drawing.Point(12, 69);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(113, 109);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Enabled = false;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.Color.Red;
            this.btn2.Location = new System.Drawing.Point(131, 69);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(113, 109);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // lstSonuc
            // 
            this.lstSonuc.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 25;
            this.lstSonuc.Location = new System.Drawing.Point(250, 12);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(197, 404);
            this.lstSonuc.TabIndex = 1;
            // 
            // cmbSayilar
            // 
            this.cmbSayilar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSayilar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbSayilar.FormattingEnabled = true;
            this.cmbSayilar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbSayilar.Location = new System.Drawing.Point(12, 12);
            this.cmbSayilar.Name = "cmbSayilar";
            this.cmbSayilar.Size = new System.Drawing.Size(113, 49);
            this.cmbSayilar.TabIndex = 2;
            // 
            // btnDondur
            // 
            this.btnDondur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDondur.ForeColor = System.Drawing.Color.Green;
            this.btnDondur.Location = new System.Drawing.Point(131, 12);
            this.btnDondur.Name = "btnDondur";
            this.btnDondur.Size = new System.Drawing.Size(113, 40);
            this.btnDondur.TabIndex = 3;
            this.btnDondur.Text = "Zar At";
            this.btnDondur.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(316, 293);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn1;
        private Button btn2;
        private ListBox lstSonuc;
        private ComboBox cmbSayilar;
        private Button btnDondur;
        private System.Windows.Forms.Timer tmr1;
    }
}