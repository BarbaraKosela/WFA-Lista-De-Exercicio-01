namespace WFAListaDeExercicio01
{
    partial class FORMEXERCICIO01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMEXERCICIO01));
            this.LABELDIGITARNUMERO = new System.Windows.Forms.Label();
            this.TXTNUMERO = new System.Windows.Forms.TextBox();
            this.RBSUCESSOR = new System.Windows.Forms.RadioButton();
            this.RBANTECESSOR = new System.Windows.Forms.RadioButton();
            this.BTNRESPOSTA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LABELDIGITARNUMERO
            // 
            this.LABELDIGITARNUMERO.AutoSize = true;
            this.LABELDIGITARNUMERO.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LABELDIGITARNUMERO.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELDIGITARNUMERO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LABELDIGITARNUMERO.Location = new System.Drawing.Point(9, 9);
            this.LABELDIGITARNUMERO.Name = "LABELDIGITARNUMERO";
            this.LABELDIGITARNUMERO.Size = new System.Drawing.Size(160, 16);
            this.LABELDIGITARNUMERO.TabIndex = 0;
            this.LABELDIGITARNUMERO.Text = "DIGITE UM NÚMERO: ";
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Location = new System.Drawing.Point(15, 28);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(148, 20);
            this.TXTNUMERO.TabIndex = 1;
            // 
            // RBSUCESSOR
            // 
            this.RBSUCESSOR.AutoSize = true;
            this.RBSUCESSOR.BackColor = System.Drawing.Color.LightSeaGreen;
            this.RBSUCESSOR.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBSUCESSOR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBSUCESSOR.Location = new System.Drawing.Point(12, 66);
            this.RBSUCESSOR.Name = "RBSUCESSOR";
            this.RBSUCESSOR.Size = new System.Drawing.Size(117, 24);
            this.RBSUCESSOR.TabIndex = 2;
            this.RBSUCESSOR.TabStop = true;
            this.RBSUCESSOR.Text = "SUCESSOR";
            this.RBSUCESSOR.UseVisualStyleBackColor = false;
            this.RBSUCESSOR.CheckedChanged += new System.EventHandler(this.RBSUCESSOR_CheckedChanged);
            // 
            // RBANTECESSOR
            // 
            this.RBANTECESSOR.AutoSize = true;
            this.RBANTECESSOR.BackColor = System.Drawing.Color.LightSeaGreen;
            this.RBANTECESSOR.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBANTECESSOR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBANTECESSOR.Location = new System.Drawing.Point(12, 96);
            this.RBANTECESSOR.Name = "RBANTECESSOR";
            this.RBANTECESSOR.Size = new System.Drawing.Size(141, 24);
            this.RBANTECESSOR.TabIndex = 3;
            this.RBANTECESSOR.TabStop = true;
            this.RBANTECESSOR.Text = "ANTECESSOR";
            this.RBANTECESSOR.UseVisualStyleBackColor = false;
            // 
            // BTNRESPOSTA
            // 
            this.BTNRESPOSTA.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BTNRESPOSTA.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRESPOSTA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNRESPOSTA.Location = new System.Drawing.Point(15, 135);
            this.BTNRESPOSTA.Name = "BTNRESPOSTA";
            this.BTNRESPOSTA.Size = new System.Drawing.Size(129, 34);
            this.BTNRESPOSTA.TabIndex = 4;
            this.BTNRESPOSTA.Text = "GERAR RESPOSTA";
            this.BTNRESPOSTA.UseVisualStyleBackColor = false;
            this.BTNRESPOSTA.Click += new System.EventHandler(this.BTNRESPOSTA_Click);
            // 
            // FORMEXERCICIO01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(173, 190);
            this.Controls.Add(this.BTNRESPOSTA);
            this.Controls.Add(this.RBANTECESSOR);
            this.Controls.Add(this.RBSUCESSOR);
            this.Controls.Add(this.TXTNUMERO);
            this.Controls.Add(this.LABELDIGITARNUMERO);
            this.Name = "FORMEXERCICIO01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABELDIGITARNUMERO;
        private System.Windows.Forms.TextBox TXTNUMERO;
        private System.Windows.Forms.RadioButton RBSUCESSOR;
        private System.Windows.Forms.RadioButton RBANTECESSOR;
        private System.Windows.Forms.Button BTNRESPOSTA;
    }
}

