
namespace CronogramaAula
{
    partial class TelaCadUc
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
            this.tbNumUc = new System.Windows.Forms.TextBox();
            this.tbDescUc = new System.Windows.Forms.RichTextBox();
            this.btnCadUc = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Unidade Curricular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidade Curricular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de aulas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(72, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // tbNumUc
            // 
            this.tbNumUc.Location = new System.Drawing.Point(248, 228);
            this.tbNumUc.Name = "tbNumUc";
            this.tbNumUc.Size = new System.Drawing.Size(61, 23);
            this.tbNumUc.TabIndex = 6;
            // 
            // tbDescUc
            // 
            this.tbDescUc.Location = new System.Drawing.Point(182, 126);
            this.tbDescUc.Name = "tbDescUc";
            this.tbDescUc.Size = new System.Drawing.Size(225, 81);
            this.tbDescUc.TabIndex = 7;
            this.tbDescUc.Text = "";
            // 
            // btnCadUc
            // 
            this.btnCadUc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadUc.Location = new System.Drawing.Point(306, 276);
            this.btnCadUc.Name = "btnCadUc";
            this.btnCadUc.Size = new System.Drawing.Size(189, 36);
            this.btnCadUc.TabIndex = 8;
            this.btnCadUc.Text = "Cadastrar";
            this.btnCadUc.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UC 01",
            "UC 02",
            "UC 03",
            "UC 04",
            "UC 05",
            "UC 06",
            "UC 07",
            "UC 08",
            "UC 09",
            "UC 10",
            "UC 11",
            "UC 12",
            "UC 13",
            "UC 14",
            "UC 15",
            "UC 16"});
            this.comboBox1.Location = new System.Drawing.Point(269, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // TelaCadUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(507, 324);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCadUc);
            this.Controls.Add(this.tbDescUc);
            this.Controls.Add(this.tbNumUc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TelaCadUc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cronograma de Aulas ::::  Cadastro de U C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumUc;
        private System.Windows.Forms.RichTextBox tbDescUc;
        private System.Windows.Forms.Button btnCadUc;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}