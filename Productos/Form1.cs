using Productos.Dao;
using System.Windows.Forms;

namespace Productos
{
    public partial class Form1 : Form
    {
        ProductoDao dao = new ProductoDao();
        public Form1()
        {
            InitializeComponent();
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            this.dgvRegistros.DataSource = dao.VerCarrito();
            this.dgvRegistros.Refresh();
        }

        private void btnRegistrar_Click(object sender, System.EventArgsArgs e)
        {
            ProductoDao prod = new ProductoDao();
            prod.Nombre = tbNombre.Text.ToUpper();
            prod.Codigo = TextBoxCodigo.Tect.ToUpper();
            prod.Precio = double.Parse(tbPrecio.Text);
            prod.IVA = chkIVA.Checked;
            dao.Agregar(prod);
            LlenarGrid();
        }
    }
}
