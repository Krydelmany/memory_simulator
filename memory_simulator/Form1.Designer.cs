using System;
using System.Windows.Forms;

namespace memory_simulator
{
    partial class frmMemorySimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemorySimulator));
            this.gbMemoriaPrincipal = new System.Windows.Forms.GroupBox();
            this.btnGerarNumeros = new System.Windows.Forms.Button();
            this.btnAlternarVerificacao = new System.Windows.Forms.Button();
            this.tbTimeStep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpListaAcesso = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnLimparMP = new System.Windows.Forms.Button();
            this.btnListaAcesso = new System.Windows.Forms.Button();
            this.gbMemoriaCache = new System.Windows.Forms.GroupBox();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpListaAcesso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMemoriaPrincipal
            // 
            this.gbMemoriaPrincipal.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMemoriaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.gbMemoriaPrincipal.Name = "gbMemoriaPrincipal";
            this.gbMemoriaPrincipal.Size = new System.Drawing.Size(528, 240);
            this.gbMemoriaPrincipal.TabIndex = 0;
            this.gbMemoriaPrincipal.TabStop = false;
            this.gbMemoriaPrincipal.Text = "Memória Principal";
            // 
            // btnGerarNumeros
            // 
            this.btnGerarNumeros.Location = new System.Drawing.Point(6, 19);
            this.btnGerarNumeros.Name = "btnGerarNumeros";
            this.btnGerarNumeros.Size = new System.Drawing.Size(123, 23);
            this.btnGerarNumeros.TabIndex = 1;
            this.btnGerarNumeros.Text = "Preencher MP";
            this.btnGerarNumeros.UseVisualStyleBackColor = true;
            this.btnGerarNumeros.Click += new System.EventHandler(this.btnGerarNumeros_Click);
            // 
            // btnAlternarVerificacao
            // 
            this.btnAlternarVerificacao.Location = new System.Drawing.Point(163, 100);
            this.btnAlternarVerificacao.Name = "btnAlternarVerificacao";
            this.btnAlternarVerificacao.Size = new System.Drawing.Size(103, 23);
            this.btnAlternarVerificacao.TabIndex = 2;
            this.btnAlternarVerificacao.Text = "Cache Miss";
            this.btnAlternarVerificacao.UseVisualStyleBackColor = true;
            this.btnAlternarVerificacao.Click += new System.EventHandler(this.btnAlternarVerificacao_Click);
            // 
            // tbTimeStep
            // 
            this.tbTimeStep.Location = new System.Drawing.Point(82, 102);
            this.tbTimeStep.Name = "tbTimeStep";
            this.tbTimeStep.Size = new System.Drawing.Size(75, 20);
            this.tbTimeStep.TabIndex = 3;
            this.tbTimeStep.Text = "1";
            this.tbTimeStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTimeStep.TextChanged += new System.EventHandler(this.tbTimeStep_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TimeStep (ms)";
            // 
            // gpListaAcesso
            // 
            this.gpListaAcesso.Controls.Add(this.checkedListBox1);
            this.gpListaAcesso.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.gpListaAcesso.Location = new System.Drawing.Point(566, 13);
            this.gpListaAcesso.Name = "gpListaAcesso";
            this.gpListaAcesso.Size = new System.Drawing.Size(191, 239);
            this.gpListaAcesso.TabIndex = 6;
            this.gpListaAcesso.TabStop = false;
            this.gpListaAcesso.Text = "Lista de Acesso";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(24, 31);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(146, 191);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnLimparMP
            // 
            this.btnLimparMP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimparMP.Location = new System.Drawing.Point(135, 19);
            this.btnLimparMP.Name = "btnLimparMP";
            this.btnLimparMP.Size = new System.Drawing.Size(75, 23);
            this.btnLimparMP.TabIndex = 7;
            this.btnLimparMP.Text = "Limpar MP";
            this.btnLimparMP.UseVisualStyleBackColor = true;
            this.btnLimparMP.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // btnListaAcesso
            // 
            this.btnListaAcesso.AccessibleDescription = "";
            this.btnListaAcesso.Location = new System.Drawing.Point(6, 48);
            this.btnListaAcesso.Name = "btnListaAcesso";
            this.btnListaAcesso.Size = new System.Drawing.Size(123, 23);
            this.btnListaAcesso.TabIndex = 9;
            this.btnListaAcesso.Text = "Criar Lista de Acesso";
            this.btnListaAcesso.UseVisualStyleBackColor = true;
            this.btnListaAcesso.Click += new System.EventHandler(this.btnListaAcesso_Click);
            // 
            // gbMemoriaCache
            // 
            this.gbMemoriaCache.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMemoriaCache.Location = new System.Drawing.Point(566, 258);
            this.gbMemoriaCache.Name = "gbMemoriaCache";
            this.gbMemoriaCache.Size = new System.Drawing.Size(191, 153);
            this.gbMemoriaCache.TabIndex = 11;
            this.gbMemoriaCache.TabStop = false;
            this.gbMemoriaCache.Text = "Memória Cache";
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimparLista.Location = new System.Drawing.Point(135, 48);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(75, 23);
            this.btnLimparLista.TabIndex = 12;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparMP_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(240, 19);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(119, 23);
            this.btnResetar.TabIndex = 13;
            this.btnResetar.Text = "Cancelar operação";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cache Hit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerarNumeros);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAlternarVerificacao);
            this.groupBox1.Controls.Add(this.btnResetar);
            this.groupBox1.Controls.Add(this.tbTimeStep);
            this.groupBox1.Controls.Add(this.btnLimparLista);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLimparMP);
            this.groupBox1.Controls.Add(this.btnListaAcesso);
            this.groupBox1.Location = new System.Drawing.Point(12, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 153);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // frmMemorySimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMemoriaCache);
            this.Controls.Add(this.gpListaAcesso);
            this.Controls.Add(this.gbMemoriaPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMemorySimulator";
            this.Text = "Memory Simulator";
            this.gpListaAcesso.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        private void tbTimeStep_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.GroupBox gbMemoriaPrincipal;
        private System.Windows.Forms.Button btnGerarNumeros;
        private System.Windows.Forms.Button btnAlternarVerificacao;
        private System.Windows.Forms.TextBox tbTimeStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpListaAcesso;
        private System.Windows.Forms.Button btnLimparMP;
        private System.Windows.Forms.Button btnListaAcesso;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox gbMemoriaCache;
        private Button btnLimparLista;
        private Button btnResetar;
        private Button button1;
        private GroupBox groupBox1;
    }
}

