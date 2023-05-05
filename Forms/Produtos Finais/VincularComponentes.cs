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
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Excluir";
            imageColumn.HeaderText = "";
            imageColumn.Image = Properties.Resources.icon_delete;
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewVincularComponentes.Columns.Add(imageColumn);
            dataGridViewVincularComponentes.ShowEditingIcon = true;
        }


        private void btnVincular_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Essa opção está indisponível no momento!", "Opção indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            VincularComponente();
        }

        private void ComponentesDisponiveis(int idProduto)
        {
            checkedListBox.Items.Clear();
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
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                if (e.RowIndex == -1)
                {
                    DialogResult result = MessageBox.Show("Realmete deseja remover todos os componentes do produto?", "Confirmação de Alteração", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        foreach (DataGridViewRow row in dataGridViewVincularComponentes.Rows)
                        {
                            rowData = dataGridViewVincularComponentes.Rows[row.Index];
                            produtoCompostoBLL.DesvincularComponentes(idProdutoGlobal, int.Parse(rowData.Cells["ID"].Value.ToString()), true);
                        }
                        ComponentesDoProduto(idProdutoGlobal);
                        ComponentesDisponiveis(idProdutoGlobal);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Realmete deseja remover esse componente desse produto", "Confirmação de Alteração", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        rowData = dataGridViewVincularComponentes.Rows[e.RowIndex];
                        produtoCompostoBLL.DesvincularComponentes(idProdutoGlobal, int.Parse(rowData.Cells["ID"].Value.ToString()));
                        ComponentesDoProduto(idProdutoGlobal);
                        ComponentesDisponiveis(idProdutoGlobal);
                    }
                }
            }
        }

        private void VincularComponente()
        {
            ProdutoCompostoDTO produtoCompostoDTO = new();
            produtoCompostoDTO.IdProduto = idProdutoGlobal;
            produtoCompostoDTO.Componente = checkedListBox.CheckedItems.Cast<string>().ToList();
            produtoCompostoBLL.VincularComponentes(produtoCompostoDTO);
            ComponentesDoProduto(idProdutoGlobal);
            dataGridViewVincularComponentes.CurrentCell = dataGridViewVincularComponentes.Rows[dataGridViewVincularComponentes.Rows.Count - 1].Cells[0];
        }

        private void dataGridViewVincularComponentes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente alterar a quantidade desse componente no produto", "Confirmação de Alteração", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                BeginInvoke(new MethodInvoker(() =>
                {
                    produtoCompostoBLL.EditarQuantidadeComponenteNoProduto(idProdutoGlobal, int.Parse(dataGridViewVincularComponentes.Rows[e.RowIndex].Cells["ID"].Value.ToString()), float.Parse(dataGridViewVincularComponentes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
                }));
            }
            else
            {
                BeginInvoke(new MethodInvoker(() =>
                {
                    ComponentesDoProduto(idProdutoGlobal);
                }));
            }
        }

        private void btnVincular_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewVincularComponentes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dataGridViewVincularComponentes.Columns[e.ColumnIndex].Name == "Excluir" && e.RowIndex == -1) // Header da Coluna
            {
                e.PaintBackground(e.CellBounds, true);
                Image image = Properties.Resources.icon_delete_azul;
                int padding = -1;
                Rectangle rect = new Rectangle(e.CellBounds.X + padding, e.CellBounds.Y + padding, e.CellBounds.Height - (2 * padding), e.CellBounds.Height - (2 *
                    padding));
                e.Graphics.DrawImage(image, rect);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }
    }
}
