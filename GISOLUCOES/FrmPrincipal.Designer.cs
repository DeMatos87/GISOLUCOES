
namespace GISOLUCOES
{
    partial class FrmPrincipal
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
            this.btn_Adcionar_Cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Adicionar_Usuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Adcionar_Cliente
            // 
            this.btn_Adcionar_Cliente.Location = new System.Drawing.Point(44, 90);
            this.btn_Adcionar_Cliente.Name = "btn_Adcionar_Cliente";
            this.btn_Adcionar_Cliente.Size = new System.Drawing.Size(101, 54);
            this.btn_Adcionar_Cliente.TabIndex = 0;
            this.btn_Adcionar_Cliente.Text = "Adicionar";
            this.btn_Adcionar_Cliente.UseVisualStyleBackColor = true;
            this.btn_Adcionar_Cliente.Click += new System.EventHandler(this.btn_Adcionar_Cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadastro de Usuário";
            // 
            // btn_Adicionar_Usuario
            // 
            this.btn_Adicionar_Usuario.Location = new System.Drawing.Point(284, 90);
            this.btn_Adicionar_Usuario.Name = "btn_Adicionar_Usuario";
            this.btn_Adicionar_Usuario.Size = new System.Drawing.Size(101, 54);
            this.btn_Adicionar_Usuario.TabIndex = 2;
            this.btn_Adicionar_Usuario.Text = "Adicionar";
            this.btn_Adicionar_Usuario.UseVisualStyleBackColor = true;
            this.btn_Adicionar_Usuario.Click += new System.EventHandler(this.btn_Adicionar_Usuario_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(439, 217);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Adicionar_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Adcionar_Cliente);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GI SOLUÇÕES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Adcionar_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Adicionar_Usuario;
    }
}

