namespace Capa_Presentacion
{
    partial class FrmAtencion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtencion));
            lblTitulo = new Label();
            lblAdministrador = new Label();
            lblCajero = new Label();
            iconoCerrarPeronal = new PictureBox();
            iconoMinimizarPersonal = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)iconoCerrarPeronal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizarPersonal).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(120, 160, 100);
            lblTitulo.Font = new Font("Unispace", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(446, 28);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(199, 58);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "label1";
            // 
            // lblAdministrador
            // 
            lblAdministrador.AutoSize = true;
            lblAdministrador.BackColor = Color.FromArgb(120, 160, 100);
            lblAdministrador.Font = new Font("Unispace", 17.9999981F, FontStyle.Bold | FontStyle.Italic);
            lblAdministrador.ForeColor = SystemColors.ActiveCaptionText;
            lblAdministrador.Location = new Point(223, 286);
            lblAdministrador.Margin = new Padding(6, 0, 6, 0);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(151, 43);
            lblAdministrador.TabIndex = 2;
            lblAdministrador.Text = "label3";
            // 
            // lblCajero
            // 
            lblCajero.AutoSize = true;
            lblCajero.BackColor = Color.FromArgb(120, 160, 100);
            lblCajero.Font = new Font("Unispace", 17.9999981F, FontStyle.Bold | FontStyle.Italic);
            lblCajero.ForeColor = SystemColors.ActiveCaptionText;
            lblCajero.Location = new Point(223, 418);
            lblCajero.Margin = new Padding(6, 0, 6, 0);
            lblCajero.Name = "lblCajero";
            lblCajero.Size = new Size(151, 43);
            lblCajero.TabIndex = 3;
            lblCajero.Text = "label1";
            lblCajero.Click += lblCajero_Click;
            // 
            // iconoCerrarPeronal
            // 
            iconoCerrarPeronal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoCerrarPeronal.Image = (Image)resources.GetObject("iconoCerrarPeronal.Image");
            iconoCerrarPeronal.Location = new Point(1531, 12);
            iconoCerrarPeronal.Name = "iconoCerrarPeronal";
            iconoCerrarPeronal.Size = new Size(30, 30);
            iconoCerrarPeronal.SizeMode = PictureBoxSizeMode.Zoom;
            iconoCerrarPeronal.TabIndex = 20;
            iconoCerrarPeronal.TabStop = false;
            iconoCerrarPeronal.Click += iconoCerrarPeronal_Click;
            // 
            // iconoMinimizarPersonal
            // 
            iconoMinimizarPersonal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoMinimizarPersonal.Image = (Image)resources.GetObject("iconoMinimizarPersonal.Image");
            iconoMinimizarPersonal.Location = new Point(1482, 12);
            iconoMinimizarPersonal.Name = "iconoMinimizarPersonal";
            iconoMinimizarPersonal.Size = new Size(30, 30);
            iconoMinimizarPersonal.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMinimizarPersonal.TabIndex = 23;
            iconoMinimizarPersonal.TabStop = false;
            iconoMinimizarPersonal.Click += iconoMinimizarPersonal_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1573, 150);
            panel1.TabIndex = 24;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 160, 100);
            ClientSize = new Size(1573, 648);
            Controls.Add(iconoMinimizarPersonal);
            Controls.Add(iconoCerrarPeronal);
            Controls.Add(lblCajero);
            Controls.Add(lblAdministrador);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 4, 6, 4);
            Name = "FrmAtencion";
            Text = "FrmAtencion";
            Load += FrmAtencion_Load;
            ((System.ComponentModel.ISupportInitialize)iconoCerrarPeronal).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizarPersonal).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAdministrador;
        private Label lblCajero;
        private PictureBox iconoCerrarPeronal;
        private PictureBox iconoMinimizarPersonal;
        private Panel panel1;
    }
}