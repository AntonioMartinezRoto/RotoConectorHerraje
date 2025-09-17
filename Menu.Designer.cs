namespace RotoConectorHerraje
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btn_LoadXml = new Button();
            lbl_Xml = new Label();
            statusStrip1 = new StatusStrip();
            lbl_Conexion = new ToolStripStatusLabel();
            cmb_Conectores = new ComboBox();
            btn_SetsNoUtilizados = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_Actualizar = new Button();
            btn_GeneraConector = new Button();
            lbl_GeneraConector = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_LoadXml
            // 
            btn_LoadXml.BackgroundImage = (Image)resources.GetObject("btn_LoadXml.BackgroundImage");
            btn_LoadXml.BackgroundImageLayout = ImageLayout.Stretch;
            btn_LoadXml.Location = new Point(42, 72);
            btn_LoadXml.Name = "btn_LoadXml";
            btn_LoadXml.Size = new Size(58, 56);
            btn_LoadXml.TabIndex = 0;
            btn_LoadXml.UseVisualStyleBackColor = true;
            btn_LoadXml.Click += btn_LoadXml_Click;
            // 
            // lbl_Xml
            // 
            lbl_Xml.BackColor = Color.Transparent;
            lbl_Xml.Font = new Font("Segoe UI", 8F);
            lbl_Xml.Location = new Point(106, 91);
            lbl_Xml.Name = "lbl_Xml";
            lbl_Xml.Size = new Size(586, 46);
            lbl_Xml.TabIndex = 1;
            lbl_Xml.Text = "Seleccionar XML";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_Conexion });
            statusStrip1.Location = new Point(0, 446);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(781, 26);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Conexion
            // 
            lbl_Conexion.Name = "lbl_Conexion";
            lbl_Conexion.Size = new Size(151, 20);
            lbl_Conexion.Text = "toolStripStatusLabel1";
            // 
            // cmb_Conectores
            // 
            cmb_Conectores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Conectores.FormattingEnabled = true;
            cmb_Conectores.Location = new Point(308, 172);
            cmb_Conectores.Name = "cmb_Conectores";
            cmb_Conectores.Size = new Size(186, 28);
            cmb_Conectores.TabIndex = 3;
            cmb_Conectores.SelectedValueChanged += cmb_Conectores_SelectedValueChanged;
            // 
            // btn_SetsNoUtilizados
            // 
            btn_SetsNoUtilizados.BackgroundImage = (Image)resources.GetObject("btn_SetsNoUtilizados.BackgroundImage");
            btn_SetsNoUtilizados.BackgroundImageLayout = ImageLayout.Stretch;
            btn_SetsNoUtilizados.Location = new Point(42, 240);
            btn_SetsNoUtilizados.Name = "btn_SetsNoUtilizados";
            btn_SetsNoUtilizados.Size = new Size(58, 51);
            btn_SetsNoUtilizados.TabIndex = 4;
            btn_SetsNoUtilizados.UseVisualStyleBackColor = true;
            btn_SetsNoUtilizados.Click += btn_SetsNoUtilizados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(106, 253);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 5;
            label1.Text = "Revisión de Sets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(106, 175);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 6;
            label2.Text = "Seleccionar Conector";
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.BackColor = Color.Transparent;
            btn_Actualizar.BackgroundImage = (Image)resources.GetObject("btn_Actualizar.BackgroundImage");
            btn_Actualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Actualizar.Location = new Point(42, 157);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(58, 53);
            btn_Actualizar.TabIndex = 7;
            btn_Actualizar.UseVisualStyleBackColor = false;
            btn_Actualizar.Click += btn_Actualizar_Click;
            // 
            // btn_GeneraConector
            // 
            btn_GeneraConector.BackgroundImage = (Image)resources.GetObject("btn_GeneraConector.BackgroundImage");
            btn_GeneraConector.BackgroundImageLayout = ImageLayout.Stretch;
            btn_GeneraConector.Location = new Point(42, 311);
            btn_GeneraConector.Name = "btn_GeneraConector";
            btn_GeneraConector.Size = new Size(58, 54);
            btn_GeneraConector.TabIndex = 13;
            btn_GeneraConector.UseVisualStyleBackColor = true;
            btn_GeneraConector.Click += btn_GeneraConector_Click;
            // 
            // lbl_GeneraConector
            // 
            lbl_GeneraConector.AutoSize = true;
            lbl_GeneraConector.BackColor = Color.Transparent;
            lbl_GeneraConector.Location = new Point(106, 328);
            lbl_GeneraConector.Name = "lbl_GeneraConector";
            lbl_GeneraConector.Size = new Size(178, 20);
            lbl_GeneraConector.TabIndex = 14;
            lbl_GeneraConector.Text = "Generar Conector Herraje";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(781, 472);
            Controls.Add(lbl_GeneraConector);
            Controls.Add(btn_GeneraConector);
            Controls.Add(btn_Actualizar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_SetsNoUtilizados);
            Controls.Add(cmb_Conectores);
            Controls.Add(statusStrip1);
            Controls.Add(lbl_Xml);
            Controls.Add(btn_LoadXml);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RotoConectorHerraje";
            Load += Menu_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_LoadXml;
        private Label lbl_Xml;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl_Conexion;
        private ComboBox cmb_Conectores;
        private Button btn_SetsNoUtilizados;
        private Label label1;
        private Label label2;
        private Button btn_Actualizar;
        private Button btn_GeneraConector;
        private Label lbl_GeneraConector;
    }
}
