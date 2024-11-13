using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_bd
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load apenas se ejecuta el formulario

            string query ="select * from usuarios";
            //cargo la tabla usuarios a el control de grilla porque retorna datos de memoria (datatable)
            dgvUsuarios.DataSource = claseConexion.listaDatos(query);

        }

       
    }
}
