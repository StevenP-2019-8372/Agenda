using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_entidad;
using Capa_negocio;

namespace agendasp
{
    public partial class Form1 : Form
    {
        Classentidad objent = new Classentidad();
        Classnegocio objneg = new Classnegocio();

        public Form1()
        {
            InitializeComponent();
        }
        void mantenimiento(string accion)
        {
            objent.id = tid.Text;
            objent.nombre = tnombre.Text;
            objent.apellido = tapellido.Text;
            objent.direccion = tdireccion.Text;
            objent.accion = accion;
            String men = objneg.N_mantenimiento_cliente(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            tid.Text = "";
            tnombre.Text = "";
            tapellido.Text = "";
            tdireccion.Text = "";
            dataGridView1.DataSource = objneg.N_listar_clientes();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_clientes();
        }

        private void tbuscar_TextChanged(object sender, EventArgs e)
        {
            if (tbuscar.Text != "")
            {
                objent.nombre = tbuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_clientes(objent);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objneg.N_listar_clientes();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            tid.Text = dataGridView1[0, fila].Value.ToString();
            tnombre.Text = dataGridView1[1, fila].Value.ToString();
            tapellido.Text = dataGridView1[2, fila].Value.ToString();
            tdireccion.Text = dataGridView1[3, fila].Value.ToString();
        }

        private void button1limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button4modificar_Click(object sender, EventArgs e)
        {
            if (tid.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + tnombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void button3eliminar_Click(object sender, EventArgs e)
        {
            if (tid.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + tnombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void button2registrar_Click(object sender, EventArgs e)
        {
            if (tid.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + tnombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    mantenimiento("1");
                    limpiar();
                }
            }
        }
    }
}
