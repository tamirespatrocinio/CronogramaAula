
namespace CronogramaAula.Views
{
    partial class TelaCadProf
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomeProf = new System.Windows.Forms.TextBox();
            this.tbFoneProf = new System.Windows.Forms.TextBox();
            this.tbEmailProf = new System.Windows.Forms.TextBox();
            this.btnCadProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Professores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fone:";
            // 
            // tbNomeProf
            // 
            this.tbNomeProf.Location = new System.Drawing.Point(138, 106);
            this.tbNomeProf.Name = "tbNomeProf";
            this.tbNomeProf.Size = new System.Drawing.Size(304, 23);
            this.tbNomeProf.TabIndex = 4;
            // 
            // tbFoneProf
            // 
            this.tbFoneProf.Location = new System.Drawing.Point(138, 178);
            this.tbFoneProf.Name = "tbFoneProf";
            this.tbFoneProf.Size = new System.Drawing.Size(185, 23);
            this.tbFoneProf.TabIndex = 5;
            // 
            // tbEmailProf
            // 
            this.tbEmailProf.Location = new System.Drawing.Point(138, 143);
            this.tbEmailProf.Name = "tbEmailProf";
            this.tbEmailProf.Size = new System.Drawing.Size(304, 23);
            this.tbEmailProf.TabIndex = 6;
            // 
            // btnCadProf
            // 
            this.btnCadProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadProf.Location = new System.Drawing.Point(303, 262);
            this.btnCadProf.Name = "btnCadProf";
            this.btnCadProf.Size = new System.Drawing.Size(170, 33);
            this.btnCadProf.TabIndex = 7;
            this.btnCadProf.Text = "Cadastrar";
            this.btnCadProf.UseVisualStyleBackColor = true;
            // 
            // TelaCadProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(507, 324);
            this.Controls.Add(this.btnCadProf);
            this.Controls.Add(this.tbEmailProf);
            this.Controls.Add(this.tbFoneProf);
            this.Controls.Add(this.tbNomeProf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TelaCadProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cronograma de Aulas ::::  Cadastro de Professor.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNomeProf;
        private System.Windows.Forms.TextBox tbFoneProf;
        private System.Windows.Forms.TextBox tbEmailProf;
        private System.Windows.Forms.Button btnCadProf;
    }
}