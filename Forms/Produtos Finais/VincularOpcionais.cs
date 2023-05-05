using Google.Protobuf.Collections;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;

namespace MovSoft.Forms
{
    public partial class VincularOpcionais : Form
    {
        ProdutoCompostoBLL produtoCompostoBLL = new();
        DataGridViewRow rowData = new();
        int idProdutoGlobal;
        public VincularOpcionais(int idProduto)
        {
            InitializeComponent();
            OpcionaisDisponiveis(idProduto);
            OpcionaisDoProduto(idProduto);
            idProdutoGlobal = idProduto;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Excluir";
            imageColumn.HeaderText = "";
            imageColumn.Image = Properties.Resources.icon_delete;
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewVincularOpcionais.Columns.Add(imageColumn);
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Essa opção está indisponível no momento!", "Opção indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            VincularOpcional();
        }

        private void OpcionaisDisponiveis(int idProduto)
        {
            checkedListBox.Items.Clear();
            MapField<string?, bool?> Opcionais = new();
            Opcionais = produtoCompostoBLL.OpcionaisDisponiveis(idProduto);
            for (int i = 0; i < Opcionais.Count; i++)
            {
                checkedListBox.Items.Add(Opcionais.Keys.ElementAt(i), (bool)Opcionais.Values.ElementAt(i));
            }
        }

        private void OpcionaisDoProduto(int idProduto)
        {
            dataGridViewVincularOpcionais.DataSource = produtoCompostoBLL.MostrarOpcionaisDoProdutoGridView(idProduto);
            dataGridViewVincularOpcionais.Columns["Quantidade Marcacoes"].HeaderText = "Quantidade Marcações";
            foreach (DataGridViewColumn column in dataGridViewVincularOpcionais.Columns)
            {
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

        private void dataGridViewVincularOpcionais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewVincularOpcionais.Columns[e.ColumnIndex].Name == "Excluir")
            {
                if (e.RowIndex == -1)
                {
                    DialogResult result = MessageBox.Show("Realmete deseja remover todos os opcionais desse produto?", "Confirmação de Alteração", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        foreach (DataGridViewRow row in dataGridViewVincularOpcionais.Rows)
                        {
                            rowData = dataGridViewVincularOpcionais.Rows[row.Index];
                            produtoCompostoBLL.DesvincularOpcionais(idProdutoGlobal, int.Parse(rowData.Cells["ID"].Value.ToString()), true);
                        }
                        OpcionaisDoProduto(idProdutoGlobal);
                        OpcionaisDisponiveis(idProdutoGlobal);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Realmete deseja remover esse opcional desse produto", "Confirmação de Alteração", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        rowData = dataGridViewVincularOpcionais.Rows[e.RowIndex];
                        produtoCompostoBLL.DesvincularOpcionais(idProdutoGlobal, int.Parse(rowData.Cells["ID"].Value.ToString()));
                        OpcionaisDoProduto(idProdutoGlobal);
                        OpcionaisDisponiveis(idProdutoGlobal);
                    }
                }
            }
        }

        private void VincularOpcional()
        {
            ProdutoCompostoDTO produtoCompostoDTO = new();
            produtoCompostoDTO.IdProduto = idProdutoGlobal;
            produtoCompostoDTO.Opcional = checkedListBox.CheckedItems.Cast<string>().ToList();
            produtoCompostoBLL.VincularOpcionais(produtoCompostoDTO);
            OpcionaisDoProduto(idProdutoGlobal);
            dataGridViewVincularOpcionais.CurrentCell = dataGridViewVincularOpcionais.Rows[dataGridViewVincularOpcionais.Rows.Count - 1].Cells[0];
        }

        private void btnVincular_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewVincularOpcionais_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dataGridViewVincularOpcionais.Columns[e.ColumnIndex].Name == "Excluir" && e.RowIndex == -1) // Header da Coluna
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
