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
            this.btnCacheMiss = new System.Windows.Forms.Button();
            this.tbTimeStep = new System.Windows.Forms.TextBox();
            this.lbTimeStep = new System.Windows.Forms.Label();
            this.gpListaAcesso = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnLimparMP = new System.Windows.Forms.Button();
            this.btnListaAcesso = new System.Windows.Forms.Button();
            this.gbMemoriaCache = new System.Windows.Forms.GroupBox();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btnCacheHit = new System.Windows.Forms.Button();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.btnLimparCache = new System.Windows.Forms.Button();
            this.gpListaAcesso.SuspendLayout();
            this.gbAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMemoriaPrincipal
            // 
            this.gbMemoriaPrincipal.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMemoriaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.gbMemoriaPrincipal.Name = "gbMemoriaPrincipal";
            this.gbMemoriaPrincipal.Size = new System.Drawing.Size(653, 248);
            this.gbMemoriaPrincipal.TabIndex = 0;
            this.gbMemoriaPrincipal.TabStop = false;
            this.gbMemoriaPrincipal.Text = "Memória Principal";
            // 
            // btnGerarNumeros
            // 
            this.btnGerarNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarNumeros.Location = new System.Drawing.Point(25, 46);
            this.btnGerarNumeros.Name = "btnGerarNumeros";
            this.btnGerarNumeros.Size = new System.Drawing.Size(186, 32);
            this.btnGerarNumeros.TabIndex = 1;
            this.btnGerarNumeros.Text = "Preencher Memória Principal";
            this.btnGerarNumeros.UseVisualStyleBackColor = true;
            this.btnGerarNumeros.Click += new System.EventHandler(this.btnGerarNumeros_Click);
            // 
            // btnCacheMiss
            // 
            this.btnCacheMiss.ForeColor = System.Drawing.Color.Red;
            this.btnCacheMiss.Location = new System.Drawing.Point(333, 63);
            this.btnCacheMiss.Name = "btnCacheMiss";
            this.btnCacheMiss.Size = new System.Drawing.Size(104, 23);
            this.btnCacheMiss.TabIndex = 2;
            this.btnCacheMiss.Text = "Cache Miss";
            this.btnCacheMiss.UseVisualStyleBackColor = true;
            this.btnCacheMiss.Click += new System.EventHandler(this.btnAlternarVerificacao_Click);
            // 
            // tbTimeStep
            // 
            this.tbTimeStep.Location = new System.Drawing.Point(443, 35);
            this.tbTimeStep.Name = "tbTimeStep";
            this.tbTimeStep.Size = new System.Drawing.Size(104, 22);
            this.tbTimeStep.TabIndex = 3;
            this.tbTimeStep.Text = "10";
            this.tbTimeStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTimeStep
            // 
            this.lbTimeStep.AutoSize = true;
            this.lbTimeStep.Location = new System.Drawing.Point(345, 38);
            this.lbTimeStep.Name = "lbTimeStep";
            this.lbTimeStep.Size = new System.Drawing.Size(76, 15);
            this.lbTimeStep.TabIndex = 4;
            this.lbTimeStep.Text = "TimeStep (ms)";
            // 
            // gpListaAcesso
            // 
            this.gpListaAcesso.Controls.Add(this.checkedListBox1);
            this.gpListaAcesso.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.gpListaAcesso.Location = new System.Drawing.Point(671, 12);
            this.gpListaAcesso.Name = "gpListaAcesso";
            this.gpListaAcesso.Size = new System.Drawing.Size(190, 248);
            this.gpListaAcesso.TabIndex = 6;
            this.gpListaAcesso.TabStop = false;
            this.gpListaAcesso.Text = "Lista de Acesso";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 21);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(166, 208);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnLimparMP
            // 
            this.btnLimparMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparMP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimparMP.Location = new System.Drawing.Point(217, 45);
            this.btnLimparMP.Name = "btnLimparMP";
            this.btnLimparMP.Size = new System.Drawing.Size(87, 23);
            this.btnLimparMP.TabIndex = 7;
            this.btnLimparMP.Text = "Limpar MP";
            this.btnLimparMP.UseVisualStyleBackColor = true;
            this.btnLimparMP.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // btnListaAcesso
            // 
            this.btnListaAcesso.AccessibleDescription = "";
            this.btnListaAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaAcesso.Location = new System.Drawing.Point(25, 77);
            this.btnListaAcesso.Name = "btnListaAcesso";
            this.btnListaAcesso.Size = new System.Drawing.Size(186, 35);
            this.btnListaAcesso.TabIndex = 9;
            this.btnListaAcesso.Text = "Criar Lista de Acesso";
            this.btnListaAcesso.UseVisualStyleBackColor = true;
            this.btnListaAcesso.Click += new System.EventHandler(this.btnListaAcesso_Click);
            // 
            // gbMemoriaCache
            // 
            this.gbMemoriaCache.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMemoriaCache.Location = new System.Drawing.Point(671, 266);
            this.gbMemoriaCache.Name = "gbMemoriaCache";
            this.gbMemoriaCache.Size = new System.Drawing.Size(191, 139);
            this.gbMemoriaCache.TabIndex = 11;
            this.gbMemoriaCache.TabStop = false;
            this.gbMemoriaCache.Text = "Memória Cache";
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparLista.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimparLista.Location = new System.Drawing.Point(217, 67);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(87, 23);
            this.btnLimparLista.TabIndex = 12;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparMP_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(332, 89);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(216, 23);
            this.btnResetar.TabIndex = 13;
            this.btnResetar.Text = "Cancelar operação/Reset\r\n";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btnCacheHit
            // 
            this.btnCacheHit.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCacheHit.Location = new System.Drawing.Point(443, 63);
            this.btnCacheHit.Name = "btnCacheHit";
            this.btnCacheHit.Size = new System.Drawing.Size(104, 23);
            this.btnCacheHit.TabIndex = 14;
            this.btnCacheHit.Text = "Cache Hit";
            this.btnCacheHit.UseVisualStyleBackColor = true;
            this.btnCacheHit.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbAcoes
            // 
            this.gbAcoes.Controls.Add(this.btnLimparCache);
            this.gbAcoes.Controls.Add(this.btnGerarNumeros);
            this.gbAcoes.Controls.Add(this.btnCacheHit);
            this.gbAcoes.Controls.Add(this.btnCacheMiss);
            this.gbAcoes.Controls.Add(this.tbTimeStep);
            this.gbAcoes.Controls.Add(this.btnLimparLista);
            this.gbAcoes.Controls.Add(this.btnResetar);
            this.gbAcoes.Controls.Add(this.lbTimeStep);
            this.gbAcoes.Controls.Add(this.btnLimparMP);
            this.gbAcoes.Controls.Add(this.btnListaAcesso);
            this.gbAcoes.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.gbAcoes.Location = new System.Drawing.Point(12, 266);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Size = new System.Drawing.Size(653, 139);
            this.gbAcoes.TabIndex = 15;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "Ações";
            // 
            // btnLimparCache
            // 
            this.btnLimparCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCache.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimparCache.Location = new System.Drawing.Point(217, 89);
            this.btnLimparCache.Name = "btnLimparCache";
            this.btnLimparCache.Size = new System.Drawing.Size(87, 23);
            this.btnLimparCache.TabIndex = 15;
            this.btnLimparCache.Text = "Limpar Cache";
            this.btnLimparCache.UseVisualStyleBackColor = true;
            this.btnLimparCache.Click += new System.EventHandler(this.btnLimparCache_Click);
            // 
            // frmMemorySimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 416);
            this.Controls.Add(this.gbAcoes);
            this.Controls.Add(this.gbMemoriaCache);
            this.Controls.Add(this.gpListaAcesso);
            this.Controls.Add(this.gbMemoriaPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMemorySimulator";
            this.Text = "Memory Simulator";
            this.gpListaAcesso.ResumeLayout(false);
            this.gbAcoes.ResumeLayout(false);
            this.gbAcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMemoriaPrincipal;
        private System.Windows.Forms.Button btnGerarNumeros;
        private System.Windows.Forms.Button btnCacheMiss;
        private System.Windows.Forms.TextBox tbTimeStep;
        private System.Windows.Forms.Label lbTimeStep;
        private System.Windows.Forms.GroupBox gpListaAcesso;
        private System.Windows.Forms.Button btnLimparMP;
        private System.Windows.Forms.Button btnListaAcesso;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox gbMemoriaCache;
        private Button btnLimparLista;
        private Button btnResetar;
        private Button btnCacheHit;
        private GroupBox gbAcoes;
        private Button btnLimparCache;
    }
}

