﻿namespace Pizzaria.Tela
{
    partial class Venda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venda));
            this.panBut = new System.Windows.Forms.Panel();
            this.tabLayDescricao = new System.Windows.Forms.TableLayoutPanel();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorUni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuDireito = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ttRemoverUm = new System.Windows.Forms.ToolStripMenuItem();
            this.ttRemoverTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.separador = new System.Windows.Forms.ToolStripSeparator();
            this.MSProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.reimpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpGAmb = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lvGarcon = new System.Windows.Forms.ListView();
            this.codGar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomGar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pValor = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbComissao = new System.Windows.Forms.Label();
            this.lbSubValor = new System.Windows.Forms.Label();
            this.lvMesa = new System.Windows.Forms.ListView();
            this.nomMesa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ambient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabLayINFO = new System.Windows.Forms.TableLayoutPanel();
            this.tabLayPROD = new System.Windows.Forms.TableLayoutPanel();
            this.pBotoesCima = new System.Windows.Forms.Panel();
            this.pProduto = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btProduto = new System.Windows.Forms.Button();
            this.btRemoveProd = new System.Windows.Forms.Button();
            this.pMesaNova = new System.Windows.Forms.Panel();
            this.btInseMesa = new System.Windows.Forms.Button();
            this.pMesa = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btMesaTrocar = new System.Windows.Forms.Button();
            this.btRemoMesa = new System.Windows.Forms.Button();
            this.tlpVenda = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lOpcao = new System.Windows.Forms.Label();
            this.tlbBotaoVendas = new System.Windows.Forms.TableLayoutPanel();
            this.btAnular = new System.Windows.Forms.Button();
            this.btParcial = new System.Windows.Forms.Button();
            this.btEncerrar = new System.Windows.Forms.Button();
            this.tlpComanda = new System.Windows.Forms.TableLayoutPanel();
            this.btAgrupar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.ttEncerrar = new System.Windows.Forms.ToolTip(this.components);
            this.panBut.SuspendLayout();
            this.tabLayDescricao.SuspendLayout();
            this.menuDireito.SuspendLayout();
            this.tlpGAmb.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.pValor.SuspendLayout();
            this.tabLayINFO.SuspendLayout();
            this.tabLayPROD.SuspendLayout();
            this.pBotoesCima.SuspendLayout();
            this.pProduto.SuspendLayout();
            this.pMesaNova.SuspendLayout();
            this.pMesa.SuspendLayout();
            this.tlpVenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlbBotaoVendas.SuspendLayout();
            this.tlpComanda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBut
            // 
            this.panBut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panBut.BackColor = System.Drawing.Color.Transparent;
            this.panBut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panBut.Controls.Add(this.tabLayDescricao);
            this.panBut.Controls.Add(this.tabLayINFO);
            this.panBut.Location = new System.Drawing.Point(0, 0);
            this.panBut.Margin = new System.Windows.Forms.Padding(0);
            this.panBut.MaximumSize = new System.Drawing.Size(1019, 400);
            this.panBut.MinimumSize = new System.Drawing.Size(1019, 400);
            this.panBut.Name = "panBut";
            this.panBut.Size = new System.Drawing.Size(1019, 400);
            this.panBut.TabIndex = 22;
            // 
            // tabLayDescricao
            // 
            this.tabLayDescricao.ColumnCount = 1;
            this.tabLayDescricao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayDescricao.Controls.Add(this.lvInfo, 0, 0);
            this.tabLayDescricao.Controls.Add(this.tlpGAmb, 0, 1);
            this.tabLayDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabLayDescricao.Location = new System.Drawing.Point(447, 0);
            this.tabLayDescricao.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.tabLayDescricao.Name = "tabLayDescricao";
            this.tabLayDescricao.RowCount = 2;
            this.tabLayDescricao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tabLayDescricao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tabLayDescricao.Size = new System.Drawing.Size(570, 396);
            this.tabLayDescricao.TabIndex = 20;
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.Produto,
            this.Tamanho,
            this.Quantidade,
            this.ValorUni,
            this.SubTotal});
            this.lvInfo.ContextMenuStrip = this.menuDireito;
            this.lvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.GridLines = true;
            this.lvInfo.HoverSelection = true;
            this.lvInfo.Location = new System.Drawing.Point(3, 0);
            this.lvInfo.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(565, 262);
            this.lvInfo.TabIndex = 32;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            this.lvInfo.ItemActivate += new System.EventHandler(this.lvInfo_ItemActivate);
            // 
            // codigo
            // 
            this.codigo.Text = "Item";
            this.codigo.Width = 55;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 170;
            // 
            // Tamanho
            // 
            this.Tamanho.Text = "Tamanho";
            this.Tamanho.Width = 75;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Width = 80;
            // 
            // ValorUni
            // 
            this.ValorUni.Text = "Valor Unitario";
            this.ValorUni.Width = 90;
            // 
            // SubTotal
            // 
            this.SubTotal.Text = "Sub Valor";
            this.SubTotal.Width = 85;
            // 
            // menuDireito
            // 
            this.menuDireito.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttRemoverUm,
            this.ttRemoverTodos,
            this.separador,
            this.MSProduto,
            this.reimpressãoToolStripMenuItem});
            this.menuDireito.Name = "menuDireito";
            this.menuDireito.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuDireito.Size = new System.Drawing.Size(164, 98);
            // 
            // ttRemoverUm
            // 
            this.ttRemoverUm.Name = "ttRemoverUm";
            this.ttRemoverUm.Size = new System.Drawing.Size(163, 22);
            this.ttRemoverUm.Text = "Remover UM";
            this.ttRemoverUm.Click += new System.EventHandler(this.ttRemoverUm_Click);
            // 
            // ttRemoverTodos
            // 
            this.ttRemoverTodos.Name = "ttRemoverTodos";
            this.ttRemoverTodos.Size = new System.Drawing.Size(163, 22);
            this.ttRemoverTodos.Text = "Remover TODOS";
            this.ttRemoverTodos.Click += new System.EventHandler(this.ttRemoverTodos_Click);
            // 
            // separador
            // 
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(160, 6);
            // 
            // MSProduto
            // 
            this.MSProduto.Name = "MSProduto";
            this.MSProduto.Size = new System.Drawing.Size(163, 22);
            this.MSProduto.Text = "Acrescentar UM";
            this.MSProduto.Click += new System.EventHandler(this.MSProduto_Click);
            // 
            // reimpressãoToolStripMenuItem
            // 
            this.reimpressãoToolStripMenuItem.Name = "reimpressãoToolStripMenuItem";
            this.reimpressãoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.reimpressãoToolStripMenuItem.Text = "Reimpressão";
            this.reimpressãoToolStripMenuItem.Click += new System.EventHandler(this.reimpressãoToolStripMenuItem_Click);
            // 
            // tlpGAmb
            // 
            this.tlpGAmb.ColumnCount = 2;
            this.tlpGAmb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.53927F));
            this.tlpGAmb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.46073F));
            this.tlpGAmb.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tlpGAmb.Controls.Add(this.lvMesa, 1, 0);
            this.tlpGAmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGAmb.Location = new System.Drawing.Point(0, 262);
            this.tlpGAmb.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.tlpGAmb.Name = "tlpGAmb";
            this.tlpGAmb.RowCount = 1;
            this.tlpGAmb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGAmb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tlpGAmb.Size = new System.Drawing.Size(569, 133);
            this.tlpGAmb.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.16667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.83333F));
            this.tableLayoutPanel5.Controls.Add(this.lvGarcon, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.pValor, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(384, 133);
            this.tableLayoutPanel5.TabIndex = 39;
            // 
            // lvGarcon
            // 
            this.lvGarcon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codGar,
            this.nomGar});
            this.lvGarcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGarcon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGarcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvGarcon.FullRowSelect = true;
            this.lvGarcon.GridLines = true;
            this.lvGarcon.HoverSelection = true;
            this.lvGarcon.Location = new System.Drawing.Point(211, 3);
            this.lvGarcon.Name = "lvGarcon";
            this.lvGarcon.Size = new System.Drawing.Size(170, 127);
            this.lvGarcon.TabIndex = 33;
            this.lvGarcon.UseCompatibleStateImageBehavior = false;
            this.lvGarcon.View = System.Windows.Forms.View.Details;
            // 
            // codGar
            // 
            this.codGar.Text = "Codigo";
            // 
            // nomGar
            // 
            this.nomGar.Text = "Garçon";
            this.nomGar.Width = 100;
            // 
            // pValor
            // 
            this.pValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pValor.Controls.Add(this.lbTotal);
            this.pValor.Controls.Add(this.lbComissao);
            this.pValor.Controls.Add(this.lbSubValor);
            this.pValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pValor.Location = new System.Drawing.Point(3, 3);
            this.pValor.Name = "pValor";
            this.pValor.Size = new System.Drawing.Size(202, 127);
            this.pValor.TabIndex = 34;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Arial", 13F);
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(3, 93);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(68, 21);
            this.lbTotal.TabIndex = 20;
            this.lbTotal.Text = "VALOR";
            // 
            // lbComissao
            // 
            this.lbComissao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbComissao.AutoSize = true;
            this.lbComissao.Font = new System.Drawing.Font("Arial", 13F);
            this.lbComissao.ForeColor = System.Drawing.Color.Black;
            this.lbComissao.Location = new System.Drawing.Point(4, 55);
            this.lbComissao.Name = "lbComissao";
            this.lbComissao.Size = new System.Drawing.Size(68, 21);
            this.lbComissao.TabIndex = 19;
            this.lbComissao.Text = "VALOR";
            // 
            // lbSubValor
            // 
            this.lbSubValor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSubValor.AutoSize = true;
            this.lbSubValor.Font = new System.Drawing.Font("Arial", 13F);
            this.lbSubValor.ForeColor = System.Drawing.Color.Black;
            this.lbSubValor.Location = new System.Drawing.Point(3, 22);
            this.lbSubValor.Name = "lbSubValor";
            this.lbSubValor.Size = new System.Drawing.Size(68, 21);
            this.lbSubValor.TabIndex = 18;
            this.lbSubValor.Text = "VALOR";
            // 
            // lvMesa
            // 
            this.lvMesa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomMesa,
            this.ambient});
            this.lvMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvMesa.FullRowSelect = true;
            this.lvMesa.GridLines = true;
            this.lvMesa.HoverSelection = true;
            this.lvMesa.Location = new System.Drawing.Point(387, 3);
            this.lvMesa.Name = "lvMesa";
            this.lvMesa.Size = new System.Drawing.Size(179, 127);
            this.lvMesa.TabIndex = 38;
            this.lvMesa.UseCompatibleStateImageBehavior = false;
            this.lvMesa.View = System.Windows.Forms.View.Details;
            // 
            // nomMesa
            // 
            this.nomMesa.Text = "Mesa";
            this.nomMesa.Width = 90;
            // 
            // ambient
            // 
            this.ambient.Text = "Ambiente";
            this.ambient.Width = 80;
            // 
            // tabLayINFO
            // 
            this.tabLayINFO.BackColor = System.Drawing.Color.Transparent;
            this.tabLayINFO.ColumnCount = 1;
            this.tabLayINFO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayINFO.Controls.Add(this.tabLayPROD, 0, 0);
            this.tabLayINFO.Controls.Add(this.tlpVenda, 0, 1);
            this.tabLayINFO.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabLayINFO.Location = new System.Drawing.Point(0, 0);
            this.tabLayINFO.Margin = new System.Windows.Forms.Padding(0);
            this.tabLayINFO.Name = "tabLayINFO";
            this.tabLayINFO.RowCount = 2;
            this.tabLayINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.9899F));
            this.tabLayINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.0101F));
            this.tabLayINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayINFO.Size = new System.Drawing.Size(447, 396);
            this.tabLayINFO.TabIndex = 11;
            // 
            // tabLayPROD
            // 
            this.tabLayPROD.BackColor = System.Drawing.Color.Transparent;
            this.tabLayPROD.ColumnCount = 1;
            this.tabLayPROD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayPROD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPROD.Controls.Add(this.pBotoesCima, 0, 0);
            this.tabLayPROD.Controls.Add(this.pMesaNova, 0, 1);
            this.tabLayPROD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPROD.Location = new System.Drawing.Point(0, 0);
            this.tabLayPROD.Margin = new System.Windows.Forms.Padding(0);
            this.tabLayPROD.Name = "tabLayPROD";
            this.tabLayPROD.RowCount = 2;
            this.tabLayPROD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPROD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPROD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPROD.Size = new System.Drawing.Size(447, 193);
            this.tabLayPROD.TabIndex = 9;
            // 
            // pBotoesCima
            // 
            this.pBotoesCima.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pBotoesCima.Controls.Add(this.pProduto);
            this.pBotoesCima.Controls.Add(this.btProduto);
            this.pBotoesCima.Controls.Add(this.btRemoveProd);
            this.pBotoesCima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBotoesCima.Location = new System.Drawing.Point(0, 0);
            this.pBotoesCima.Margin = new System.Windows.Forms.Padding(0);
            this.pBotoesCima.Name = "pBotoesCima";
            this.pBotoesCima.Size = new System.Drawing.Size(447, 96);
            this.pBotoesCima.TabIndex = 35;
            // 
            // pProduto
            // 
            this.pProduto.BackColor = System.Drawing.Color.Transparent;
            this.pProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pProduto.BackgroundImage")));
            this.pProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pProduto.Controls.Add(this.label1);
            this.pProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pProduto.Location = new System.Drawing.Point(0, 0);
            this.pProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pProduto.Name = "pProduto";
            this.pProduto.Size = new System.Drawing.Size(447, 33);
            this.pProduto.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btProduto
            // 
            this.btProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btProduto.BackgroundImage = global::Pizzaria.Properties.Resources.BtInserir;
            this.btProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProduto.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.btProduto.ForeColor = System.Drawing.Color.Maroon;
            this.btProduto.Location = new System.Drawing.Point(23, 36);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(120, 50);
            this.btProduto.TabIndex = 5;
            this.ttEncerrar.SetToolTip(this.btProduto, "Inserir Produto - (P)");
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            // 
            // btRemoveProd
            // 
            this.btRemoveProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRemoveProd.BackgroundImage = global::Pizzaria.Properties.Resources.BtRemover;
            this.btRemoveProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRemoveProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRemoveProd.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.btRemoveProd.ForeColor = System.Drawing.Color.White;
            this.btRemoveProd.Location = new System.Drawing.Point(305, 36);
            this.btRemoveProd.Name = "btRemoveProd";
            this.btRemoveProd.Size = new System.Drawing.Size(120, 50);
            this.btRemoveProd.TabIndex = 6;
            this.ttEncerrar.SetToolTip(this.btRemoveProd, "Remover Produto - (R)");
            this.btRemoveProd.UseVisualStyleBackColor = true;
            this.btRemoveProd.Click += new System.EventHandler(this.btRemoveProd_Click);
            // 
            // pMesaNova
            // 
            this.pMesaNova.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pMesaNova.Controls.Add(this.btInseMesa);
            this.pMesaNova.Controls.Add(this.pMesa);
            this.pMesaNova.Controls.Add(this.btMesaTrocar);
            this.pMesaNova.Controls.Add(this.btRemoMesa);
            this.pMesaNova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMesaNova.Location = new System.Drawing.Point(0, 96);
            this.pMesaNova.Margin = new System.Windows.Forms.Padding(0);
            this.pMesaNova.Name = "pMesaNova";
            this.pMesaNova.Size = new System.Drawing.Size(447, 97);
            this.pMesaNova.TabIndex = 0;
            // 
            // btInseMesa
            // 
            this.btInseMesa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInseMesa.BackgroundImage = global::Pizzaria.Properties.Resources.BtInserir;
            this.btInseMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInseMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInseMesa.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.btInseMesa.ForeColor = System.Drawing.Color.Maroon;
            this.btInseMesa.Location = new System.Drawing.Point(23, 40);
            this.btInseMesa.Margin = new System.Windows.Forms.Padding(0);
            this.btInseMesa.Name = "btInseMesa";
            this.btInseMesa.Size = new System.Drawing.Size(120, 50);
            this.btInseMesa.TabIndex = 1;
            this.ttEncerrar.SetToolTip(this.btInseMesa, "Inserir Mesa - (M)");
            this.btInseMesa.UseVisualStyleBackColor = true;
            this.btInseMesa.Click += new System.EventHandler(this.btInseMesa_Click);
            // 
            // pMesa
            // 
            this.pMesa.BackColor = System.Drawing.Color.Transparent;
            this.pMesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pMesa.BackgroundImage")));
            this.pMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMesa.Controls.Add(this.label3);
            this.pMesa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMesa.Location = new System.Drawing.Point(0, 0);
            this.pMesa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pMesa.Name = "pMesa";
            this.pMesa.Size = new System.Drawing.Size(447, 33);
            this.pMesa.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "MESA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMesaTrocar
            // 
            this.btMesaTrocar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btMesaTrocar.BackgroundImage = global::Pizzaria.Properties.Resources.BtTrocar;
            this.btMesaTrocar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMesaTrocar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMesaTrocar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.btMesaTrocar.ForeColor = System.Drawing.Color.White;
            this.btMesaTrocar.Location = new System.Drawing.Point(163, 40);
            this.btMesaTrocar.Margin = new System.Windows.Forms.Padding(0);
            this.btMesaTrocar.Name = "btMesaTrocar";
            this.btMesaTrocar.Size = new System.Drawing.Size(120, 50);
            this.btMesaTrocar.TabIndex = 2;
            this.ttEncerrar.SetToolTip(this.btMesaTrocar, "Trocar Mesa - (T)");
            this.btMesaTrocar.UseVisualStyleBackColor = true;
            this.btMesaTrocar.Click += new System.EventHandler(this.btMesaTrocar_Click);
            // 
            // btRemoMesa
            // 
            this.btRemoMesa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRemoMesa.BackgroundImage = global::Pizzaria.Properties.Resources.BtRemover;
            this.btRemoMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRemoMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRemoMesa.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.btRemoMesa.ForeColor = System.Drawing.Color.White;
            this.btRemoMesa.Location = new System.Drawing.Point(305, 40);
            this.btRemoMesa.Name = "btRemoMesa";
            this.btRemoMesa.Size = new System.Drawing.Size(120, 50);
            this.btRemoMesa.TabIndex = 2;
            this.ttEncerrar.SetToolTip(this.btRemoMesa, "Remover Mesa - (N)");
            this.btRemoMesa.UseVisualStyleBackColor = true;
            this.btRemoMesa.Click += new System.EventHandler(this.btRemoMesa_Click);
            // 
            // tlpVenda
            // 
            this.tlpVenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlpVenda.ColumnCount = 1;
            this.tlpVenda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVenda.Controls.Add(this.panel1, 0, 0);
            this.tlpVenda.Controls.Add(this.tlbBotaoVendas, 0, 1);
            this.tlpVenda.Controls.Add(this.tlpComanda, 0, 2);
            this.tlpVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVenda.Location = new System.Drawing.Point(0, 193);
            this.tlpVenda.Margin = new System.Windows.Forms.Padding(0);
            this.tlpVenda.Name = "tlpVenda";
            this.tlpVenda.RowCount = 3;
            this.tlpVenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.39801F));
            this.tlpVenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.27861F));
            this.tlpVenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.87395F));
            this.tlpVenda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVenda.Size = new System.Drawing.Size(447, 203);
            this.tlpVenda.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lOpcao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 39);
            this.panel1.TabIndex = 9;
            // 
            // lOpcao
            // 
            this.lOpcao.AutoSize = true;
            this.lOpcao.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOpcao.Location = new System.Drawing.Point(112, 7);
            this.lOpcao.Name = "lOpcao";
            this.lOpcao.Size = new System.Drawing.Size(211, 24);
            this.lOpcao.TabIndex = 1;
            this.lOpcao.Text = "OPÇÕES DE VENDA";
            this.lOpcao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlbBotaoVendas
            // 
            this.tlbBotaoVendas.BackColor = System.Drawing.Color.Transparent;
            this.tlbBotaoVendas.ColumnCount = 3;
            this.tlbBotaoVendas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbBotaoVendas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbBotaoVendas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbBotaoVendas.Controls.Add(this.btAnular, 0, 0);
            this.tlbBotaoVendas.Controls.Add(this.btParcial, 2, 0);
            this.tlbBotaoVendas.Controls.Add(this.btEncerrar, 1, 0);
            this.tlbBotaoVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbBotaoVendas.Location = new System.Drawing.Point(6, 41);
            this.tlbBotaoVendas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tlbBotaoVendas.Name = "tlbBotaoVendas";
            this.tlbBotaoVendas.RowCount = 1;
            this.tlbBotaoVendas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbBotaoVendas.Size = new System.Drawing.Size(435, 90);
            this.tlbBotaoVendas.TabIndex = 3;
            // 
            // btAnular
            // 
            this.btAnular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnular.BackgroundImage = global::Pizzaria.Properties.Resources.BtAnular;
            this.btAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnular.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnular.ForeColor = System.Drawing.Color.White;
            this.btAnular.Location = new System.Drawing.Point(4, 23);
            this.btAnular.Name = "btAnular";
            this.btAnular.Size = new System.Drawing.Size(100, 43);
            this.btAnular.TabIndex = 3;
            this.btAnular.Tag = "";
            this.btAnular.UseVisualStyleBackColor = true;
            this.btAnular.Click += new System.EventHandler(this.btAnular_Click);
            // 
            // btParcial
            // 
            this.btParcial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btParcial.BackgroundImage = global::Pizzaria.Properties.Resources.BtSeparar;
            this.btParcial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btParcial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btParcial.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btParcial.ForeColor = System.Drawing.Color.Black;
            this.btParcial.Location = new System.Drawing.Point(329, 23);
            this.btParcial.Margin = new System.Windows.Forms.Padding(0);
            this.btParcial.Name = "btParcial";
            this.btParcial.Size = new System.Drawing.Size(102, 43);
            this.btParcial.TabIndex = 2;
            this.ttEncerrar.SetToolTip(this.btParcial, "Separar Venda - Atalho (S)");
            this.btParcial.UseVisualStyleBackColor = true;
            this.btParcial.Click += new System.EventHandler(this.btParcial_Click);
            // 
            // btEncerrar
            // 
            this.btEncerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEncerrar.BackgroundImage = global::Pizzaria.Properties.Resources.BtEncerrar;
            this.btEncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEncerrar.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.btEncerrar.ForeColor = System.Drawing.Color.Maroon;
            this.btEncerrar.Location = new System.Drawing.Point(135, 14);
            this.btEncerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btEncerrar.Name = "btEncerrar";
            this.btEncerrar.Size = new System.Drawing.Size(162, 62);
            this.btEncerrar.TabIndex = 1;
            this.ttEncerrar.SetToolTip(this.btEncerrar, "Encerrar Venda  - (V)");
            this.btEncerrar.UseVisualStyleBackColor = true;
            this.btEncerrar.Click += new System.EventHandler(this.btEncerrar_Click);
            // 
            // tlpComanda
            // 
            this.tlpComanda.BackColor = System.Drawing.Color.Transparent;
            this.tlpComanda.ColumnCount = 3;
            this.tlpComanda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpComanda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComanda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpComanda.Controls.Add(this.btAgrupar, 2, 0);
            this.tlpComanda.Controls.Add(this.btVoltar, 0, 0);
            this.tlpComanda.Controls.Add(this.btImprimir, 1, 0);
            this.tlpComanda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpComanda.Location = new System.Drawing.Point(6, 131);
            this.tlpComanda.Margin = new System.Windows.Forms.Padding(6, 0, 6, 4);
            this.tlpComanda.Name = "tlpComanda";
            this.tlpComanda.RowCount = 1;
            this.tlpComanda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComanda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpComanda.Size = new System.Drawing.Size(435, 68);
            this.tlpComanda.TabIndex = 4;
            // 
            // btAgrupar
            // 
            this.btAgrupar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAgrupar.BackgroundImage = global::Pizzaria.Properties.Resources.BtAgrupar;
            this.btAgrupar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAgrupar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgrupar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgrupar.ForeColor = System.Drawing.Color.Black;
            this.btAgrupar.Location = new System.Drawing.Point(329, 12);
            this.btAgrupar.Margin = new System.Windows.Forms.Padding(0);
            this.btAgrupar.Name = "btAgrupar";
            this.btAgrupar.Size = new System.Drawing.Size(102, 43);
            this.btAgrupar.TabIndex = 3;
            this.ttEncerrar.SetToolTip(this.btAgrupar, "Agrupar Venda - Atalho (A)");
            this.btAgrupar.UseVisualStyleBackColor = true;
            this.btAgrupar.Click += new System.EventHandler(this.btAgrupar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btVoltar.BackgroundImage = global::Pizzaria.Properties.Resources.Voltar_64;
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVoltar.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.btVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(15, 8);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(78, 52);
            this.btVoltar.TabIndex = 2;
            this.ttEncerrar.SetToolTip(this.btVoltar, "Retornar - (ESC)");
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btImprimir.BackgroundImage = global::Pizzaria.Properties.Resources.BtImprimir;
            this.btImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImprimir.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btImprimir.ForeColor = System.Drawing.Color.White;
            this.btImprimir.Location = new System.Drawing.Point(135, 8);
            this.btImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(162, 52);
            this.btImprimir.TabIndex = 0;
            this.ttEncerrar.SetToolTip(this.btImprimir, "Imprimir - (I)");
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // Venda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 400);
            this.ControlBox = false;
            this.Controls.Add(this.panBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Venda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Venda_KeyDown);
            this.panBut.ResumeLayout(false);
            this.tabLayDescricao.ResumeLayout(false);
            this.menuDireito.ResumeLayout(false);
            this.tlpGAmb.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.pValor.ResumeLayout(false);
            this.pValor.PerformLayout();
            this.tabLayINFO.ResumeLayout(false);
            this.tabLayPROD.ResumeLayout(false);
            this.pBotoesCima.ResumeLayout(false);
            this.pProduto.ResumeLayout(false);
            this.pProduto.PerformLayout();
            this.pMesaNova.ResumeLayout(false);
            this.pMesa.ResumeLayout(false);
            this.pMesa.PerformLayout();
            this.tlpVenda.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlbBotaoVendas.ResumeLayout(false);
            this.tlpComanda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel panBut;
        private System.Windows.Forms.TableLayoutPanel tabLayDescricao;
        private System.Windows.Forms.TableLayoutPanel tlpGAmb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListView lvGarcon;
        private System.Windows.Forms.ColumnHeader codGar;
        private System.Windows.Forms.ColumnHeader nomGar;
        private System.Windows.Forms.Panel pValor;
        private System.Windows.Forms.Label lbSubValor;
        private System.Windows.Forms.ListView lvMesa;
        private System.Windows.Forms.ColumnHeader nomMesa;
        private System.Windows.Forms.ColumnHeader ambient;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Tamanho;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader ValorUni;
        private System.Windows.Forms.ColumnHeader SubTotal;
        private System.Windows.Forms.TableLayoutPanel tabLayINFO;
        private System.Windows.Forms.TableLayoutPanel tabLayPROD;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Button btRemoveProd;
        private System.Windows.Forms.Panel pProduto;
        private System.Windows.Forms.Button btRemoMesa;
        private System.Windows.Forms.Panel pMesa;
        private System.Windows.Forms.TableLayoutPanel tlpVenda;
        private System.Windows.Forms.TableLayoutPanel tlbBotaoVendas;
        private System.Windows.Forms.Button btAnular;
        private System.Windows.Forms.Button btParcial;
        private System.Windows.Forms.Button btEncerrar;
        private System.Windows.Forms.TableLayoutPanel tlpComanda;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.ToolTip ttEncerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lOpcao;
        private System.Windows.Forms.Button btInseMesa;
        private System.Windows.Forms.Button btMesaTrocar;
        private System.Windows.Forms.Panel pBotoesCima;
        private System.Windows.Forms.Panel pMesaNova;
        private System.Windows.Forms.Button btAgrupar;
        private System.Windows.Forms.ContextMenuStrip menuDireito;
        private System.Windows.Forms.ToolStripMenuItem ttRemoverUm;
        private System.Windows.Forms.ToolStripMenuItem ttRemoverTodos;
        private System.Windows.Forms.ToolStripSeparator separador;
        private System.Windows.Forms.ToolStripMenuItem MSProduto;
        private System.Windows.Forms.ToolStripMenuItem reimpressãoToolStripMenuItem;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbComissao;
    }
}