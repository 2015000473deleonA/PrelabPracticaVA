using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRELABORATORIO_I___PRACTICA_SUPERVISADA
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }
        int codigo1 = 1;
        void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }
        private void CRUD_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object[] agregardato =
            {
                codigo1.ToString(),
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text,
                textBox7.Text,
                textBox8.Text,
                textBox9.Text,
                textBox10.Text,
                textBox11.Text,
        };
            dataGridView1.Rows.Add(agregardato);
            MessageBox.Show("Dato Registrado", "Mensaje");
            codigo1++;
            textBox11.Text = codigo1.ToString();
            limpiar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int indice = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[indice].Cells[1].Value = textBox1.Text;
                dataGridView1.Rows[indice].Cells[2].Value = textBox2.Text;
                dataGridView1.Rows[indice].Cells[3].Value = textBox3.Text;
                dataGridView1.Rows[indice].Cells[4].Value = textBox4.Text;
                dataGridView1.Rows[indice].Cells[5].Value = textBox5.Text;
                dataGridView1.Rows[indice].Cells[6].Value = textBox6.Text;
                dataGridView1.Rows[indice].Cells[7].Value = textBox7.Text;
                dataGridView1.Rows[indice].Cells[8].Value = textBox8.Text;
                dataGridView1.Rows[indice].Cells[9].Value = textBox9.Text;
                dataGridView1.Rows[indice].Cells[10].Value = textBox10.Text;
                dataGridView1.Rows[indice].Cells[11].Value = textBox11.Text;
                MessageBox.Show("Dato modificado");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int fila = dataGridView1.CurrentCell.RowIndex;
                textBox1.Text = dataGridView1[1, fila].Value.ToString();
                textBox2.Text = dataGridView1[2, fila].Value.ToString();
                textBox3.Text = dataGridView1[3, fila].Value.ToString();
                textBox4.Text = dataGridView1[4, fila].Value.ToString();
                textBox5.Text = dataGridView1[5, fila].Value.ToString();
                textBox6.Text = dataGridView1[6, fila].Value.ToString();
                textBox7.Text = dataGridView1[7, fila].Value.ToString();
                textBox8.Text = dataGridView1[8, fila].Value.ToString();
                textBox9.Text = dataGridView1[9, fila].Value.ToString();
                textBox10.Text = dataGridView1[10, fila].Value.ToString();
                textBox11.Text = dataGridView1[11, fila].Value.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CREDITOS cambio1 = new CREDITOS();
            cambio1.Show();
        }
    }
}
