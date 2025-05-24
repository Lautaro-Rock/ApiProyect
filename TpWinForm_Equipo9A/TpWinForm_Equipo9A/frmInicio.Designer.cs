namespace TpWinForm_Equipo9A
{
    partial class titlePrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.subtitleLabel2 = new System.Windows.Forms.Label();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.containerDevelopers = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.containerDevelopers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(148, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al gestor de articulos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // subtitleLabel2
            // 
            this.subtitleLabel2.AutoSize = true;
            this.subtitleLabel2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subtitleLabel2.Location = new System.Drawing.Point(233, 159);
            this.subtitleLabel2.Name = "subtitleLabel2";
            this.subtitleLabel2.Size = new System.Drawing.Size(377, 30);
            this.subtitleLabel2.TabIndex = 1;
            this.subtitleLabel2.Text = "UTN ArtManager Products";
           
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.BackColor = System.Drawing.Color.White;
            this.buttonContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContinuar.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinuar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonContinuar.Location = new System.Drawing.Point(251, 245);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(328, 49);
            this.buttonContinuar.TabIndex = 2;
            this.buttonContinuar.Text = "Continuar ";
            this.buttonContinuar.UseVisualStyleBackColor = false;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // containerDevelopers
            // 
            this.containerDevelopers.Controls.Add(this.label4);
            this.containerDevelopers.Controls.Add(this.label3);
            this.containerDevelopers.Controls.Add(this.label2);
            this.containerDevelopers.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerDevelopers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.containerDevelopers.Location = new System.Drawing.Point(12, 347);
            this.containerDevelopers.Name = "containerDevelopers";
            this.containerDevelopers.Size = new System.Drawing.Size(776, 84);
            this.containerDevelopers.TabIndex = 3;
            this.containerDevelopers.TabStop = false;
            this.containerDevelopers.Text = "Desarolladores";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(581, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Joaquin Sanchez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(302, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lautaro Maldonado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marcos Colombres";
           
            // 
            // titlePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.containerDevelopers);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.subtitleLabel2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "titlePrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.containerDevelopers.ResumeLayout(false);
            this.containerDevelopers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subtitleLabel2;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.GroupBox containerDevelopers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

