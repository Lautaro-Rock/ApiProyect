namespace TpWinForm_Equipo9A
{
    partial class frmImagen
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.newAceptar = new System.Windows.Forms.Button();
            this.newCancelar = new System.Windows.Forms.Button();
            this.pboImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(132, 51);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Imagen";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.Location = new System.Drawing.Point(75, 169);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(94, 18);
            this.lblUrlImagen.TabIndex = 1;
            this.lblUrlImagen.Text = "Url Imagen";
            
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(175, 170);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(166, 20);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // newAceptar
            // 
            this.newAceptar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAceptar.Location = new System.Drawing.Point(109, 276);
            this.newAceptar.Name = "newAceptar";
            this.newAceptar.Size = new System.Drawing.Size(232, 40);
            this.newAceptar.TabIndex = 5;
            this.newAceptar.Text = "Agregar Imagen";
            this.newAceptar.UseVisualStyleBackColor = true;
            this.newAceptar.Click += new System.EventHandler(this.newAceptar_Click);
            // 
            // newCancelar
            // 
            this.newCancelar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCancelar.Location = new System.Drawing.Point(147, 346);
            this.newCancelar.Name = "newCancelar";
            this.newCancelar.Size = new System.Drawing.Size(134, 40);
            this.newCancelar.TabIndex = 6;
            this.newCancelar.Text = "Salir";
            this.newCancelar.UseVisualStyleBackColor = true;
            this.newCancelar.Click += new System.EventHandler(this.newCancelar_Click);
            // 
            // pboImagen
            // 
            this.pboImagen.Location = new System.Drawing.Point(382, 51);
            this.pboImagen.Name = "pboImagen";
            this.pboImagen.Size = new System.Drawing.Size(442, 350);
            this.pboImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboImagen.TabIndex = 7;
            this.pboImagen.TabStop = false;
            // 
            // frmImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.pboImagen);
            this.Controls.Add(this.newCancelar);
            this.Controls.Add(this.newAceptar);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Imagen";
            ((System.ComponentModel.ISupportInitialize)(this.pboImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button newAceptar;
        private System.Windows.Forms.Button newCancelar;
        private System.Windows.Forms.PictureBox pboImagen;
    }
}