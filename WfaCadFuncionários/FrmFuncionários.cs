using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaCadFuncionários
{
    public partial class FrmFuncionários : Form
    {
        List<Funcionario> funcionarios;
        bool incluir = false;
        public FrmFuncionários()
        {
            InitializeComponent();
            funcionarios = new List<Funcionario>();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            HabilitaCampos(grpCampos, true);
            HabilitaBotoes(this, false);
            btnCancelar.Enabled = true;
            incluir = true;
            txtId.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "&Editar")
            {
                btnEditar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = true;
                txtId.Enabled = true;
                txtId.Focus();

                btnEditar.Text = "&Procurar";
                MessageBox.Show("Informe o ID do Funcionário desejado(a):", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    bool encontrou = false;
                    foreach (Funcionario func in funcionarios)
                    {
                        if (func.FuncionarioId == Int32.Parse(txtId.Text))
                        {
                            txtId.Text = func.FuncionarioId.ToString();
                            txtNome.Text = func.Nome;
                            txtEndereco.Text = func.Endereco.ToString();
                            txtIdade.Text = func.Idade.ToString();
                            datetime.Value = func.Datanasc;
                            pb_foto.Image = Image.FromFile(func.Foto);


                            encontrou = true;
                            HabilitaCampos(grpCampos, true);
                            HabilitaBotoes(this, false);
                            txtId.Enabled = false;
                            txtNome.Focus();
                        }
                    }
                    if (!encontrou)
                    {
                        MessageBox.Show("Funcionário não encontrada!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
             if(btnApagar.Text == "&Apagar")
            {
                HabilitaBotoes(this, false);
                btnApagar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = true;
                txtId.Enabled = true;
                txtId.Focus();
                btnApagar.Text = "&Confirmar";
                MessageBox.Show("Informe o ID do Funcionário desejado(a):\n", "Aviso:",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    bool encontrou = false;
                    foreach(Funcionario func in funcionarios)
                    {
                        if (func.FuncionarioId == Int32.Parse(txtId.Text))
                        {
                            encontrou = true;
                            if (MessageBox.Show("Deseja mesmo apagar esse funcionário?", "Aviso", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                funcionarios.Remove(func);
                                btnCancelar_Click(null, null);
                                break;

                            }
                        }
                    }
                    if(!encontrou)
                    {
                        //MessageBox.Show("Funcionário não encontrado!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (btnPesquisar.Text == "&Pesquisar")
            {
                HabilitaBotoes(this, false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = true;
                btn_AddFoto.Enabled = false;
                txtId.Enabled = true;
                txtNome.Enabled = false;
                txtIdade.Enabled = false;
                txtEndereco.Enabled = false;
                datetime.Enabled = false;
                txtId.Focus();
                btnPesquisar.Text = "&Confirmar";
                MessageBox.Show("Informe o Id do Funcionário desejado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnPesquisar.Text = "&Pesquisar";
                try
                {
                    bool encontrou = false;
                    HabilitaBotoes(this, true);
                    HabilitaCampos(grpCampos, true);
                    foreach (Funcionario func in funcionarios)
                    {
                        if (func.FuncionarioId == Int32.Parse(txtId.Text))
                        {
                            encontrou = true;
                            txtList.Clear();
                            txtList.Text = func.ToString();
                            pb_foto.Image = Image.FromFile(func.Foto);
                            HabilitaCampos(grpCampos, false);

                        }
                    }
                    if (!encontrou)
                    {
                        MessageBox.Show("Funcionário não encontrado!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bool encontrou = false;

            Funcionario funcionario = new Funcionario();
            try
            {
                funcionario.FuncionarioId = Int32.Parse(txtId.Text);
                funcionario.Nome = txtNome.Text;
                funcionario.Endereco = txtEndereco.Text;
                funcionario.Idade = Int32.Parse(txtIdade.Text);
                funcionario.Datanasc = datetime.Value;
                funcionario.Foto = pb_foto.ImageLocation;
                if (incluir)
                {
                    funcionarios.Add(funcionario);
                }
                else
                {
                    foreach (Funcionario func in funcionarios)
                    {
                        if (func.FuncionarioId == funcionario.FuncionarioId)
                        {
                            func.Nome = funcionario.Nome;
                            func.Endereco = funcionario.Endereco;
                            func.Idade = funcionario.Idade;
                            func.Datanasc = funcionario.Datanasc;
                            func.Foto = funcionario.Foto;
                        }
                    }
                    if (!encontrou)
                    {
                        //MessageBox.Show("Funcionário não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!\n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCancelar_Click(null, null);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaCampos(grpCampos, false);
            HabilitaBotoes(this, true);
            LimpaCampo(grpCampos);
            btnEditar.Text = "&Editar";
            btnApagar.Text = "&Apagar";
            incluir = false;    
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtList.Clear();
            foreach (Funcionario item in funcionarios)
            {
                txtList.Text += item.ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HabilitaCampos(Control container, bool hab)
        {
            foreach (Control campo in container.Controls)
            {
                if (!(campo is Label))
                {
                    campo.Enabled = hab;
                }
            }
        }
        private void HabilitaBotoes(Control container, bool hab)
        {
            foreach (Control componente in container.Controls)
            {
                if (componente is Button)
                {
                    componente.Enabled = hab;
                    if (componente.Name == "btnGravar" || componente.Name == "btnCancelar_Click")
                    {
                        componente.Enabled = !hab;
                    }
                }
            }
        }
        private void LimpaCampo(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();

                }
                else if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();

                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
            }
        }

        private void btn_AddFoto_Click(object sender, EventArgs e)
        {
            string origemCompleto = "";
            string foto = "";
            string pastaDestino = "";
            string DestinoCompleto = "";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                DestinoCompleto = pastaDestino + foto;

            }
            if (File.Exists(DestinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja subistuir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;


                }

            }
            System.IO.File.Copy(origemCompleto, DestinoCompleto, true);

            if (File.Exists(DestinoCompleto))
            {
                pb_foto.ImageLocation = DestinoCompleto;

            }
            else
            {
                MessageBox.Show("Arquivo não copiado");
            }
            File.Copy(openFileDialog1.FileName, Path.Combine(@"../../imagens", Path.GetFileName(openFileDialog1.FileName)), true);

        }

        private void FrmFuncionários_Load(object sender, EventArgs e)
        {
            HabilitaBotoes(this, false);
            btnGravar.Enabled = false;
            HabilitaCampos(grpCampos, false);
            btnIncluir.Enabled = true;
        }

        private void FrmFuncionários_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
