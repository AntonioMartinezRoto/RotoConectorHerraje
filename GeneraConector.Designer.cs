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
            txt_ConectorName.Location = new Point(571, 37);
            txt_ConectorName.Margin = new Padding(3, 4, 3, 4);
            txt_ConectorName.Name = "txt_ConectorName";
            txt_ConectorName.Size = new Size(198, 27);
            txt_ConectorName.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(441, 40);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 16;
            label4.Text = "Guardar en BBDD";
            // 
            // btn_InsertConector
            // 
            btn_InsertConector.BackgroundImage = (Image)resources.GetObject("btn_InsertConector.BackgroundImage");
            btn_InsertConector.BackgroundImageLayout = ImageLayout.Stretch;
            btn_InsertConector.Location = new Point(379, 23);
            btn_InsertConector.Name = "btn_InsertConector";
            btn_InsertConector.Size = new Size(56, 53);
            btn_InsertConector.TabIndex = 15;
            btn_InsertConector.UseVisualStyleBackColor = true;
            btn_InsertConector.Click += btn_InsertConector_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(122, 37);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 14;
            label3.Text = "Guardar en XML";
            // 
            // btn_GenerarConector
            // 
            btn_GenerarConector.BackgroundImage = (Image)resources.GetObject("btn_GenerarConector.BackgroundImage");
            btn_GenerarConector.BackgroundImageLayout = ImageLayout.Stretch;
            btn_GenerarConector.Location = new Point(62, 21);
            btn_GenerarConector.Name = "btn_GenerarConector";
            btn_GenerarConector.Size = new Size(54, 53);
            btn_GenerarConector.TabIndex = 13;
            btn_GenerarConector.UseVisualStyleBackColor = true;
            btn_GenerarConector.Click += btn_GenerarConector_Click;
            // 
            // chk_Predefinido
            // 
            chk_Predefinido.AutoSize = true;
            chk_Predefinido.BackColor = Color.Transparent;
            chk_Predefinido.Location = new Point(777, 40);
            chk_Predefinido.Margin = new Padding(3, 4, 3, 4);
            chk_Predefinido.Name = "chk_Predefinido";
            chk_Predefinido.Size = new Size(192, 24);
            chk_Predefinido.TabIndex = 18;
            chk_Predefinido.Text = "Poner como predefinido";
            chk_Predefinido.UseVisualStyleBackColor = false;
            // 
            // txt_Filtro
            // 
            txt_Filtro.Location = new Point(1063, 37);
            txt_Filtro.Margin = new Padding(3, 4, 3, 4);
            txt_Filtro.Name = "txt_Filtro";
            txt_Filtro.Size = new Size(244, 27);
            txt_Filtro.TabIndex = 20;
            txt_Filtro.TextChanged += txt_Filtro_TextChanged;
            // 
            // lbl_Filtro
            // 
            lbl_Filtro.AutoSize = true;
            lbl_Filtro.BackColor = Color.Transparent;
            lbl_Filtro.Location = new Point(1008, 41);
            lbl_Filtro.Name = "lbl_Filtro";
            lbl_Filtro.Size = new Size(52, 20);
            lbl_Filtro.TabIndex = 21;
            lbl_Filtro.Text = "Buscar";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 89);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1274, 903);
            dataGridView1.TabIndex = 22;
            // 
            // sts_Conection
            // 
            sts_Conection.BackColor = Color.Transparent;
            sts_Conection.ImageScalingSize = new Size(20, 20);
            sts_Conection.Items.AddRange(new ToolStripItem[] { lbl_Conexion });
            sts_Conection.Location = new Point(0, 1009);
            sts_Conection.Name = "sts_Conection";
            sts_Conection.Padding = new Padding(1, 0, 16, 0);
            sts_Conection.Size = new Size(1639, 26);
            sts_Conection.SizingGrip = false;
            sts_Conection.TabIndex = 23;
            sts_Conection.Text = "statusStrip1";
            // 
            // lbl_Conexion
            // 
            lbl_Conexion.Name = "lbl_Conexion";
            lbl_Conexion.Size = new Size(151, 20);
            lbl_Conexion.Text = "toolStripStatusLabel1";
            // 
            // GeneraConector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1639, 1035);
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
            Margin = new Padding(3, 4, 3, 4);
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