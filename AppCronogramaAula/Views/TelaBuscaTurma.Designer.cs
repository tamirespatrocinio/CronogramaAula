
namespace AppCronogramaAula.Views
{
    partial class TelaBuscaTurma
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewNomeAluno = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBuscaNome = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataFim = new System.Windows.Forms.DateTimePicker();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.cbTarde = new System.Windows.Forms.CheckBox();
            this.cbNoite = new System.Windows.Forms.CheckBox();
            this.cbManha = new System.Windows.Forms.CheckBox();
            this.tbMostraCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbDigiteCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomeAluno)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(207, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerenciamento dos dados de Turmas";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(68, 116);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 272);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewNomeAluno);
            this.tabPage2.Controls.Add(this.btnPesquisarNome);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbBuscaNome);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(657, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Nome";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNomeAluno
            // 
            this.dataGridViewNomeAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNomeAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNomeAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewNomeAluno.Location = new System.Drawing.Point(6, 67);
            this.dataGridViewNomeAluno.Name = "dataGridViewNomeAluno";
            this.dataGridViewNomeAluno.RowTemplate.Height = 25;
            this.dataGridViewNomeAluno.Size = new System.Drawing.Size(645, 171);
            this.dataGridViewNomeAluno.TabIndex = 3;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DataInicio";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DataFim";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Periodo";
            this.Column4.Name = "Column4";
            // 
            // btnPesquisarNome
            // 
            this.btnPesquisarNome.Location = new System.Drawing.Point(351, 20);
            this.btnPesquisarNome.Name = "btnPesquisarNome";
            this.btnPesquisarNome.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarNome.TabIndex = 2;
            this.btnPesquisarNome.Text = "Pesquisar";
            this.btnPesquisarNome.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Digite o Nome da Turma:";
            // 
            // tbBuscaNome
            // 
            this.tbBuscaNome.Location = new System.Drawing.Point(177, 20);
            this.tbBuscaNome.Name = "tbBuscaNome";
            this.tbBuscaNome.Size = new System.Drawing.Size(159, 23);
            this.tbBuscaNome.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataFim);
            this.tabPage1.Controls.Add(this.dataInicio);
            this.tabPage1.Controls.Add(this.cbTarde);
            this.tabPage1.Controls.Add(this.cbNoite);
            this.tabPage1.Controls.Add(this.cbManha);
            this.tabPage1.Controls.Add(this.tbMostraCodigo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnAlterar);
            this.tabPage1.Controls.Add(this.btnApagar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnPesquisar);
            this.tabPage1.Controls.Add(this.tbDigiteCodigo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(657, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataFim
            // 
            this.dataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFim.Location = new System.Drawing.Point(133, 147);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(91, 23);
            this.dataFim.TabIndex = 17;
            // 
            // dataInicio
            // 
            this.dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicio.Location = new System.Drawing.Point(167, 106);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(91, 23);
            this.dataInicio.TabIndex = 16;
            // 
            // cbTarde
            // 
            this.cbTarde.AutoSize = true;
            this.cbTarde.Location = new System.Drawing.Point(202, 188);
            this.cbTarde.Name = "cbTarde";
            this.cbTarde.Size = new System.Drawing.Size(54, 19);
            this.cbTarde.TabIndex = 15;
            this.cbTarde.Text = "Tarde";
            this.cbTarde.UseVisualStyleBackColor = true;
            // 
            // cbNoite
            // 
            this.cbNoite.AutoSize = true;
            this.cbNoite.Location = new System.Drawing.Point(262, 188);
            this.cbNoite.Name = "cbNoite";
            this.cbNoite.Size = new System.Drawing.Size(55, 19);
            this.cbNoite.TabIndex = 14;
            this.cbNoite.Text = "Noite";
            this.cbNoite.UseVisualStyleBackColor = true;
            // 
            // cbManha
            // 
            this.cbManha.AutoSize = true;
            this.cbManha.Location = new System.Drawing.Point(133, 188);
            this.cbManha.Name = "cbManha";
            this.cbManha.Size = new System.Drawing.Size(63, 19);
            this.cbManha.TabIndex = 13;
            this.cbManha.Text = "Manhã";
            this.cbManha.UseVisualStyleBackColor = true;
            // 
            // tbMostraCodigo
            // 
            this.tbMostraCodigo.Location = new System.Drawing.Point(123, 67);
            this.tbMostraCodigo.Name = "tbMostraCodigo";
            this.tbMostraCodigo.ReadOnly = true;
            this.tbMostraCodigo.Size = new System.Drawing.Size(77, 23);
            this.tbMostraCodigo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(55, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Código:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(431, 215);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(350, 215);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 9;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(55, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Período:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(55, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Fim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Início:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(281, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // tbDigiteCodigo
            // 
            this.tbDigiteCodigo.Location = new System.Drawing.Point(123, 27);
            this.tbDigiteCodigo.Name = "tbDigiteCodigo";
            this.tbDigiteCodigo.Size = new System.Drawing.Size(137, 23);
            this.tbDigiteCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o Código:";
            // 
            // TelaBuscaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaBuscaTurma";
            this.Text = "TelaBuscaTurma";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomeAluno)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewNomeAluno;
        private System.Windows.Forms.Button btnPesquisarNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBuscaNome;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbMostraCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox tbDigiteCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker dataFim;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.CheckBox cbTarde;
        private System.Windows.Forms.CheckBox cbNoite;
        private System.Windows.Forms.CheckBox cbManha;
    }
}