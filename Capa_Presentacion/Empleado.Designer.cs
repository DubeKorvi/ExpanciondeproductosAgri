namespace Capa_Presentacion
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            listBox1 = new ListBox();
            iconoCerrarEmp = new PictureBox();
            iconoMinimizarEmp = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconoCerrarEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizarEmp).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(120, 160, 100);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 26;
            listBox1.Location = new Point(0, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(800, 392);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // iconoCerrarEmp
            // 
            iconoCerrarEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoCerrarEmp.Image = (Image)resources.GetObject("iconoCerrarEmp.Image");
            iconoCerrarEmp.Location = new Point(758, 12);
            iconoCerrarEmp.Name = "iconoCerrarEmp";
            iconoCerrarEmp.Size = new Size(30, 30);
            iconoCerrarEmp.SizeMode = PictureBoxSizeMode.Zoom;
            iconoCerrarEmp.TabIndex = 10;
            iconoCerrarEmp.TabStop = false;
            iconoCerrarEmp.Click += iconoCerrarEmp_Click;
            // 
            // iconoMinimizarEmp
            // 
            iconoMinimizarEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconoMinimizarEmp.Image = (Image)resources.GetObject("iconoMinimizarEmp.Image");
            iconoMinimizarEmp.Location = new Point(722, 12);
            iconoMinimizarEmp.Name = "iconoMinimizarEmp";
            iconoMinimizarEmp.Size = new Size(30, 30);
            iconoMinimizarEmp.SizeMode = PictureBoxSizeMode.Zoom;
            iconoMinimizarEmp.TabIndex = 13;
            iconoMinimizarEmp.TabStop = false;
            iconoMinimizarEmp.Click += iconoMinimizarEmp_Click;
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 160, 100);
            ClientSize = new Size(800, 450);
            Controls.Add(iconoMinimizarEmp);
            Controls.Add(iconoCerrarEmp);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Empleado";
            Text = "Empleado";
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)iconoCerrarEmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMinimizarEmp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private PictureBox iconoCerrarEmp;
        private PictureBox iconoMinimizarEmp;
    }
}