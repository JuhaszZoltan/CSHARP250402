namespace CSHARP250402
{
    partial class HappyCowsForm
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
            lblUi02 = new Label();
            trbTej = new TrackBar();
            cbxNap = new ComboBox();
            txtTehenID = new TextBox();
            btnLekerdezes = new Button();
            lblUi03 = new Label();
            lblUi04 = new Label();
            lblUi05 = new Label();
            lblTej = new Label();
            btnKilepes = new Button();
            lblUi01 = new Label();
            ((System.ComponentModel.ISupportInitialize)trbTej).BeginInit();
            SuspendLayout();
            // 
            // lblUi02
            // 
            lblUi02.AutoSize = true;
            lblUi02.Font = new Font("Segoe UI", 10F);
            lblUi02.Location = new Point(12, 135);
            lblUi02.Name = "lblUi02";
            lblUi02.Size = new Size(241, 28);
            lblUi02.TabIndex = 0;
            lblUi02.Text = "Szarvasmarha azonosítója:";
            // 
            // trbTej
            // 
            trbTej.Location = new Point(466, 181);
            trbTej.Maximum = 25;
            trbTej.Minimum = 15;
            trbTej.Name = "trbTej";
            trbTej.Size = new Size(400, 69);
            trbTej.TabIndex = 1;
            trbTej.Value = 20;
            // 
            // cbxNap
            // 
            cbxNap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNap.FormattingEnabled = true;
            cbxNap.Items.AddRange(new object[] { "Hétfő", "Kedd", "Szerda", "Csütörtök", "Péntek", "Szombat", "Vasárnap" });
            cbxNap.Location = new Point(85, 253);
            cbxNap.Name = "cbxNap";
            cbxNap.Size = new Size(218, 40);
            cbxNap.TabIndex = 2;
            // 
            // txtTehenID
            // 
            txtTehenID.Location = new Point(12, 171);
            txtTehenID.Name = "txtTehenID";
            txtTehenID.Size = new Size(291, 39);
            txtTehenID.TabIndex = 3;
            // 
            // btnLekerdezes
            // 
            btnLekerdezes.Location = new Point(12, 368);
            btnLekerdezes.Name = "btnLekerdezes";
            btnLekerdezes.Size = new Size(275, 64);
            btnLekerdezes.TabIndex = 4;
            btnLekerdezes.Text = "Lekérdezés";
            btnLekerdezes.UseVisualStyleBackColor = true;
            // 
            // lblUi03
            // 
            lblUi03.AutoSize = true;
            lblUi03.Location = new Point(466, 132);
            lblUi03.Name = "lblUi03";
            lblUi03.Size = new Size(103, 32);
            lblUi03.TabIndex = 0;
            lblUi03.Text = "Tej limit:";
            // 
            // lblUi04
            // 
            lblUi04.AutoSize = true;
            lblUi04.Location = new Point(372, 181);
            lblUi04.Name = "lblUi04";
            lblUi04.Size = new Size(88, 32);
            lblUi04.TabIndex = 0;
            lblUi04.Text = "15 liter";
            // 
            // lblUi05
            // 
            lblUi05.AutoSize = true;
            lblUi05.Location = new Point(872, 181);
            lblUi05.Name = "lblUi05";
            lblUi05.Size = new Size(88, 32);
            lblUi05.TabIndex = 0;
            lblUi05.Text = "25 liter";
            // 
            // lblTej
            // 
            lblTej.Location = new Point(372, 253);
            lblTej.Name = "lblTej";
            lblTej.Size = new Size(588, 51);
            lblTej.TabIndex = 0;
            lblTej.Text = "####";
            lblTej.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKilepes
            // 
            btnKilepes.Location = new Point(691, 368);
            btnKilepes.Name = "btnKilepes";
            btnKilepes.Size = new Size(275, 64);
            btnKilepes.TabIndex = 4;
            btnKilepes.Text = "Kilépés";
            btnKilepes.UseVisualStyleBackColor = true;
            // 
            // lblUi01
            // 
            lblUi01.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblUi01.Location = new Point(12, 9);
            lblUi01.Name = "lblUi01";
            lblUi01.Size = new Size(954, 76);
            lblUi01.TabIndex = 0;
            lblUi01.Text = "Tejhozam lekérdezése:";
            lblUi01.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HappyCowsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 444);
            Controls.Add(btnKilepes);
            Controls.Add(btnLekerdezes);
            Controls.Add(txtTehenID);
            Controls.Add(cbxNap);
            Controls.Add(trbTej);
            Controls.Add(lblTej);
            Controls.Add(lblUi05);
            Controls.Add(lblUi04);
            Controls.Add(lblUi03);
            Controls.Add(lblUi01);
            Controls.Add(lblUi02);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "HappyCowsForm";
            Text = "Happy-Cows Nyírség Kft.";
            ((System.ComponentModel.ISupportInitialize)trbTej).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUi02;
        private TrackBar trbTej;
        private ComboBox cbxNap;
        private TextBox txtTehenID;
        private Button btnLekerdezes;
        private Label lblUi03;
        private Label lblUi04;
        private Label lblUi05;
        private Label lblTej;
        private Button btnKilepes;
        private Label lblUi01;
    }
}
