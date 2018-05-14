namespace WFAListaDeExercicio01
{
    partial class Exercicio10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio10));
            this.label1 = new System.Windows.Forms.Label();
            this.TXTDATA = new System.Windows.Forms.TextBox();
            this.BTNCHECAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE A DATA DE NASCIMENTO:";
            // 
            // TXTDATA
            // 
            this.TXTDATA.Location = new System.Drawing.Point(26, 53);
            this.TXTDATA.Name = "TXTDATA";
            this.TXTDATA.Size = new System.Drawing.Size(254, 20);
            this.TXTDATA.TabIndex = 1;
            // 
            // BTNCHECAR
            // 
            this.BTNCHECAR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNCHECAR.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCHECAR.Location = new System.Drawing.Point(79, 92);
            this.BTNCHECAR.Name = "BTNCHECAR";
            this.BTNCHECAR.Size = new System.Drawing.Size(156, 45);
            this.BTNCHECAR.TabIndex = 2;
            this.BTNCHECAR.Text = "CHECAR";
            this.BTNCHECAR.UseVisualStyleBackColor = false;
            this.BTNCHECAR.Click += new System.EventHandler(this.BTNCHECAR_Click);
            // 
            // Exercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(310, 147);
            this.Controls.Add(this.BTNCHECAR);
            this.Controls.Add(this.TXTDATA);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTDATA;
        private System.Windows.Forms.Button BTNCHECAR;
    }
}