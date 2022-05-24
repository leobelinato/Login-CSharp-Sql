namespace Projeto1
{
    partial class Certeza
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
            this.btnsim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsim
            // 
            this.btnsim.BackColor = System.Drawing.Color.LightGreen;
            this.btnsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsim.Location = new System.Drawing.Point(52, 69);
            this.btnsim.Name = "btnsim";
            this.btnsim.Size = new System.Drawing.Size(81, 38);
            this.btnsim.TabIndex = 0;
            this.btnsim.Text = "Sim";
            this.btnsim.UseVisualStyleBackColor = false;
            this.btnsim.Click += new System.EventHandler(this.btnsim_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deseja mesmo sair?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnnao
            // 
            this.btnnao.BackColor = System.Drawing.Color.Salmon;
            this.btnnao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnao.Location = new System.Drawing.Point(157, 69);
            this.btnnao.Name = "btnnao";
            this.btnnao.Size = new System.Drawing.Size(78, 38);
            this.btnnao.TabIndex = 1;
            this.btnnao.Text = "Não";
            this.btnnao.UseVisualStyleBackColor = false;
            this.btnnao.Click += new System.EventHandler(this.btnnao_Click);
            // 
            // Certeza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 126);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnao);
            this.Controls.Add(this.btnsim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Certeza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deseja sair?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnao;
    }
}