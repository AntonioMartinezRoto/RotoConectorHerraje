namespace RotoConectorHerraje
{
    partial class GeneraConector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneraConector));
            txt_ConectorName = new TextBox();
            label4 = new Label();
            btn_InsertConector = new Button();
            label3 = new Label();
            btn_GenerarConector = new Button();
            chk_Predefinido = new CheckBox();
            txt_Filtro = new TextBox();
            lbl_Filtro = new Label();
            dataGridView1 = new DataGridView();
            sts_Conection = new StatusStrip();
            lbl_Conexion = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            sts_Conection.SuspendLayout();
            SuspendLayout();
            // 
            // txt_ConectorName
            // 
            txt_ConectorName.Location = new Point(500, 28);
            txt_ConectorName.Name = "txt_ConectorName";
            txt_ConectorName.Size = new Size(174, 23);
            txt_ConectorName.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(386, 30);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 16;
            label4.Text = "Guardar en BBDD";
            // 
            // btn_InsertConector
            // 
            btn_InsertConector.BackgroundImage = (Image)resources.GetObject("btn_InsertConector.BackgroundImage");
            btn_InsertConector.BackgroundImageLayout = ImageLayout.Stretch;
            btn_InsertConector.Location = new Point(340, 17);
            btn_InsertConector.Margin = new Padding(3, 2, 3, 2);
            btn_InsertConector.Name = "btn_InsertConector";
            btn_InsertConector.Size = new Size(40, 40);
            btn_InsertConector.TabIndex = 15;
            btn_InsertConector.UseVisualStyleBackColor = true;
            btn_InsertConector.Click += btn_InsertConector_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(107, 28);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 14;
            label3.Text = "Guardar en XML";
            // 
            // btn_GenerarConector
            // 
            btn_GenerarConector.BackgroundImage = (Image)resources.GetObject("btn_GenerarConector.BackgroundImage");
            btn_GenerarConector.BackgroundImageLayout = ImageLayout.Stretch;
            btn_GenerarConector.Location = new Point(61, 16);
            btn_GenerarConector.Margin = new Padding(3, 2, 3, 2);
            btn_GenerarConector.Name = "btn_GenerarConector";
            btn_GenerarConector.Size = new Size(40, 40);
            btn_GenerarConector.TabIndex = 13;
            btn_GenerarConector.UseVisualStyleBackColor = true;
            btn_GenerarConector.Click += btn_GenerarConector_Click;
            // 
            // chk_Predefinido
            // 
            chk_Predefinido.AutoSize = true;
            chk_Predefinido.BackColor = Color.Transparent;
            chk_Predefinido.Location = new Point(680, 30);
            chk_Predefinido.Name = "chk_Predefinido";
            chk_Predefinido.Size = new Size(155, 19);
            chk_Predefinido.TabIndex = 18;
            chk_Predefinido.Text = "Poner como predefinido";
            chk_Predefinido.UseVisualStyleBackColor = false;
            // 
            // txt_Filtro
            // 
            txt_Filtro.Location = new Point(930, 28);
            txt_Filtro.Name = "txt_Filtro";
            txt_Filtro.Size = new Size(214, 23);
            txt_Filtro.TabIndex = 20;
            txt_Filtro.TextChanged += txt_Filtro_TextChanged;
            // 
            // lbl_Filtro
            // 
            lbl_Filtro.AutoSize = true;
            lbl_Filtro.BackColor = Color.Transparent;
            lbl_Filtro.Location = new Point(882, 31);
            lbl_Filtro.Name = "lbl_Filtro";
            lbl_Filtro.Size = new Size(42, 15);
            lbl_Filtro.TabIndex = 21;
            lbl_Filtro.Text = "Buscar";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1115, 677);
            dataGridView1.TabIndex = 22;
            // 
            // sts_Conection
            // 
            sts_Conection.BackColor = Color.Transparent;
            sts_Conection.Items.AddRange(new ToolStripItem[] { lbl_Conexion });
            sts_Conection.Location = new Point(0, 754);
            sts_Conection.Name = "sts_Conection";
            sts_Conection.Size = new Size(1434, 22);
            sts_Conection.SizingGrip = false;
            sts_Conection.TabIndex = 23;
            sts_Conection.Text = "statusStrip1";
            // 
            // lbl_Conexion
            // 
            lbl_Conexion.Name = "lbl_Conexion";
            lbl_Conexion.Size = new Size(118, 17);
            lbl_Conexion.Text = "toolStripStatusLabel1";
            // 
            // GeneraConector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1434, 776);
            Controls.Add(sts_Conection);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_Filtro);
            Controls.Add(txt_Filtro);
            Controls.Add(chk_Predefinido);
            Controls.Add(txt_ConectorName);
            Controls.Add(label4);
            Controls.Add(btn_InsertConector);
            Controls.Add(label3);
            Controls.Add(btn_GenerarConector);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GeneraConector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar conector";
            Load += GeneraConector_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            sts_Conection.ResumeLayout(false);
            sts_Conection.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ConectorName;
        private Label label4;
        private Button btn_InsertConector;
        private Label label3;
        private Button btn_GenerarConector;
        private CheckBox chk_Predefinido;
        private TextBox txt_Filtro;
        private Label lbl_Filtro;
        private DataGridView dataGridView1;
        private StatusStrip sts_Conection;
        private ToolStripStatusLabel lbl_Conexion;
    }
}