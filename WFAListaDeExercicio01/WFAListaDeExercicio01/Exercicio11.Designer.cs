namespace WFAListaDeExercicio01
{
    partial class Exercicio11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio11));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTDIA = new System.Windows.Forms.TextBox();
            this.TXTMES = new System.Windows.Forms.TextBox();
            this.TXTANO = new System.Windows.Forms.TextBox();
            this.TXTRESULTADO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE O DIA DO SEU NASCIMENTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIGITE O MÊS DO SEU NASCIMENTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "DIGITE O ANO DO SEU NASCIMENTO:";
            // 
            // TXTDIA
            // 
            this.TXTDIA.Location = new System.Drawing.Point(12, 39);
            this.TXTDIA.Name = "TXTDIA";
            this.TXTDIA.Size = new System.Drawing.Size(263, 20);
            this.TXTDIA.TabIndex = 4;
            // 
            // TXTMES
            // 
            this.TXTMES.Location = new System.Drawing.Point(12, 109);
            this.TXTMES.Name = "TXTMES";
            this.TXTMES.Size = new System.Drawing.Size(263, 20);
            this.TXTMES.TabIndex = 5;
            // 
            // TXTANO
            // 
            this.TXTANO.Location = new System.Drawing.Point(12, 177);
            this.TXTANO.Name = "TXTANO";
            this.TXTANO.Size = new System.Drawing.Size(263, 20);
            this.TXTANO.TabIndex = 6;
            // 
            // TXTRESULTADO
            // 
            this.TXTRESULTADO.Location = new System.Drawing.Point(294, 9);
            this.TXTRESULTADO.Multiline = true;
            this.TXTRESULTADO.Name = "TXTRESULTADO";
            this.TXTRESULTADO.Size = new System.Drawing.Size(195, 227);
            this.TXTRESULTADO.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "CHECAR RESULTADO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(501, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXTRESULTADO);
            this.Controls.Add(this.TXTANO);
            this.Controls.Add(this.TXTMES);
            this.Controls.Add(this.TXTDIA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTDIA;
        private System.Windows.Forms.TextBox TXTMES;
        private System.Windows.Forms.TextBox TXTANO;
        private System.Windows.Forms.TextBox TXTRESULTADO;
        private System.Windows.Forms.Button button1;
    }
}