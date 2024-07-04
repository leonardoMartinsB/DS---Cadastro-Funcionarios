namespace WfaCadFuncionários
{
    partial class FrmFuncionários
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionários));
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grpCampos = new System.Windows.Forms.GroupBox();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.btn_AddFoto = new System.Windows.Forms.Button();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.labelDatanasc = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.txtList = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluir.Location = new System.Drawing.Point(12, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(73, 53);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.Location = new System.Drawing.Point(127, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 53);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApagar.Location = new System.Drawing.Point(237, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(81, 53);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "&Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(356, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(86, 53);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.Location = new System.Drawing.Point(808, 14);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(68, 51);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnListar
            // 
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListar.Location = new System.Drawing.Point(701, 14);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 51);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "&Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.Location = new System.Drawing.Point(581, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 51);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.Location = new System.Drawing.Point(469, 14);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(82, 51);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // grpCampos
            // 
            this.grpCampos.BackColor = System.Drawing.Color.LightGray;
            this.grpCampos.Controls.Add(this.pb_foto);
            this.grpCampos.Controls.Add(this.btn_AddFoto);
            this.grpCampos.Controls.Add(this.datetime);
            this.grpCampos.Controls.Add(this.txtEndereco);
            this.grpCampos.Controls.Add(this.txtIdade);
            this.grpCampos.Controls.Add(this.labelDatanasc);
            this.grpCampos.Controls.Add(this.labelIdade);
            this.grpCampos.Controls.Add(this.txtId);
            this.grpCampos.Controls.Add(this.labelEndereco);
            this.grpCampos.Controls.Add(this.txtNome);
            this.grpCampos.Controls.Add(this.labelNome);
            this.grpCampos.Controls.Add(this.labelId);
            this.grpCampos.Location = new System.Drawing.Point(127, 103);
            this.grpCampos.Name = "grpCampos";
            this.grpCampos.Size = new System.Drawing.Size(649, 253);
            this.grpCampos.TabIndex = 21;
            this.grpCampos.TabStop = false;
            this.grpCampos.Text = "Dados do Funcionário";
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Image = ((System.Drawing.Image)(resources.GetObject("pb_foto.Image")));
            this.pb_foto.Location = new System.Drawing.Point(410, 36);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(191, 141);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 23;
            this.pb_foto.TabStop = false;
            this.pb_foto.UseWaitCursor = true;
            // 
            // btn_AddFoto
            // 
            this.btn_AddFoto.Location = new System.Drawing.Point(410, 189);
            this.btn_AddFoto.Name = "btn_AddFoto";
            this.btn_AddFoto.Size = new System.Drawing.Size(191, 27);
            this.btn_AddFoto.TabIndex = 13;
            this.btn_AddFoto.Text = "ADICIONAR IMAGEM";
            this.btn_AddFoto.UseVisualStyleBackColor = true;
            this.btn_AddFoto.Click += new System.EventHandler(this.btn_AddFoto_Click);
            // 
            // datetime
            // 
            this.datetime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime.Location = new System.Drawing.Point(147, 197);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(100, 20);
            this.datetime.TabIndex = 12;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(134, 118);
            this.txtEndereco.MaxLength = 70;
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(133, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(134, 157);
            this.txtIdade.MaxLength = 3;
            this.txtIdade.Multiline = true;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(133, 20);
            this.txtIdade.TabIndex = 11;
            // 
            // labelDatanasc
            // 
            this.labelDatanasc.AutoSize = true;
            this.labelDatanasc.Location = new System.Drawing.Point(30, 203);
            this.labelDatanasc.Name = "labelDatanasc";
            this.labelDatanasc.Size = new System.Drawing.Size(107, 13);
            this.labelDatanasc.TabIndex = 18;
            this.labelDatanasc.Text = "Data de Nascimento:";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(79, 164);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(37, 13);
            this.labelIdade.TabIndex = 17;
            this.labelIdade.Text = "Idade:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(134, 36);
            this.txtId.MaxLength = 5;
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(133, 20);
            this.txtId.TabIndex = 8;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(63, 125);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 13);
            this.labelEndereco.TabIndex = 16;
            this.labelEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(134, 78);
            this.txtNome.MaxLength = 50;
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 20);
            this.txtNome.TabIndex = 9;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(81, 85);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(41, 13);
            this.labelNome.TabIndex = 15;
            this.labelNome.Text = "Nome: ";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(97, 43);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 14;
            this.labelId.Text = "ID:";
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(127, 362);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ReadOnly = true;
            this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtList.Size = new System.Drawing.Size(649, 240);
            this.txtList.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmFuncionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(888, 614);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.grpCampos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFuncionários";
            this.Text = "Cadastro de Funcionário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFuncionários_FormClosing);
            this.Load += new System.EventHandler(this.FrmFuncionários_Load);
            this.grpCampos.ResumeLayout(false);
            this.grpCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox grpCampos;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Button btn_AddFoto;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label labelDatanasc;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

