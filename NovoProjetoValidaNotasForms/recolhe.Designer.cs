namespace NovoProjetoValidaNotasForms
{
    partial class frm_validaNot
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
            this.pnl_media = new System.Windows.Forms.Panel();
            this.bnt_confirmaMedia = new System.Windows.Forms.Button();
            this.txt_numMedia = new System.Windows.Forms.TextBox();
            this.txt_numAluno = new System.Windows.Forms.TextBox();
            this.lbl_numMedia = new System.Windows.Forms.Label();
            this.lbl_numAluno = new System.Windows.Forms.Label();
            this.pnl_nomeAluno = new System.Windows.Forms.Panel();
            this.btn_confirmaNome = new System.Windows.Forms.Button();
            this.txt_nomeAluno = new System.Windows.Forms.TextBox();
            this.lbl_nomeAluno = new System.Windows.Forms.Label();
            this.pnl_notaMateria = new System.Windows.Forms.Panel();
            this.txt_notaIng = new System.Windows.Forms.TextBox();
            this.txt_notaArt = new System.Windows.Forms.TextBox();
            this.txt_notaHis = new System.Windows.Forms.TextBox();
            this.txt_notaFis = new System.Windows.Forms.TextBox();
            this.txt_notaPor = new System.Windows.Forms.TextBox();
            this.txt_notaMat = new System.Windows.Forms.TextBox();
            this.bnt_confirmaNota = new System.Windows.Forms.Button();
            this.lbl_Ingles = new System.Windows.Forms.Label();
            this.lbl_art = new System.Windows.Forms.Label();
            this.lbl_his = new System.Windows.Forms.Label();
            this.lbl_fis = new System.Windows.Forms.Label();
            this.lbl_por = new System.Windows.Forms.Label();
            this.lbl_mat = new System.Windows.Forms.Label();
            this.pnl_resultado = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_mostraResul = new System.Windows.Forms.Button();
            this.btn_boletim = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.pnl_media.SuspendLayout();
            this.pnl_nomeAluno.SuspendLayout();
            this.pnl_notaMateria.SuspendLayout();
            this.pnl_resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_media
            // 
            this.pnl_media.Controls.Add(this.bnt_confirmaMedia);
            this.pnl_media.Controls.Add(this.txt_numMedia);
            this.pnl_media.Controls.Add(this.txt_numAluno);
            this.pnl_media.Controls.Add(this.lbl_numMedia);
            this.pnl_media.Controls.Add(this.lbl_numAluno);
            this.pnl_media.Location = new System.Drawing.Point(0, 1);
            this.pnl_media.Name = "pnl_media";
            this.pnl_media.Size = new System.Drawing.Size(266, 173);
            this.pnl_media.TabIndex = 0;
            // 
            // bnt_confirmaMedia
            // 
            this.bnt_confirmaMedia.Location = new System.Drawing.Point(188, 147);
            this.bnt_confirmaMedia.Name = "bnt_confirmaMedia";
            this.bnt_confirmaMedia.Size = new System.Drawing.Size(75, 23);
            this.bnt_confirmaMedia.TabIndex = 3;
            this.bnt_confirmaMedia.Text = "OK";
            this.bnt_confirmaMedia.UseVisualStyleBackColor = true;
            this.bnt_confirmaMedia.Click += new System.EventHandler(this.bnt_confirmaMedia_Click);
            // 
            // txt_numMedia
            // 
            this.txt_numMedia.Location = new System.Drawing.Point(7, 93);
            this.txt_numMedia.Name = "txt_numMedia";
            this.txt_numMedia.Size = new System.Drawing.Size(100, 22);
            this.txt_numMedia.TabIndex = 2;
            // 
            // txt_numAluno
            // 
            this.txt_numAluno.Location = new System.Drawing.Point(7, 31);
            this.txt_numAluno.Name = "txt_numAluno";
            this.txt_numAluno.Size = new System.Drawing.Size(100, 22);
            this.txt_numAluno.TabIndex = 1;
            // 
            // lbl_numMedia
            // 
            this.lbl_numMedia.AutoSize = true;
            this.lbl_numMedia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numMedia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_numMedia.Location = new System.Drawing.Point(3, 70);
            this.lbl_numMedia.Name = "lbl_numMedia";
            this.lbl_numMedia.Size = new System.Drawing.Size(250, 20);
            this.lbl_numMedia.TabIndex = 1;
            this.lbl_numMedia.Text = "Qual será a divisão das notas ? ";
            // 
            // lbl_numAluno
            // 
            this.lbl_numAluno.AutoSize = true;
            this.lbl_numAluno.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_numAluno.Location = new System.Drawing.Point(3, 8);
            this.lbl_numAluno.Name = "lbl_numAluno";
            this.lbl_numAluno.Size = new System.Drawing.Size(261, 20);
            this.lbl_numAluno.TabIndex = 0;
            this.lbl_numAluno.Text = "Quantos alunos serão inscritos ? ";
            // 
            // pnl_nomeAluno
            // 
            this.pnl_nomeAluno.Controls.Add(this.btn_confirmaNome);
            this.pnl_nomeAluno.Controls.Add(this.txt_nomeAluno);
            this.pnl_nomeAluno.Controls.Add(this.lbl_nomeAluno);
            this.pnl_nomeAluno.Location = new System.Drawing.Point(272, 1);
            this.pnl_nomeAluno.Name = "pnl_nomeAluno";
            this.pnl_nomeAluno.Size = new System.Drawing.Size(586, 173);
            this.pnl_nomeAluno.TabIndex = 1;
            // 
            // btn_confirmaNome
            // 
            this.btn_confirmaNome.Location = new System.Drawing.Point(508, 147);
            this.btn_confirmaNome.Name = "btn_confirmaNome";
            this.btn_confirmaNome.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmaNome.TabIndex = 5;
            this.btn_confirmaNome.Text = "OK";
            this.btn_confirmaNome.UseVisualStyleBackColor = true;
            this.btn_confirmaNome.Click += new System.EventHandler(this.btn_confirmaNome_Click);
            // 
            // txt_nomeAluno
            // 
            this.txt_nomeAluno.Location = new System.Drawing.Point(7, 42);
            this.txt_nomeAluno.Name = "txt_nomeAluno";
            this.txt_nomeAluno.Size = new System.Drawing.Size(464, 22);
            this.txt_nomeAluno.TabIndex = 4;
            // 
            // lbl_nomeAluno
            // 
            this.lbl_nomeAluno.AutoSize = true;
            this.lbl_nomeAluno.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nomeAluno.Location = new System.Drawing.Point(3, 8);
            this.lbl_nomeAluno.Name = "lbl_nomeAluno";
            this.lbl_nomeAluno.Size = new System.Drawing.Size(199, 20);
            this.lbl_nomeAluno.TabIndex = 2;
            this.lbl_nomeAluno.Text = "Digite o nome do Aluno ? ";
            // 
            // pnl_notaMateria
            // 
            this.pnl_notaMateria.Controls.Add(this.txt_notaIng);
            this.pnl_notaMateria.Controls.Add(this.txt_notaArt);
            this.pnl_notaMateria.Controls.Add(this.txt_notaHis);
            this.pnl_notaMateria.Controls.Add(this.txt_notaFis);
            this.pnl_notaMateria.Controls.Add(this.txt_notaPor);
            this.pnl_notaMateria.Controls.Add(this.txt_notaMat);
            this.pnl_notaMateria.Controls.Add(this.bnt_confirmaNota);
            this.pnl_notaMateria.Controls.Add(this.lbl_Ingles);
            this.pnl_notaMateria.Controls.Add(this.lbl_art);
            this.pnl_notaMateria.Controls.Add(this.lbl_his);
            this.pnl_notaMateria.Controls.Add(this.lbl_fis);
            this.pnl_notaMateria.Controls.Add(this.lbl_por);
            this.pnl_notaMateria.Controls.Add(this.lbl_mat);
            this.pnl_notaMateria.Location = new System.Drawing.Point(0, 180);
            this.pnl_notaMateria.Name = "pnl_notaMateria";
            this.pnl_notaMateria.Size = new System.Drawing.Size(858, 153);
            this.pnl_notaMateria.TabIndex = 2;
            // 
            // txt_notaIng
            // 
            this.txt_notaIng.Location = new System.Drawing.Point(506, 114);
            this.txt_notaIng.Name = "txt_notaIng";
            this.txt_notaIng.Size = new System.Drawing.Size(59, 22);
            this.txt_notaIng.TabIndex = 11;
            // 
            // txt_notaArt
            // 
            this.txt_notaArt.Location = new System.Drawing.Point(506, 63);
            this.txt_notaArt.Name = "txt_notaArt";
            this.txt_notaArt.Size = new System.Drawing.Size(59, 22);
            this.txt_notaArt.TabIndex = 9;
            // 
            // txt_notaHis
            // 
            this.txt_notaHis.Location = new System.Drawing.Point(506, 14);
            this.txt_notaHis.Name = "txt_notaHis";
            this.txt_notaHis.Size = new System.Drawing.Size(59, 22);
            this.txt_notaHis.TabIndex = 7;
            // 
            // txt_notaFis
            // 
            this.txt_notaFis.Location = new System.Drawing.Point(140, 114);
            this.txt_notaFis.Name = "txt_notaFis";
            this.txt_notaFis.Size = new System.Drawing.Size(59, 22);
            this.txt_notaFis.TabIndex = 10;
            // 
            // txt_notaPor
            // 
            this.txt_notaPor.Location = new System.Drawing.Point(140, 63);
            this.txt_notaPor.Name = "txt_notaPor";
            this.txt_notaPor.Size = new System.Drawing.Size(59, 22);
            this.txt_notaPor.TabIndex = 8;
            // 
            // txt_notaMat
            // 
            this.txt_notaMat.Location = new System.Drawing.Point(140, 14);
            this.txt_notaMat.Name = "txt_notaMat";
            this.txt_notaMat.Size = new System.Drawing.Size(59, 22);
            this.txt_notaMat.TabIndex = 6;
            // 
            // bnt_confirmaNota
            // 
            this.bnt_confirmaNota.Location = new System.Drawing.Point(780, 127);
            this.bnt_confirmaNota.Name = "bnt_confirmaNota";
            this.bnt_confirmaNota.Size = new System.Drawing.Size(75, 23);
            this.bnt_confirmaNota.TabIndex = 12;
            this.bnt_confirmaNota.Text = "OK";
            this.bnt_confirmaNota.UseVisualStyleBackColor = true;
            this.bnt_confirmaNota.Click += new System.EventHandler(this.bnt_confirmaNota_Click);
            // 
            // lbl_Ingles
            // 
            this.lbl_Ingles.AutoSize = true;
            this.lbl_Ingles.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ingles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Ingles.Location = new System.Drawing.Point(390, 114);
            this.lbl_Ingles.Name = "lbl_Ingles";
            this.lbl_Ingles.Size = new System.Drawing.Size(68, 20);
            this.lbl_Ingles.TabIndex = 11;
            this.lbl_Ingles.Text = "Inglês : ";
            // 
            // lbl_art
            // 
            this.lbl_art.AutoSize = true;
            this.lbl_art.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_art.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_art.Location = new System.Drawing.Point(390, 65);
            this.lbl_art.Name = "lbl_art";
            this.lbl_art.Size = new System.Drawing.Size(64, 20);
            this.lbl_art.TabIndex = 10;
            this.lbl_art.Text = "Artes : ";
            // 
            // lbl_his
            // 
            this.lbl_his.AutoSize = true;
            this.lbl_his.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_his.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_his.Location = new System.Drawing.Point(390, 16);
            this.lbl_his.Name = "lbl_his";
            this.lbl_his.Size = new System.Drawing.Size(82, 20);
            this.lbl_his.TabIndex = 9;
            this.lbl_his.Text = "História : ";
            // 
            // lbl_fis
            // 
            this.lbl_fis.AutoSize = true;
            this.lbl_fis.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_fis.Location = new System.Drawing.Point(8, 114);
            this.lbl_fis.Name = "lbl_fis";
            this.lbl_fis.Size = new System.Drawing.Size(73, 20);
            this.lbl_fis.TabIndex = 8;
            this.lbl_fis.Text = "Fisícia : ";
            // 
            // lbl_por
            // 
            this.lbl_por.AutoSize = true;
            this.lbl_por.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_por.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_por.Location = new System.Drawing.Point(8, 65);
            this.lbl_por.Name = "lbl_por";
            this.lbl_por.Size = new System.Drawing.Size(99, 20);
            this.lbl_por.TabIndex = 7;
            this.lbl_por.Text = "Português : ";
            // 
            // lbl_mat
            // 
            this.lbl_mat.AutoSize = true;
            this.lbl_mat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_mat.Location = new System.Drawing.Point(12, 16);
            this.lbl_mat.Name = "lbl_mat";
            this.lbl_mat.Size = new System.Drawing.Size(111, 20);
            this.lbl_mat.TabIndex = 6;
            this.lbl_mat.Text = "Matemática : ";
            // 
            // pnl_resultado
            // 
            this.pnl_resultado.Controls.Add(this.dataGridView1);
            this.pnl_resultado.Location = new System.Drawing.Point(0, 339);
            this.pnl_resultado.Name = "pnl_resultado";
            this.pnl_resultado.Size = new System.Drawing.Size(858, 153);
            this.pnl_resultado.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_mostraResul
            // 
            this.btn_mostraResul.Location = new System.Drawing.Point(783, 507);
            this.btn_mostraResul.Name = "btn_mostraResul";
            this.btn_mostraResul.Size = new System.Drawing.Size(75, 23);
            this.btn_mostraResul.TabIndex = 13;
            this.btn_mostraResul.Text = "Mostra";
            this.btn_mostraResul.UseVisualStyleBackColor = true;
            this.btn_mostraResul.Click += new System.EventHandler(this.btn_mostraResul_Click);
            // 
            // btn_boletim
            // 
            this.btn_boletim.Location = new System.Drawing.Point(702, 507);
            this.btn_boletim.Name = "btn_boletim";
            this.btn_boletim.Size = new System.Drawing.Size(75, 23);
            this.btn_boletim.TabIndex = 14;
            this.btn_boletim.Text = "Boletim";
            this.btn_boletim.UseVisualStyleBackColor = true;
            this.btn_boletim.Click += new System.EventHandler(this.btn_boletim_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(621, 507);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 15;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // frm_validaNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(860, 533);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_boletim);
            this.Controls.Add(this.btn_mostraResul);
            this.Controls.Add(this.pnl_resultado);
            this.Controls.Add(this.pnl_notaMateria);
            this.Controls.Add(this.pnl_nomeAluno);
            this.Controls.Add(this.pnl_media);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_validaNot";
            this.Text = "Validador de Notas";
            this.pnl_media.ResumeLayout(false);
            this.pnl_media.PerformLayout();
            this.pnl_nomeAluno.ResumeLayout(false);
            this.pnl_nomeAluno.PerformLayout();
            this.pnl_notaMateria.ResumeLayout(false);
            this.pnl_notaMateria.PerformLayout();
            this.pnl_resultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_media;
        private System.Windows.Forms.Label lbl_numAluno;
        private System.Windows.Forms.Panel pnl_nomeAluno;
        private System.Windows.Forms.Panel pnl_notaMateria;
        private System.Windows.Forms.Panel pnl_resultado;
        private System.Windows.Forms.Button bnt_confirmaMedia;
        private System.Windows.Forms.TextBox txt_numMedia;
        private System.Windows.Forms.TextBox txt_numAluno;
        private System.Windows.Forms.Label lbl_numMedia;
        private System.Windows.Forms.Button btn_confirmaNome;
        private System.Windows.Forms.TextBox txt_nomeAluno;
        private System.Windows.Forms.Label lbl_nomeAluno;
        private System.Windows.Forms.Button bnt_confirmaNota;
        private System.Windows.Forms.Label lbl_Ingles;
        private System.Windows.Forms.Label lbl_art;
        private System.Windows.Forms.Label lbl_his;
        private System.Windows.Forms.Label lbl_fis;
        private System.Windows.Forms.Label lbl_por;
        private System.Windows.Forms.Label lbl_mat;
        private System.Windows.Forms.Button btn_mostraResul;
        private System.Windows.Forms.Button btn_boletim;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_notaIng;
        private System.Windows.Forms.TextBox txt_notaArt;
        private System.Windows.Forms.TextBox txt_notaHis;
        private System.Windows.Forms.TextBox txt_notaFis;
        private System.Windows.Forms.TextBox txt_notaPor;
        private System.Windows.Forms.TextBox txt_notaMat;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

