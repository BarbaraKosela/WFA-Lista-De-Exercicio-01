namespace WFAListaDeExercicio01
{
    partial class Exercicio09
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio09));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTNUMERO1 = new System.Windows.Forms.TextBox();
            this.TXTNUMERO2 = new System.Windows.Forms.TextBox();
            this.BTNCHECAR = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE DOIS NÚMEROS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(264, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "SEGUNDO NÚMERO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "PRIMEIRO NÚMERO:";
            // 
            // TXTNUMERO1
            // 
            this.TXTNUMERO1.Location = new System.Drawing.Point(12, 73);
            this.TXTNUMERO1.Name = "TXTNUMERO1";
            this.TXTNUMERO1.Size = new System.Drawing.Size(217, 20);
            this.TXTNUMERO1.TabIndex = 2;
            // 
            // TXTNUMERO2
            // 
            this.TXTNUMERO2.Location = new System.Drawing.Point(266, 73);
            this.TXTNUMERO2.Name = "TXTNUMERO2";
            this.TXTNUMERO2.Size = new System.Drawing.Size(213, 20);
            this.TXTNUMERO2.TabIndex = 3;
            // 
            // BTNCHECAR
            // 
            this.BTNCHECAR.BackColor = System.Drawing.Color.Navy;
            this.BTNCHECAR.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCHECAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCHECAR.Location = new System.Drawing.Point(135, 109);
            this.BTNCHECAR.Name = "BTNCHECAR";
            this.BTNCHECAR.Size = new System.Drawing.Size(233, 67);
            this.BTNCHECAR.TabIndex = 4;
            this.BTNCHECAR.Text = "CHECAR RESULTADO";
            this.BTNCHECAR.UseVisualStyleBackColor = false;
            this.BTNCHECAR.Click += new System.EventHandler(this.BTNCHECAR_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(12, 192);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(467, 55);
            this.txtresultado.TabIndex = 5;
            // 
            // Exercicio09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(491, 259);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.BTNCHECAR);
            this.Controls.Add(this.TXTNUMERO2);
            this.Controls.Add(this.TXTNUMERO1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio09";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio09";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTNUMERO1;
        private System.Windows.Forms.TextBox TXTNUMERO2;
        private System.Windows.Forms.Button BTNCHECAR;
        private System.Windows.Forms.TextBox txtresultado;
    }
}