

namespace Compilador
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cuadroTexto = new System.Windows.Forms.TextBox();
            this.arbolSintax = new System.Windows.Forms.TreeView();
            this.cuadroResultados = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.PictureBox();
            this.btnMachine = new System.Windows.Forms.PictureBox();
            this.btnIntermedio = new System.Windows.Forms.PictureBox();
            this.btnSemantic = new System.Windows.Forms.PictureBox();
            this.btnSitax = new System.Windows.Forms.PictureBox();
            this.btnLexi = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.PictureBox();
            this.btnCompilar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tablaSimbolos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIntermedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSemantic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSitax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLexi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompilar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 381);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cuadroTexto);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.arbolSintax);
            this.splitContainer1.Panel2.Controls.Add(this.cuadroResultados);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(877, 381);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.TabIndex = 0;
            // 
            // cuadroTexto
            // 
            this.cuadroTexto.AcceptsReturn = true;
            this.cuadroTexto.BackColor = System.Drawing.SystemColors.Window;
            this.cuadroTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroTexto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cuadroTexto.Location = new System.Drawing.Point(14, 14);
            this.cuadroTexto.Multiline = true;
            this.cuadroTexto.Name = "cuadroTexto";
            this.cuadroTexto.Size = new System.Drawing.Size(320, 358);
            this.cuadroTexto.TabIndex = 1;
            // 
            // arbolSintax
            // 
            this.arbolSintax.Location = new System.Drawing.Point(344, 14);
            this.arbolSintax.Name = "arbolSintax";
            this.arbolSintax.Size = new System.Drawing.Size(161, 358);
            this.arbolSintax.TabIndex = 1;
            // 
            // cuadroResultados
            // 
            this.cuadroResultados.AcceptsReturn = true;
            this.cuadroResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroResultados.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cuadroResultados.Location = new System.Drawing.Point(15, 14);
            this.cuadroResultados.Multiline = true;
            this.cuadroResultados.Name = "cuadroResultados";
            this.cuadroResultados.Size = new System.Drawing.Size(312, 358);
            this.cuadroResultados.TabIndex = 0;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutar.Image = global::Compilador.Properties.Resources.execute;
            this.btnEjecutar.InitialImage = null;
            this.btnEjecutar.Location = new System.Drawing.Point(685, 17);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(47, 40);
            this.btnEjecutar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEjecutar.TabIndex = 10;
            this.btnEjecutar.TabStop = false;
            this.btnEjecutar.MouseLeave += new System.EventHandler(this.btnEjecutar_MouseLeave);
            this.btnEjecutar.MouseHover += new System.EventHandler(this.btnEjecutar_MouseHover);
            // 
            // btnMachine
            // 
            this.btnMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMachine.Image = global::Compilador.Properties.Resources.computer_icon9;
            this.btnMachine.InitialImage = null;
            this.btnMachine.Location = new System.Drawing.Point(617, 17);
            this.btnMachine.Name = "btnMachine";
            this.btnMachine.Size = new System.Drawing.Size(47, 40);
            this.btnMachine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMachine.TabIndex = 9;
            this.btnMachine.TabStop = false;
            this.btnMachine.Click += new System.EventHandler(this.btnMachine_Click);
            this.btnMachine.MouseLeave += new System.EventHandler(this.btnMachine_MouseLeave);
            this.btnMachine.MouseHover += new System.EventHandler(this.btnMachine_MouseHover);
            // 
            // btnIntermedio
            // 
            this.btnIntermedio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntermedio.Image = global::Compilador.Properties.Resources.maquina;
            this.btnIntermedio.InitialImage = null;
            this.btnIntermedio.Location = new System.Drawing.Point(550, 17);
            this.btnIntermedio.Name = "btnIntermedio";
            this.btnIntermedio.Size = new System.Drawing.Size(47, 40);
            this.btnIntermedio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnIntermedio.TabIndex = 8;
            this.btnIntermedio.TabStop = false;
            this.btnIntermedio.Click += new System.EventHandler(this.btnIntermedio_Click);
            this.btnIntermedio.MouseLeave += new System.EventHandler(this.btnIntermedio_MouseLeave);
            this.btnIntermedio.MouseHover += new System.EventHandler(this.btnIntermedio_MouseHover);
            // 
            // btnSemantic
            // 
            this.btnSemantic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSemantic.Image = global::Compilador.Properties.Resources.semantic;
            this.btnSemantic.InitialImage = null;
            this.btnSemantic.Location = new System.Drawing.Point(484, 17);
            this.btnSemantic.Name = "btnSemantic";
            this.btnSemantic.Size = new System.Drawing.Size(47, 40);
            this.btnSemantic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSemantic.TabIndex = 7;
            this.btnSemantic.TabStop = false;
            this.btnSemantic.Click += new System.EventHandler(this.btnSemantic_Click);
            this.btnSemantic.MouseLeave += new System.EventHandler(this.btnSemantic_MouseLeave);
            this.btnSemantic.MouseHover += new System.EventHandler(this.btnSemantic_MouseHover);
            // 
            // btnSitax
            // 
            this.btnSitax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSitax.Image = global::Compilador.Properties.Resources.sintactic;
            this.btnSitax.InitialImage = null;
            this.btnSitax.Location = new System.Drawing.Point(419, 17);
            this.btnSitax.Name = "btnSitax";
            this.btnSitax.Size = new System.Drawing.Size(47, 40);
            this.btnSitax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSitax.TabIndex = 6;
            this.btnSitax.TabStop = false;
            this.btnSitax.Click += new System.EventHandler(this.btnSitax_Click);
            this.btnSitax.MouseLeave += new System.EventHandler(this.btnSitax_MouseLeave);
            this.btnSitax.MouseHover += new System.EventHandler(this.btnSitax_MouseHover);
            // 
            // btnLexi
            // 
            this.btnLexi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLexi.Image = global::Compilador.Properties.Resources.analysis_icon_6;
            this.btnLexi.InitialImage = null;
            this.btnLexi.Location = new System.Drawing.Point(352, 17);
            this.btnLexi.Name = "btnLexi";
            this.btnLexi.Size = new System.Drawing.Size(47, 40);
            this.btnLexi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLexi.TabIndex = 5;
            this.btnLexi.TabStop = false;
            this.btnLexi.Click += new System.EventHandler(this.btnLexi_Click);
            this.btnLexi.MouseLeave += new System.EventHandler(this.btnLexi_MouseLeave);
            this.btnLexi.MouseHover += new System.EventHandler(this.btnLexi_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::Compilador.Properties.Resources.save_icon_5;
            this.btnSave.InitialImage = null;
            this.btnSave.Location = new System.Drawing.Point(287, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 40);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSave.TabIndex = 4;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Image = global::Compilador.Properties.Resources.Open_icon;
            this.btnOpen.InitialImage = null;
            this.btnOpen.Location = new System.Drawing.Point(222, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(47, 40);
            this.btnOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOpen.TabIndex = 3;
            this.btnOpen.TabStop = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            this.btnOpen.MouseLeave += new System.EventHandler(this.btnOpen_MouseLeave);
            this.btnOpen.MouseHover += new System.EventHandler(this.btnOpen_MouseHover);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Image = global::Compilador.Properties.Resources.newfile;
            this.btnNuevo.InitialImage = null;
            this.btnNuevo.Location = new System.Drawing.Point(160, 17);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(47, 40);
            this.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            this.btnNuevo.MouseHover += new System.EventHandler(this.btnNuevo_MouseHover);
            // 
            // btnCompilar
            // 
            this.btnCompilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompilar.Image = global::Compilador.Properties.Resources.compfile;
            this.btnCompilar.InitialImage = null;
            this.btnCompilar.Location = new System.Drawing.Point(89, 17);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(47, 40);
            this.btnCompilar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCompilar.TabIndex = 1;
            this.btnCompilar.TabStop = false;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            this.btnCompilar.MouseLeave += new System.EventHandler(this.btnCompilar_MouseLeave);
            this.btnCompilar.MouseHover += new System.EventHandler(this.btnCompilar_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEjecutar);
            this.panel2.Controls.Add(this.btnCompilar);
            this.panel2.Controls.Add(this.btnMachine);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.btnIntermedio);
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.btnSemantic);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnSitax);
            this.panel2.Controls.Add(this.btnLexi);
            this.panel2.Location = new System.Drawing.Point(12, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 80);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tablaSimbolos);
            this.panel3.Location = new System.Drawing.Point(12, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(877, 178);
            this.panel3.TabIndex = 12;
            // 
            // tablaSimbolos
            // 
            this.tablaSimbolos.AllowUserToAddRows = false;
            this.tablaSimbolos.AllowUserToDeleteRows = false;
            this.tablaSimbolos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Variable,
            this.Tipo,
            this.Valor});
            this.tablaSimbolos.Location = new System.Drawing.Point(268, 0);
            this.tablaSimbolos.Name = "tablaSimbolos";
            this.tablaSimbolos.ReadOnly = true;
            this.tablaSimbolos.Size = new System.Drawing.Size(454, 172);
            this.tablaSimbolos.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Variable
            // 
            this.Variable.HeaderText = "Variable";
            this.Variable.Name = "Variable";
            this.Variable.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 682);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(938, 720);
            this.MinimumSize = new System.Drawing.Size(938, 720);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Compilador";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIntermedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSemantic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSitax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLexi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompilar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSimbolos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox cuadroTexto;
        private System.Windows.Forms.TextBox cuadroResultados;
        private System.Windows.Forms.PictureBox btnCompilar;
        private System.Windows.Forms.PictureBox btnNuevo;
        private System.Windows.Forms.PictureBox btnOpen;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.PictureBox btnLexi;
        private System.Windows.Forms.PictureBox btnSitax;
        private System.Windows.Forms.PictureBox btnSemantic;
        private System.Windows.Forms.PictureBox btnIntermedio;
        private System.Windows.Forms.PictureBox btnMachine;
        private System.Windows.Forms.PictureBox btnEjecutar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView arbolSintax;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tablaSimbolos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}

