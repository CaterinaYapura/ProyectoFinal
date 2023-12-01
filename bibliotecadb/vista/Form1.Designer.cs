namespace bibliotecadb
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuser = new System.Windows.Forms.Button();
            this.btnYuser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(87, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Eres un lector nuevo?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // btnNuser
            // 
            this.btnNuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNuser.Location = new System.Drawing.Point(12, 90);
            this.btnNuser.Name = "btnNuser";
            this.btnNuser.Size = new System.Drawing.Size(117, 24);
            this.btnNuser.TabIndex = 3;
            this.btnNuser.Text = "Si, crea tu usuario";
            this.btnNuser.UseVisualStyleBackColor = true;
            this.btnNuser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnYuser
            // 
            this.btnYuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnYuser.Location = new System.Drawing.Point(239, 90);
            this.btnYuser.Name = "btnYuser";
            this.btnYuser.Size = new System.Drawing.Size(117, 24);
            this.btnYuser.TabIndex = 4;
            this.btnYuser.Text = "No, ya tengo cuenta";
            this.btnYuser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 199);
            this.Controls.Add(this.btnYuser);
            this.Controls.Add(this.btnNuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuser;
        private System.Windows.Forms.Button btnYuser;
    }
}

