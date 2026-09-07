using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaVentas
{
    internal class Funciones
    {
        AccesoBaseDatos acceso = new AccesoBaseDatos();

        private Form activeForm = null;

        public void CondicionCajaLlena(out string usuvar, TextBox textBox, string texto)
        {
            usuvar = textBox.Text == texto ? null : textBox.Text;
        }

        public void CondicionComboLleno(out string usuvar, ComboBox comboBox, string texto)
        {
            usuvar = comboBox.Text == texto ? null : comboBox.Text;
        }

        public void mostrarFormularioHijo(Form formularioHijo, Panel formularioHijoPanel)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            formularioHijoPanel.Controls.Add(formularioHijo);
            formularioHijoPanel.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        public void botonCheked(RadioButton radioButton, Form formularioMostrar, Panel ubicacionPanel)
        {
            if (radioButton.Checked)
                mostrarFormularioHijo(formularioMostrar, ubicacionPanel);
        }

        public void SiNoMascFem(out string opcion, RadioButton radioButtonfem, RadioButton radioButtonMasc)
        {
            if (radioButtonfem.Checked)
            {
                opcion = "F";
            }
            else if (radioButtonMasc.Checked)
            {
                opcion = "M";
            }
            else
            {
                opcion = string.Empty;
            }
        }

        public void obtenerDatosUsuario(string query, string usuario, out string dato)
        {
            using (SqlConnection cn = new SqlConnection(acceso.cadena))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@alias", usuario);
                dato = (string)cmd.ExecuteScalar();
            }
        }

        public void obtenerID(string query, string nombre, string parametro, out int id)
        {
            using (SqlConnection cn = new SqlConnection(acceso.cadena))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue(parametro, nombre);
                id = (int)cmd.ExecuteScalar();
            }
        }

        public void ConfigurarPlaceholder(TextBox textBox, string placeholder, Label label)
        {
            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
                label.Visible = true;
                label.ForeColor = Color.CornflowerBlue;
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                    label.Visible = false;
                }
            };

            // Inicializar con el placeholder
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            label.Visible = false;
        }

        public void ConfigurarPlaceholderNoLabel(TextBox textBox, string placeholder)
        {
            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };

            // Inicializar con el placeholder
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
        }

        public void CargarDataGridView(
            DataGridView dgv,
            string connectionString,
            string query,
            List<SqlParameter> parametros,
            List<ColumnaDefinicion> columnas,
            bool incluirBotones = false)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);

                if (parametros != null)
                {
                    foreach (var p in parametros)
                        cmd.Parameters.Add(p);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dgv.Columns.Clear();
                dgv.AutoGenerateColumns = false;

                // Crear columnas según la definición
                foreach (var col in columnas)
                {
                    dgv.Columns.Add(col.NombreInterno, col.Encabezado);
                    dgv.Columns[col.NombreInterno].DataPropertyName = col.CampoTabla;
                }

                // Opcional: añadir botones
                if (incluirBotones)
                {
                    DataGridViewButtonColumn botonEditar = new DataGridViewButtonColumn
                    {
                        HeaderText = "",
                        Name = "botonEditar",
                        Text = "Editar",
                        UseColumnTextForButtonValue = true
                    };
                    dgv.Columns.Add(botonEditar);

                    DataGridViewButtonColumn botonBorrar = new DataGridViewButtonColumn
                    {
                        HeaderText = "",
                        Name = "botonBorrar",
                        Text = "Borrar",
                        UseColumnTextForButtonValue = true
                    };
                    dgv.Columns.Add(botonBorrar);
                }

                dgv.DataSource = table;
                dgv.AllowUserToAddRows = false;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public void RegDatBasDat(string cadenaConexion, string query, List<SqlParameter> parametros)
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);

                if (parametros != null)
                {
                    foreach (var p in parametros)
                        cmd.Parameters.Add(p);
                }
                cmd.ExecuteNonQuery();
            }
        }

        public void CargaComboBox(string query, ComboBox comboBox, string mostrar, string id, string catg)
        {
            comboBox.Enter += (s, e) =>
            {
                if (comboBox.Text == mostrar)
                {
                    comboBox.Text = "";
                    comboBox.ForeColor = Color.Black;
                }

            };

            comboBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(comboBox.Text))
                {
                    comboBox.Text = mostrar;
                    comboBox.ForeColor = Color.Gray;
                }
            };

            using (SqlConnection cn = new SqlConnection(acceso.cadena))
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.SelectCommand.Parameters.AddWithValue("@usuario", UsuarioIniciado.usuario);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox.DataSource = dt;
                comboBox.DisplayMember = catg;
                comboBox.ValueMember = id;
                comboBox.SelectedIndex = -1;
                comboBox.Text = mostrar;
            }

            comboBox.ForeColor = Color.Gray;
        }

        public void CargaComboBox(string query, ComboBox comboBox, string mostrar, string id, string catg, Label label)
        {
            comboBox.Enter += (s, e) =>
            {
                if (comboBox.Text == mostrar)
                {
                    comboBox.Text = "";
                    comboBox.ForeColor = Color.Black;
                    label.Visible = true;
                }

            };

            comboBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(comboBox.Text))
                {
                    comboBox.Text = mostrar;
                    comboBox.ForeColor = Color.Gray;
                    label.Visible = false;
                }
            };

            using (SqlConnection cn = new SqlConnection(acceso.cadena))
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.SelectCommand.Parameters.AddWithValue("@usuario", UsuarioIniciado.usuario);

                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox.DataSource = dt;
                comboBox.DisplayMember = catg;
                comboBox.ValueMember = id;
                comboBox.SelectedIndex = -1;
                comboBox.Text = mostrar;
            }
            comboBox.ForeColor = Color.Gray;
            label.Visible = false;
        }

        public void PanelClick(Panel panel)
        {
            panel.Click += (s, e) =>
            {
                panel.Focus();
            };
        }

        public void GroupBoxClick(GroupBox groupBox)
        {
            groupBox.Click += (s, e) =>
            {
                groupBox.Focus();
            };

        }
    }
}