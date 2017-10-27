namespace InputData
{
    partial class InputDatas
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
            this.txtVencimento = new System.Windows.Forms.TextBox();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.txtFabricacao = new System.Windows.Forms.TextBox();
            this.lblFabricacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVencimento
            // 
            this.txtVencimento.Location = new System.Drawing.Point(147, 47);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(95, 20);
            this.txtVencimento.TabIndex = 17;
            this.txtVencimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVencimento_KeyPress);
            // 
            // lblVencimento
            // 
            this.lblVencimento.Location = new System.Drawing.Point(147, 24);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(95, 20);
            this.lblVencimento.TabIndex = 18;
            this.lblVencimento.Text = "Vencimento";
            // 
            // txtFabricacao
            // 
            this.txtFabricacao.Location = new System.Drawing.Point(43, 47);
            this.txtFabricacao.Name = "txtFabricacao";
            this.txtFabricacao.Size = new System.Drawing.Size(93, 20);
            this.txtFabricacao.TabIndex = 16;
            this.txtFabricacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFabricacao_KeyPress);
            // 
            // lblFabricacao
            // 
            this.lblFabricacao.Location = new System.Drawing.Point(43, 24);
            this.lblFabricacao.Name = "lblFabricacao";
            this.lblFabricacao.Size = new System.Drawing.Size(95, 20);
            this.lblFabricacao.TabIndex = 19;
            this.lblFabricacao.Text = "Fabricação";
            // 
            // InputDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 90);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.lblVencimento);
            this.Controls.Add(this.txtFabricacao);
            this.Controls.Add(this.lblFabricacao);
            this.Name = "InputDatas";
            this.Text = "InputDatas";
            this.Load += new System.EventHandler(this.InputDatas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVencimento;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.TextBox txtFabricacao;
        private System.Windows.Forms.Label lblFabricacao;
    }
}

