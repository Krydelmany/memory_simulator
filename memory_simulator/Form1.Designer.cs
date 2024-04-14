using System;
using System.Windows.Forms;

namespace memory_simulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbMemoriaPrincipal = new System.Windows.Forms.GroupBox();
            this.btnGerarNumeros = new System.Windows.Forms.Button();
            this.btnAlternarVerificacao = new System.Windows.Forms.Button();
            this.tbTimeStep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpListaAcesso = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnLimparMP = new System.Windows.Forms.Button();
            this.Acesso_Constante = new System.Windows.Forms.Button();
            this.btnListaAcesso = new System.Windows.Forms.Button();
            this.gbMemoriaCache = new System.Windows.Forms.GroupBox();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.gpListaAcesso.SuspendLayout();
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
            this.btnGerarNumeros.Location = new System.Drawing.Point(94, 303);
            this.btnGerarNumeros.Name = "btnGerarNumeros";
            this.btnGerarNumeros.Size = new System.Drawing.Size(123, 23);
            this.btnGerarNumeros.TabIndex = 1;
            this.btnGerarNumeros.Text = "Preencher MP";
            this.btnGerarNumeros.UseVisualStyleBackColor = true;
            this.btnGerarNumeros.Click += new System.EventHandler(this.btnGerarNumeros_Click);
            // 
            // btnAlternarVerificacao
            // 
            this.btnAlternarVerificacao.Location = new System.Drawing.Point(171, 387);
            this.btnAlternarVerificacao.Name = "btnAlternarVerificacao";
            this.btnAlternarVerificacao.Size = new System.Drawing.Size(97, 23);
            this.btnAlternarVerificacao.TabIndex = 2;
            this.btnAlternarVerificacao.Text = "Acessar Lista";
            this.btnAlternarVerificacao.UseVisualStyleBackColor = true;
            this.btnAlternarVerificacao.Click += new System.EventHandler(this.btnAlternarVerificacao_Click);
            // 
            // tbTimeStep
            // 
            this.tbTimeStep.Location = new System.Drawing.Point(94, 389);
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
            this.label1.Location = new System.Drawing.Point(14, 392);
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
            this.btnLimparMP.Location = new System.Drawing.Point(223, 303);
            this.btnLimparMP.Name = "btnLimparMP";
            this.btnLimparMP.Size = new System.Drawing.Size(75, 23);
            this.btnLimparMP.TabIndex = 7;
            this.btnLimparMP.Text = "Limpar MP";
            this.btnLimparMP.UseVisualStyleBackColor = true;
            this.btnLimparMP.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // Acesso_Constante
            // 
            this.Acesso_Constante.Location = new System.Drawing.Point(94, 415);
            this.Acesso_Constante.Name = "Acesso_Constante";
            this.Acesso_Constante.Size = new System.Drawing.Size(174, 23);
            this.Acesso_Constante.TabIndex = 8;
            this.Acesso_Constante.Text = "Acesso Constante";
            this.Acesso_Constante.UseVisualStyleBackColor = true;
            this.Acesso_Constante.Click += new System.EventHandler(this.Acesso_Constante_Click);
            // 
            // btnListaAcesso
            // 
            this.btnListaAcesso.AccessibleDescription = "";
            this.btnListaAcesso.Location = new System.Drawing.Point(94, 332);
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
            this.gbMemoriaCache.Location = new System.Drawing.Point(566, 285);
            this.gbMemoriaCache.Name = "gbMemoriaCache";
            this.gbMemoriaCache.Size = new System.Drawing.Size(191, 153);
            this.gbMemoriaCache.TabIndex = 11;
            this.gbMemoriaCache.TabStop = false;
            this.gbMemoriaCache.Text = "Memória Cache";
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(224, 331);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(75, 23);
            this.btnLimparLista.TabIndex = 12;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparMP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.gbMemoriaCache);
            this.Controls.Add(this.btnListaAcesso);
            this.Controls.Add(this.Acesso_Constante);
            this.Controls.Add(this.btnLimparMP);
            this.Controls.Add(this.gpListaAcesso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTimeStep);
            this.Controls.Add(this.btnAlternarVerificacao);
            this.Controls.Add(this.btnGerarNumeros);
            this.Controls.Add(this.gbMemoriaPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Memory Simulator";
            this.gpListaAcesso.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button Acesso_Constante;
        private System.Windows.Forms.Button btnListaAcesso;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox gbMemoriaCache;
        private Button btnLimparLista;
    }
}

