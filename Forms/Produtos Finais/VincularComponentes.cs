using Google.Protobuf.Collections;
using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;
using MovSoft.Controls;
using System.Windows.Forms;

namespace MovSoft.Forms
{
    public partial class VincularComponentes : Form
    {
        ProdutoCompostoBLL produtoCompostoBLL = new();
        DataGridViewRow rowData = new();
        int idProdutoGlobal;
        public VincularComponentes(int idProduto)
        {
            InitializeComponent();
            ComponentesDisponiveis(idProduto);
            ComponentesDoProduto(idProduto);
            idProdutoGlobal = idProduto;
            DataGridViewColumn column = new();
            column.CellTemplate = new DataGridViewTextBoxCell();
            column.Name = "Excluir";
            column.ValueType = typeof(string);
            column.HeaderText = "Excluir";
            dataGridViewVincularComponentes.Columns.Add(column);
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Essa opção está indisponível no momento!", "Opção indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            VincularComponente();
        }

        private void ComponentesDisponiveis(int idProduto)
        {
            MapField<string?, bool?> componentes = new();
            componentes = produtoCompostoBLL.ComponentesDisponiveis(idProduto);
            for (int i = 0; i < componentes.Count; i++)
            {
                checkedListBox.Items.Add(componentes.Keys.ElementAt(i), (bool)componentes.Values.ElementAt(i));
            }
        }

        private void ComponentesDoProduto(int idProduto)
        {
            dataGridViewVincularComponentes.ReadOnly = false;
            dataGridViewVincularComponentes.DataSource = produtoCompostoBLL.MostrarComponentesDoProdutoGridView(idProduto);
            dataGridViewVincularComponentes.Columns["Quantidade"].ReadOnly = false;
            dataGridViewVincularComponentes.Columns["Quantidade"].DefaultCellStyle.Format = "N3";
            foreach (DataGridViewColumn column in dataGridViewVincularComponentes.Columns)
            {
                if (column.Name != "Quantidade")
                {
                    column.ReadOnly = true;
                }
                if (column.Name == "ID")
                {
                    column.Width = 50;
                }
                else if (column.Name == "Excluir")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void dataGridViewVincularComponentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewVincularComponentes.Columns[e.ColumnIndex].Name == "Excluir")
            {                
                DialogResult result = MessageBox.Show("Realmete deseja remover esse componente desse produto", "Confirmação de Alteração", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    rowData = dataGridViewVincularComponentes.Rows[e.RowIndex];
                    produtoCompostoBLL.DesvincularComponentes(1, int.Parse(rowData.Cells["ID"].Value.ToString()));
                    ComponentesDoProduto(idProdutoGlobal);
                }
            }
        }

        private void dataGridViewVincularComponentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewVincularComponentes.Columns[e.ColumnIndex].Name == "Excluir")
            {
                e.Value = "0";
            }
        }

        private void VincularComponente()
        {
            ProdutoCompostoDTO produtoCompostoDTO = new();
            produtoCompostoDTO.IdProduto = idProdutoGlobal;
            produtoCompostoDTO.Componente = checkedListBox.CheckedItems.Cast<string>().ToList();
            produtoCompostoBLL.VincularComponentes(produtoCompostoDTO);
            ComponentesDoProduto(idProdutoGlobal);
        }

        private void dataGridViewVincularComponentes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente alterar a quantidade desse componente no produto", "Confirmação de Alteração", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                produtoCompostoBLL.EditarQuantidadeComponenteNoProduto(1, int.Parse(dataGridViewVincularComponentes.Rows[e.RowIndex].Cells["ID"].Value.ToString()), float.Parse(dataGridViewVincularComponentes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
            }
            else
            {
                ComponentesDoProduto(idProdutoGlobal);
            }
        }

        private void btnVincular_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
