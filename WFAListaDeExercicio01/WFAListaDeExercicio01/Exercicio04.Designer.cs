namespace WFAListaDeExercicio01
{
    partial class Exercicio04
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
            this.LABELTABUADA = new System.Windows.Forms.Label();
            this.LABELNUMERO = new System.Windows.Forms.Label();
            this.TXTNUMERO = new System.Windows.Forms.TextBox();
            this.TXTRESULTADO = new System.Windows.Forms.TextBox();
            this.LABELRESULTADO = new System.Windows.Forms.Label();
            this.BTNCHECAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LABELTABUADA
            // 
            this.LABELTABUADA.AutoSize = true;
            this.LABELTABUADA.Font = new System.Drawing.Font("Square721 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELTABUADA.Location = new System.Drawing.Point(12, 9);
            this.LABELTABUADA.Name = "LABELTABUADA";
            this.LABELTABUADA.Size = new System.Drawing.Size(145, 29);
            this.LABELTABUADA.TabIndex = 0;
            this.LABELTABUADA.Text = "TABUADA:";
            // 
            // LABELNUMERO
            // 
            this.LABELNUMERO.AutoSize = true;
            this.LABELNUMERO.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELNUMERO.Location = new System.Drawing.Point(14, 38);
            this.LABELNUMERO.Name = "LABELNUMERO";
            this.LABELNUMERO.Size = new System.Drawing.Size(155, 16);
            this.LABELNUMERO.TabIndex = 1;
            this.LABELNUMERO.Text = "DIGITE UM NÚMERO:";
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Location = new System.Drawing.Point(17, 57);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(152, 20);
            this.TXTNUMERO.TabIndex = 2;
            // 
            // TXTRESULTADO
            // 
            this.TXTRESULTADO.Location = new System.Drawing.Point(17, 143);
            this.TXTRESULTADO.Multiline = true;
            this.TXTRESULTADO.Name = "TXTRESULTADO";
            this.TXTRESULTADO.Size = new System.Drawing.Size(224, 288);
            this.TXTRESULTADO.TabIndex = 3;
            // 
            // LABELRESULTADO
            // 
            this.LABELRESULTADO.AutoSize = true;
            this.LABELRESULTADO.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELRESULTADO.Location = new System.Drawing.Point(14, 124);
            this.LABELRESULTADO.Name = "LABELRESULTADO";
            this.LABELRESULTADO.Size = new System.Drawing.Size(129, 16);
            this.LABELRESULTADO.TabIndex = 4;
            this.LABELRESULTADO.Text = "SEU RESULTADO:";
            // 
            // BTNCHECAR
            // 
            this.BTNCHECAR.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCHECAR.Location = new System.Drawing.Point(17, 83);
            this.BTNCHECAR.Name = "BTNCHECAR";
            this.BTNCHECAR.Size = new System.Drawing.Size(187, 35);
            this.BTNCHECAR.TabIndex = 5;
            this.BTNCHECAR.Text = "FAZER A MULTIPLICAÇÃO";
            this.BTNCHECAR.UseVisualStyleBackColor = true;
            this.BTNCHECAR.Click += new System.EventHandler(this.BTNCHECAR_Click);
            // 
            // Exercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 443);
            this.Controls.Add(this.BTNCHECAR);
            this.Controls.Add(this.LABELRESULTADO);
            this.Controls.Add(this.TXTRESULTADO);
            this.Controls.Add(this.TXTNUMERO);
            this.Controls.Add(this.LABELNUMERO);
            this.Controls.Add(this.LABELTABUADA);
            this.Name = "Exercicio04";
            this.Text = "Exercicio04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABELTABUADA;
        private System.Windows.Forms.Label LABELNUMERO;
        private System.Windows.Forms.TextBox TXTNUMERO;
        private System.Windows.Forms.TextBox TXTRESULTADO;
        private System.Windows.Forms.Label LABELRESULTADO;
        private System.Windows.Forms.Button BTNCHECAR;
    }
}