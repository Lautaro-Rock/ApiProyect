namespace TpWinForm_Equipo9A
{
    partial class frmMarcaAgregar
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
            this.newCancelar = new System.Windows.Forms.Button();
            this.newAceptar = new System.Windows.Forms.Button();
            this.inputDescripcion = new System.Windows.Forms.TextBox();
            this.TextDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newCancelar
            // 
            this.newCancelar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCancelar.Location = new System.Drawing.Point(339, 346);
            this.newCancelar.Name = "newCancelar";
            this.newCancelar.Size = new System.Drawing.Size(134, 40);
            this.newCancelar.TabIndex = 13;
            this.newCancelar.Text = "Salir";
            this.newCancelar.UseVisualStyleBackColor = true;
            this.newCancelar.Click += new System.EventHandler(this.newCancelar_Click);
            // 
            // newAceptar
            // 
            this.newAceptar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAceptar.Location = new System.Drawing.Point(284, 277);
            this.newAceptar.Name = "newAceptar";
            this.newAceptar.Size = new System.Drawing.Size(232, 40);
            this.newAceptar.TabIndex = 12;
            this.newAceptar.Text = "Continuar";
            this.newAceptar.UseVisualStyleBackColor = true;
            this.newAceptar.Click += new System.EventHandler(this.newAceptar_Click);
            // 
            // inputDescripcion
            // 
            this.inputDescripcion.Location = new System.Drawing.Point(340, 194);
            this.inputDescripcion.Name = "inputDescripcion";
            this.inputDescripcion.Size = new System.Drawing.Size(146, 20);
            this.inputDescripcion.TabIndex = 11;
            // 
            // TextDescripcion
            // 
            this.TextDescripcion.AutoSize = true;
            this.TextDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDescripcion.Location = new System.Drawing.Point(225, 193);
            this.TextDescripcion.Name = "TextDescripcion";
            this.TextDescripcion.Size = new System.Drawing.Size(109, 18);
            this.TextDescripcion.TabIndex = 10;
            this.TextDescripcion.Text = "Descripcion:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(335, 82);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(94, 27);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Marcas";
            // 
            // frmMarcaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newCancelar);
            this.Controls.Add(this.newAceptar);
            this.Controls.Add(this.inputDescripcion);
            this.Controls.Add(this.TextDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmMarcaAgregar";
            this.Text = "frmMarcaAgregar";
            this.Load += new System.EventHandler(this.frmMarcaAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newCancelar;
        private System.Windows.Forms.Button newAceptar;
        private System.Windows.Forms.TextBox inputDescripcion;
        private System.Windows.Forms.Label TextDescripcion;
        private System.Windows.Forms.Label lblTitulo;
    }
}