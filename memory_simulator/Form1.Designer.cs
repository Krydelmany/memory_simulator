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
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.Acesso_Constante = new System.Windows.Forms.Button();
            this.btnListaAcesso = new System.Windows.Forms.Button();
            this.lbCache00 = new System.Windows.Forms.Label();
            this.gbCache = new System.Windows.Forms.GroupBox();
            this.lbCache33 = new System.Windows.Forms.Label();
            this.lbCache32 = new System.Windows.Forms.Label();
            this.lbCache31 = new System.Windows.Forms.Label();
            this.lbCache30 = new System.Windows.Forms.Label();
            this.lbCache23 = new System.Windows.Forms.Label();
            this.lbCache22 = new System.Windows.Forms.Label();
            this.lbCache21 = new System.Windows.Forms.Label();
            this.lbCache20 = new System.Windows.Forms.Label();
            this.lbCache13 = new System.Windows.Forms.Label();
            this.lbCache12 = new System.Windows.Forms.Label();
            this.lbCache11 = new System.Windows.Forms.Label();
            this.lbCache10 = new System.Windows.Forms.Label();
            this.lbCache03 = new System.Windows.Forms.Label();
            this.lbCache02 = new System.Windows.Forms.Label();
            this.lbCache01 = new System.Windows.Forms.Label();
            this.gpListaAcesso.SuspendLayout();
            this.gbCache.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMemoriaPrincipal
            // 
            this.gbMemoriaPrincipal.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMemoriaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.gbMemoriaPrincipal.Name = "gbMemoriaPrincipal";
            this.gbMemoriaPrincipal.Size = new System.Drawing.Size(528, 267);
            this.gbMemoriaPrincipal.TabIndex = 0;
            this.gbMemoriaPrincipal.TabStop = false;
            this.gbMemoriaPrincipal.Text = "Memória Principal";
            // 
            // btnGerarNumeros
            // 
            this.btnGerarNumeros.Location = new System.Drawing.Point(94, 303);
            this.btnGerarNumeros.Name = "btnGerarNumeros";
            this.btnGerarNumeros.Size = new System.Drawing.Size(97, 23);
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
            this.tbTimeStep.Text = "50";
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
            this.gpListaAcesso.Size = new System.Drawing.Size(191, 266);
            this.gpListaAcesso.TabIndex = 6;
            this.gpListaAcesso.TabStop = false;
            this.gpListaAcesso.Text = "Lista de Acesso";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(24, 31);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(146, 208);
            this.checkedListBox1.TabIndex = 0;
            checkedListBox1.DrawMode = DrawMode.Normal;

            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(197, 303);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(75, 23);
            this.btnLimparLista.TabIndex = 7;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
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
            this.btnListaAcesso.Size = new System.Drawing.Size(174, 23);
            this.btnListaAcesso.TabIndex = 9;
            this.btnListaAcesso.Text = "Criar Lista de Acesso";
            this.btnListaAcesso.UseVisualStyleBackColor = true;
            this.btnListaAcesso.Click += new System.EventHandler(this.btnListaAcesso_Click);
            // 
            // lbCache00
            // 
            this.lbCache00.AutoSize = true;
            this.lbCache00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache00.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache00.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache00.Location = new System.Drawing.Point(21, 24);
            this.lbCache00.Name = "lbCache00";
            this.lbCache00.Size = new System.Drawing.Size(20, 22);
            this.lbCache00.TabIndex = 10;
            this.lbCache00.Text = "0";
            // 
            // gbCache
            // 
            this.gbCache.Controls.Add(this.lbCache33);
            this.gbCache.Controls.Add(this.lbCache32);
            this.gbCache.Controls.Add(this.lbCache31);
            this.gbCache.Controls.Add(this.lbCache30);
            this.gbCache.Controls.Add(this.lbCache23);
            this.gbCache.Controls.Add(this.lbCache22);
            this.gbCache.Controls.Add(this.lbCache21);
            this.gbCache.Controls.Add(this.lbCache20);
            this.gbCache.Controls.Add(this.lbCache13);
            this.gbCache.Controls.Add(this.lbCache12);
            this.gbCache.Controls.Add(this.lbCache11);
            this.gbCache.Controls.Add(this.lbCache10);
            this.gbCache.Controls.Add(this.lbCache03);
            this.gbCache.Controls.Add(this.lbCache02);
            this.gbCache.Controls.Add(this.lbCache01);
            this.gbCache.Controls.Add(this.lbCache00);
            this.gbCache.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCache.Location = new System.Drawing.Point(566, 285);
            this.gbCache.Name = "gbCache";
            this.gbCache.Size = new System.Drawing.Size(191, 153);
            this.gbCache.TabIndex = 11;
            this.gbCache.TabStop = false;
            this.gbCache.Text = "Memória Cache";
            // 
            // lbCache33
            // 
            this.lbCache33.AutoSize = true;
            this.lbCache33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache33.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache33.Location = new System.Drawing.Point(151, 119);
            this.lbCache33.Name = "lbCache33";
            this.lbCache33.Size = new System.Drawing.Size(20, 22);
            this.lbCache33.TabIndex = 25;
            this.lbCache33.Text = "0";
            // 
            // lbCache32
            // 
            this.lbCache32.AutoSize = true;
            this.lbCache32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache32.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache32.Location = new System.Drawing.Point(107, 119);
            this.lbCache32.Name = "lbCache32";
            this.lbCache32.Size = new System.Drawing.Size(20, 22);
            this.lbCache32.TabIndex = 24;
            this.lbCache32.Text = "0";
            // 
            // lbCache31
            // 
            this.lbCache31.AutoSize = true;
            this.lbCache31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache31.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache31.Location = new System.Drawing.Point(66, 119);
            this.lbCache31.Name = "lbCache31";
            this.lbCache31.Size = new System.Drawing.Size(20, 22);
            this.lbCache31.TabIndex = 23;
            this.lbCache31.Text = "0";
            // 
            // lbCache30
            // 
            this.lbCache30.AutoSize = true;
            this.lbCache30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache30.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache30.Location = new System.Drawing.Point(21, 119);
            this.lbCache30.Name = "lbCache30";
            this.lbCache30.Size = new System.Drawing.Size(20, 22);
            this.lbCache30.TabIndex = 22;
            this.lbCache30.Text = "0";
            // 
            // lbCache23
            // 
            this.lbCache23.AutoSize = true;
            this.lbCache23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache23.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache23.Location = new System.Drawing.Point(151, 87);
            this.lbCache23.Name = "lbCache23";
            this.lbCache23.Size = new System.Drawing.Size(20, 22);
            this.lbCache23.TabIndex = 21;
            this.lbCache23.Text = "0";
            // 
            // lbCache22
            // 
            this.lbCache22.AutoSize = true;
            this.lbCache22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache22.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache22.Location = new System.Drawing.Point(107, 87);
            this.lbCache22.Name = "lbCache22";
            this.lbCache22.Size = new System.Drawing.Size(20, 22);
            this.lbCache22.TabIndex = 20;
            this.lbCache22.Text = "0";
            // 
            // lbCache21
            // 
            this.lbCache21.AutoSize = true;
            this.lbCache21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache21.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache21.Location = new System.Drawing.Point(66, 87);
            this.lbCache21.Name = "lbCache21";
            this.lbCache21.Size = new System.Drawing.Size(20, 22);
            this.lbCache21.TabIndex = 19;
            this.lbCache21.Text = "0";
            // 
            // lbCache20
            // 
            this.lbCache20.AutoSize = true;
            this.lbCache20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache20.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache20.Location = new System.Drawing.Point(21, 87);
            this.lbCache20.Name = "lbCache20";
            this.lbCache20.Size = new System.Drawing.Size(20, 22);
            this.lbCache20.TabIndex = 18;
            this.lbCache20.Text = "0";
            // 
            // lbCache13
            // 
            this.lbCache13.AutoSize = true;
            this.lbCache13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache13.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache13.Location = new System.Drawing.Point(151, 55);
            this.lbCache13.Name = "lbCache13";
            this.lbCache13.Size = new System.Drawing.Size(20, 22);
            this.lbCache13.TabIndex = 17;
            this.lbCache13.Text = "0";
            // 
            // lbCache12
            // 
            this.lbCache12.AutoSize = true;
            this.lbCache12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache12.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache12.Location = new System.Drawing.Point(107, 55);
            this.lbCache12.Name = "lbCache12";
            this.lbCache12.Size = new System.Drawing.Size(20, 22);
            this.lbCache12.TabIndex = 16;
            this.lbCache12.Text = "0";
            // 
            // lbCache11
            // 
            this.lbCache11.AutoSize = true;
            this.lbCache11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache11.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache11.Location = new System.Drawing.Point(66, 55);
            this.lbCache11.Name = "lbCache11";
            this.lbCache11.Size = new System.Drawing.Size(20, 22);
            this.lbCache11.TabIndex = 15;
            this.lbCache11.Text = "0";
            // 
            // lbCache10
            // 
            this.lbCache10.AutoSize = true;
            this.lbCache10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache10.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache10.Location = new System.Drawing.Point(21, 55);
            this.lbCache10.Name = "lbCache10";
            this.lbCache10.Size = new System.Drawing.Size(20, 22);
            this.lbCache10.TabIndex = 14;
            this.lbCache10.Text = "0";
            // 
            // lbCache03
            // 
            this.lbCache03.AutoSize = true;
            this.lbCache03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache03.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache03.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache03.Location = new System.Drawing.Point(151, 24);
            this.lbCache03.Name = "lbCache03";
            this.lbCache03.Size = new System.Drawing.Size(20, 22);
            this.lbCache03.TabIndex = 13;
            this.lbCache03.Text = "0";
            // 
            // lbCache02
            // 
            this.lbCache02.AutoSize = true;
            this.lbCache02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache02.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache02.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache02.Location = new System.Drawing.Point(107, 24);
            this.lbCache02.Name = "lbCache02";
            this.lbCache02.Size = new System.Drawing.Size(20, 22);
            this.lbCache02.TabIndex = 12;
            this.lbCache02.Text = "0";
            // 
            // lbCache01
            // 
            this.lbCache01.AutoSize = true;
            this.lbCache01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCache01.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCache01.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCache01.Location = new System.Drawing.Point(66, 24);
            this.lbCache01.Name = "lbCache01";
            this.lbCache01.Size = new System.Drawing.Size(20, 22);
            this.lbCache01.TabIndex = 11;
            this.lbCache01.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCache);
            this.Controls.Add(this.btnListaAcesso);
            this.Controls.Add(this.Acesso_Constante);
            this.Controls.Add(this.btnLimparLista);
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
            this.gbCache.ResumeLayout(false);
            this.gbCache.PerformLayout();
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
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.Button Acesso_Constante;
        private System.Windows.Forms.Button btnListaAcesso;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lbCache00;
        private System.Windows.Forms.GroupBox gbCache;
        private System.Windows.Forms.Label lbCache33;
        private System.Windows.Forms.Label lbCache32;
        private System.Windows.Forms.Label lbCache31;
        private System.Windows.Forms.Label lbCache30;
        private System.Windows.Forms.Label lbCache23;
        private System.Windows.Forms.Label lbCache22;
        private System.Windows.Forms.Label lbCache21;
        private System.Windows.Forms.Label lbCache20;
        private System.Windows.Forms.Label lbCache13;
        private System.Windows.Forms.Label lbCache12;
        private System.Windows.Forms.Label lbCache11;
        private System.Windows.Forms.Label lbCache10;
        private System.Windows.Forms.Label lbCache03;
        private System.Windows.Forms.Label lbCache02;
        private System.Windows.Forms.Label lbCache01;
    }
}

