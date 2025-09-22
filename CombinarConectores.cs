using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace RotoConectorHerraje
{
    public partial class CombinarConectores : Form
    {
        private string ConnectionString { get; set; }
        private string Server { get; set; }
        private string BaseDatos { get; set; }

        public CombinarConectores()
        {
            InitializeComponent();
        }

        public CombinarConectores(string ConnectionString, string Server, string BaseDatos)
        {
            InitializeComponent();
            this.ConnectionString = ConnectionString;
            this.Server = Server;   
            this.BaseDatos = BaseDatos;
        }

        private void CombinarConectores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            lbl_Conexion.Text = Server + @"\" + BaseDatos;
        }

        private void CargarDatos()
        {
            List<string> conectoresList = new List<string>();
            using SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();

            using SqlCommand cmd = new SqlCommand("SELECT Codigo, XML FROM ConectorHerrajes", conexion);
            using SqlDataReader reader = cmd.ExecuteReader();

            conectoresList.Clear();

            while (reader.Read())
            {
                conectoresList.Add(reader[0].ToString());
            }

            listBox_AllConectores.Items.Clear();
            foreach (string conector in conectoresList.OrderBy(c => c))
            {
                listBox_AllConectores.Items.Add(conector);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (listBox_AllConectores.SelectedItem != null)
            {
                var item = listBox_AllConectores.SelectedItem;
                listBox_Combinar.Items.Add(item);
                listBox_AllConectores.Items.Remove(item);
            }
        }

        private void btn_Add_All_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox_AllConectores.Items)
            {
                listBox_Combinar.Items.Add(item);
            }
            listBox_AllConectores.Items.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Combinar.SelectedItem != null)
            {
                var item = listBox_Combinar.SelectedItem;
                listBox_AllConectores.Items.Add(item);
                listBox_Combinar.Items.Remove(item);
            }
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox_Combinar.Items)
            {
                listBox_AllConectores.Items.Add(item);
            }
            listBox_Combinar.Items.Clear();
        }

        private Connector CargarConectorDesdeBaseDeDatos(string conectorName)
        {
            try
            {
                string xmlString = null;

                using (var conexion = new SqlConnection(ConnectionString))
                {
                    conexion.Open();

                    var query = "SELECT XML FROM ConectorHerrajes WHERE Codigo = @codigo";
                    using var cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@codigo", conectorName);

                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        xmlString = result.ToString();
                    }
                }

                if (!string.IsNullOrWhiteSpace(xmlString))
                {
                    return DeserializarXML<Connector>(xmlString);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el conector: " + conectorName);
                return null;
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (listBox_Combinar.SelectedItem == null) return;

            int index = listBox_Combinar.SelectedIndex;
            if (index > 0) // no subir si ya está en la primera posición
            {
                var item = listBox_Combinar.SelectedItem;

                listBox_Combinar.Items.RemoveAt(index);
                listBox_Combinar.Items.Insert(index - 1, item);

                listBox_Combinar.SelectedIndex = index - 1; // mantener selección
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (listBox_Combinar.SelectedItem == null) return;

            int index = listBox_Combinar.SelectedIndex;
            if (index < listBox_Combinar.Items.Count - 1) // no bajar si ya está en la última posición
            {
                var item = listBox_Combinar.SelectedItem;

                listBox_Combinar.Items.RemoveAt(index);
                listBox_Combinar.Items.Insert(index + 1, item);

                listBox_Combinar.SelectedIndex = index + 1; // mantener selección
            }
        }

        private T DeserializarXML<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var reader = new StringReader(xml);
            return (T)serializer.Deserialize(reader);
        }

        private string SerializarXml<T>(T objeto)
        {
            using (var stringWriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringWriter, objeto);
                return stringWriter.ToString();
            }
        }

        private void GuardarConectorEnBD(string xml)
        {
            try
            {
                string sql = @"INSERT INTO ConectorHerrajes (DataVerId, Codigo, XML) VALUES (dbo.GetCurrentDVID(), @Codigo, @Xml);";
                //EnableButtons(false);
                if (ExisteConectorEnBD(txt_ConectorName.Text))
                {
                    if (MessageBox.Show("Existe un conector con el nombre seleccionado ¿Quieres sobreescribirlo?", "Conector existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sql = @"UPDATE ConectorHerrajes SET XML = @Xml Where Codigo = @Codigo;";
                    }
                    else
                    {
                        return;
                    }

                }

                if (chk_Predefinido.Checked && !String.IsNullOrEmpty(txt_ConectorName.Text))
                {
                    sql += @"UPDATE VARIABLESGLOBALES SET VALOR = '" + txt_ConectorName.Text + "' WHERE NOMBRE = 'Conector Herraje';";
                }

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Codigo", txt_ConectorName.Text);
                    command.Parameters.AddWithValue("@Xml", xml);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Conector insertado correctamente.");

                //EnableButtons(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error insertando conector: " + ex.Message);
                //EnableButtons(true);
            }
        }

        private bool ExisteConectorEnBD(string conectorName)
        {
            using SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();

            using SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM ConectorHerrajes WHERE Codigo = '" + conectorName + "'", conexion);
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                return Convert.ToInt32(reader[0].ToString()) > 0;

            }
            return false;
        }

        private void bnt_Guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_ConectorName.Text))
            {
                MessageBox.Show("Asigna un nombre al Conector que se va a crear", "Nombre necesario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBox_Combinar.Items.Count > 0)
            {
                Connector conectorFinal = new Connector();
                conectorFinal.Message = "true";
                conectorFinal.Nodes = new List<ConnectorNode>();

                foreach (string conector in listBox_Combinar.Items)
                {
                    Connector conectorFusion = CargarConectorDesdeBaseDeDatos(conector);
                    conectorFinal.Nodes.AddRange(conectorFusion.Nodes);
                }

                string xml = SerializarXml(conectorFinal);
                GuardarConectorEnBD(xml);
            }
        }
    }
}
