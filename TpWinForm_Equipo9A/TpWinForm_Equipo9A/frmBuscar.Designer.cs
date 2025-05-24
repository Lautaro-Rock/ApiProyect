namespace TpWinForm_Equipo9A
{
    partial class frmBuscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCampo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.PanelResultadoBusq = new System.Windows.Forms.Panel();
            this.dataGridViewFitro = new System.Windows.Forms.DataGridView();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.pcBoxFiltro = new System.Windows.Forms.PictureBox();
            this.BotonBusqueda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelResultadoBusq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFitro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 35);
            this.panel1.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(685, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(59, 35);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Buscar Artículos";
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampo.Location = new System.Drawing.Point(24, 70);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(62, 18);
            this.labelCampo.TabIndex = 4;
            this.labelCampo.Text = "Campo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Criterio";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(231, 91);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(139, 28);
            this.cboCriterio.TabIndex = 7;
            // 
            // PanelResultadoBusq
            // 
            this.PanelResultadoBusq.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelResultadoBusq.Controls.Add(this.pcBoxFiltro);
            this.PanelResultadoBusq.Controls.Add(this.dataGridViewFitro);
            this.PanelResultadoBusq.Location = new System.Drawing.Point(7, 203);
            this.PanelResultadoBusq.Name = "PanelResultadoBusq";
            this.PanelResultadoBusq.Size = new System.Drawing.Size(725, 288);
            this.PanelResultadoBusq.TabIndex = 12;
            // 
            // dataGridViewFitro
            // 
            this.dataGridViewFitro.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewFitro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFitro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFitro.GridColor = System.Drawing.Color.White;
            this.dataGridViewFitro.Location = new System.Drawing.Point(20, 14);
            this.dataGridViewFitro.Name = "dataGridViewFitro";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFitro.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFitro.Size = new System.Drawing.Size(489, 254);
            this.dataGridViewFitro.TabIndex = 0;
            this.dataGridViewFitro.SelectionChanged += new System.EventHandler(this.dataGridViewFitro_SelectionChanged_1);
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(27, 91);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(159, 28);
            this.cboCampo.TabIndex = 14;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.Campo_SelectedIndexChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(27, 159);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(139, 26);
            this.txtFiltro.TabIndex = 15;
            // 
            // pcBoxFiltro
            // 
            this.pcBoxFiltro.BackColor = System.Drawing.Color.Black;
            this.pcBoxFiltro.Location = new System.Drawing.Point(530, 0);
            this.pcBoxFiltro.Name = "pcBoxFiltro";
            this.pcBoxFiltro.Size = new System.Drawing.Size(207, 288);
            this.pcBoxFiltro.TabIndex = 1;
            this.pcBoxFiltro.TabStop = false;
            // 
            // BotonBusqueda
            // 
            this.BotonBusqueda.BackColor = System.Drawing.Color.Black;
            this.BotonBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBusqueda.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBusqueda.ForeColor = System.Drawing.Color.White;
            this.BotonBusqueda.Image = global::TpWinForm_Equipo9A.Properties.Resources.icons8_search_30;
            this.BotonBusqueda.Location = new System.Drawing.Point(420, 98);
            this.BotonBusqueda.Name = "BotonBusqueda";
            this.BotonBusqueda.Size = new System.Drawing.Size(139, 42);
            this.BotonBusqueda.TabIndex = 11;
            this.BotonBusqueda.Text = "Buscar ";
            this.BotonBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonBusqueda.UseVisualStyleBackColor = false;
            this.BotonBusqueda.Click += new System.EventHandler(this.BotonBusqueda_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 557);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.PanelResultadoBusq);
            this.Controls.Add(this.BotonBusqueda);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscar";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelResultadoBusq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFitro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button BotonBusqueda;
        private System.Windows.Forms.Panel PanelResultadoBusq;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dataGridViewFitro;
        private System.Windows.Forms.PictureBox pcBoxFiltro;
    }
}