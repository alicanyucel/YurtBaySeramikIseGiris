namespace YurtbaySeramik.GoruntuleForm
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
            grbxPersonel = new GroupBox();
            btnYenile = new Button();
            dtgPersonel = new DataGridView();
            btnEkle = new Button();
            grbxPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPersonel).BeginInit();
            SuspendLayout();
            // 
            // grbxPersonel
            // 
            grbxPersonel.Controls.Add(btnYenile);
            grbxPersonel.Controls.Add(dtgPersonel);
            grbxPersonel.Controls.Add(btnEkle);
            grbxPersonel.Dock = DockStyle.Fill;
            grbxPersonel.Location = new Point(0, 0);
            grbxPersonel.Name = "grbxPersonel";
            grbxPersonel.Size = new Size(800, 450);
            grbxPersonel.TabIndex = 0;
            grbxPersonel.TabStop = false;
            grbxPersonel.Text = "Personel Bilgileri";
            grbxPersonel.Enter += grbxPersonel_Enter;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(646, 288);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(142, 23);
            btnYenile.TabIndex = 2;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // dtgPersonel
            // 
            dtgPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPersonel.Location = new Point(12, 22);
            dtgPersonel.Name = "dtgPersonel";
            dtgPersonel.RowTemplate.Height = 25;
            dtgPersonel.Size = new Size(794, 260);
            dtgPersonel.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(6, 288);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(622, 23);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Personel Ekleyiniz";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbxPersonel);
            Name = "Form1";
            Text = "Form1";
            grbxPersonel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgPersonel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbxPersonel;
        private DataGridView dtgPersonel;
        private Button btnEkle;
        private Button btnYenile;
    }
}