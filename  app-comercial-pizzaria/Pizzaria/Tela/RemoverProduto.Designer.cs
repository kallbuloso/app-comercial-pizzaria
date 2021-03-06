﻿namespace Pizzaria.Tela
{
    partial class RemoverProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtProduto = new System.Windows.Forms.MaskedTextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.LQuantidade = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.pFundo = new System.Windows.Forms.Panel();
            this.mtbQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.pFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.mtbQuantidade);
            this.panel1.Controls.Add(this.mtProduto);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 84);
            this.panel1.TabIndex = 21;
            // 
            // mtProduto
            // 
            this.mtProduto.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtProduto.ForeColor = System.Drawing.Color.DarkRed;
            this.mtProduto.Location = new System.Drawing.Point(30, 19);
            this.mtProduto.Mask = "00000";
            this.mtProduto.Name = "mtProduto";
            this.mtProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtProduto.Size = new System.Drawing.Size(102, 44);
            this.mtProduto.TabIndex = 1;
            this.mtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtProduto_KeyPress);
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImage = global::Pizzaria.Properties.Resources.BtCancelar;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(44, 141);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(102, 39);
            this.btCancelar.TabIndex = 23;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackgroundImage = global::Pizzaria.Properties.Resources.BtConfirmar;
            this.btConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfirmar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.Color.Maroon;
            this.btConfirmar.Location = new System.Drawing.Point(218, 140);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(129, 40);
            this.btConfirmar.TabIndex = 22;
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // LQuantidade
            // 
            this.LQuantidade.AutoSize = true;
            this.LQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.LQuantidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LQuantidade.Location = new System.Drawing.Point(226, 23);
            this.LQuantidade.Name = "LQuantidade";
            this.LQuantidade.Size = new System.Drawing.Size(136, 22);
            this.LQuantidade.TabIndex = 24;
            this.LQuantidade.Text = "QUANTIDADE";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(52, 23);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(58, 22);
            this.lbCodigo.TabIndex = 25;
            this.lbCodigo.Text = "ITEM";
            // 
            // pFundo
            // 
            this.pFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFundo.Controls.Add(this.panel1);
            this.pFundo.Controls.Add(this.lbCodigo);
            this.pFundo.Controls.Add(this.btCancelar);
            this.pFundo.Controls.Add(this.LQuantidade);
            this.pFundo.Controls.Add(this.btConfirmar);
            this.pFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFundo.Location = new System.Drawing.Point(0, 0);
            this.pFundo.Margin = new System.Windows.Forms.Padding(0);
            this.pFundo.Name = "pFundo";
            this.pFundo.Size = new System.Drawing.Size(406, 193);
            this.pFundo.TabIndex = 26;
            // 
            // mtbQuantidade
            // 
            this.mtbQuantidade.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbQuantidade.ForeColor = System.Drawing.Color.DarkRed;
            this.mtbQuantidade.Location = new System.Drawing.Point(204, 18);
            this.mtbQuantidade.Mask = "00000";
            this.mtbQuantidade.Name = "mtbQuantidade";
            this.mtbQuantidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtbQuantidade.Size = new System.Drawing.Size(129, 44);
            this.mtbQuantidade.TabIndex = 2;
            // 
            // RemoverProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 193);
            this.ControlBox = false;
            this.Controls.Add(this.pFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 209);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 209);
            this.Name = "RemoverProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoverProduto_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pFundo.ResumeLayout(false);
            this.pFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtProduto;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Label LQuantidade;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Panel pFundo;
        private System.Windows.Forms.MaskedTextBox mtbQuantidade;
    }
}