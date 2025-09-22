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
            label3 = new Label();
            btn_CombinarConectores = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_LoadXml
            // 
            btn_LoadXml.BackgroundImage = (Image)resources.GetObject("btn_LoadXml.BackgroundImage");
            btn_LoadXml.BackgroundImageLayout = ImageLayout.Stretch;
            btn_LoadXml.Location = new Point(35, 34);
            btn_LoadXml.Margin = new Padding(3, 2, 3, 2);
            btn_LoadXml.Name = "btn_LoadXml";
            btn_LoadXml.Size = new Size(51, 42);

            btn_LoadXml.TabIndex = 0;
            btn_LoadXml.UseVisualStyleBackColor = true;
            btn_LoadXml.Click += btn_LoadXml_Click;
            // 
            // lbl_Xml
            // 
            lbl_Xml.BackColor = Color.Transparent;
            lbl_Xml.Font = new Font("Segoe UI", 8F);
            lbl_Xml.Location = new Point(91, 48);
            lbl_Xml.Name = "lbl_Xml";
            lbl_Xml.Size = new Size(513, 34);

            lbl_Xml.TabIndex = 1;
            lbl_Xml.Text = "Seleccionar XML";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_Conexion });
            statusStrip1.Location = new Point(0, 357);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(683, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Conexion
            // 
            lbl_Conexion.Name = "lbl_Conexion";
            lbl_Conexion.Size = new Size(118, 17);
            lbl_Conexion.Text = "toolStripStatusLabel1";
            // 
            // cmb_Conectores
            // 
            cmb_Conectores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Conectores.FormattingEnabled = true;
            cmb_Conectores.Location = new Point(249, 108);
            cmb_Conectores.Margin = new Padding(3, 2, 3, 2);
            cmb_Conectores.Name = "cmb_Conectores";
            cmb_Conectores.Size = new Size(163, 23);
            cmb_Conectores.TabIndex = 3;
            cmb_Conectores.SelectedValueChanged += cmb_Conectores_SelectedValueChanged;
            // 
            // btn_SetsNoUtilizados
            // 
            btn_SetsNoUtilizados.BackgroundImage = (Image)resources.GetObject("btn_SetsNoUtilizados.BackgroundImage");
            btn_SetsNoUtilizados.BackgroundImageLayout = ImageLayout.Stretch;
            btn_SetsNoUtilizados.Location = new Point(35, 160);
            btn_SetsNoUtilizados.Margin = new Padding(3, 2, 3, 2);
            btn_SetsNoUtilizados.Name = "btn_SetsNoUtilizados";
            btn_SetsNoUtilizados.Size = new Size(51, 38);
            btn_SetsNoUtilizados.TabIndex = 4;
            btn_SetsNoUtilizados.UseVisualStyleBackColor = true;
            btn_SetsNoUtilizados.Click += btn_SetsNoUtilizados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(91, 170);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 5;
            label1.Text = "Revisión de Sets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(91, 111);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 6;
            label2.Text = "Seleccionar Conector";
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.BackColor = Color.Transparent;
            btn_Actualizar.BackgroundImage = (Image)resources.GetObject("btn_Actualizar.BackgroundImage");
            btn_Actualizar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Actualizar.Location = new Point(35, 98);
            btn_Actualizar.Margin = new Padding(3, 2, 3, 2);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(51, 40);
            btn_Actualizar.TabIndex = 7;
            btn_Actualizar.UseVisualStyleBackColor = false;
            btn_Actualizar.Click += btn_Actualizar_Click;
            // 
            // btn_GeneraConector
            // 
            btn_GeneraConector.BackgroundImage = (Image)resources.GetObject("btn_GeneraConector.BackgroundImage");
            btn_GeneraConector.BackgroundImageLayout = ImageLayout.Stretch;
            btn_GeneraConector.Location = new Point(35, 213);
            btn_GeneraConector.Margin = new Padding(3, 2, 3, 2);
            btn_GeneraConector.Name = "btn_GeneraConector";
            btn_GeneraConector.Size = new Size(51, 40);
            btn_GeneraConector.TabIndex = 13;
            btn_GeneraConector.UseVisualStyleBackColor = true;
            btn_GeneraConector.Click += btn_GeneraConector_Click;
            // 
            // lbl_GeneraConector
            // 
            lbl_GeneraConector.AutoSize = true;
            lbl_GeneraConector.BackColor = Color.Transparent;
            lbl_GeneraConector.Location = new Point(91, 226);
            lbl_GeneraConector.Name = "lbl_GeneraConector";
            lbl_GeneraConector.Size = new Size(141, 15);
            lbl_GeneraConector.TabIndex = 14;
            lbl_GeneraConector.Text = "Generar Conector Herraje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(91, 286);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 16;
            label3.Text = "Combinar Conectores";
            // 
            // btn_CombinarConectores
            // 
            btn_CombinarConectores.BackgroundImage = (Image)resources.GetObject("btn_CombinarConectores.BackgroundImage");
            btn_CombinarConectores.BackgroundImageLayout = ImageLayout.Stretch;
            btn_CombinarConectores.Location = new Point(35, 273);
            btn_CombinarConectores.Margin = new Padding(3, 2, 3, 2);
            btn_CombinarConectores.Name = "btn_CombinarConectores";
            btn_CombinarConectores.Size = new Size(51, 40);
            btn_CombinarConectores.TabIndex = 15;
            btn_CombinarConectores.UseVisualStyleBackColor = true;
            btn_CombinarConectores.Click += btn_CombinarConectores_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(683, 379);
            Controls.Add(label3);
            Controls.Add(btn_CombinarConectores);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label3;
        private Button btn_CombinarConectores;
    }
}
