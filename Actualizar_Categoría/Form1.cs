using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actualizar_Categoría
{
    public partial class Form1 : Form
    {
        // Instancia del repositorio de categorías para acceder a los datos
        RepositorioCategoria CategoriaR = new RepositorioCategoria();

        public Form1()
        {
            // Inicializa los componentes del formulario
            InitializeComponent();
        }

        // Evento que se ejecuta al hacer clic en el botón para cargar datos
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            // Obtiene todas las categorías del repositorio y las muestra en el DataGridView
            var cat = CategoriaR.ObtenerTodo();
            DGV_CATEGORÍA.DataSource = cat; // Asigna la lista de categorías al DataGridView
        }

        // Evento que se ejecuta al hacer clic en el botón para buscar una categoría por ID
        private void btnBuscarID_Click(object sender, EventArgs e) // Se utilizó TryParse para recibir datos en String y no en INT.
        {
            // Intenta convertir el texto ingresado en el campo de búsqueda a un entero
            if (int.TryParse(txtBuscarID.Text, out int id))
            {
                // Obtiene la categoría correspondiente al ID ingresado
                var cat = CategoriaR.ObtenerPoeID(id);
                DGV_CATEGORÍA.DataSource = new List<Categorias> { cat }; // Muestra la categoría encontrada en el DataGridView

                // Si se encuentra la categoría, rellena los campos del formulario con sus datos
                if (cat != null)
                {
                    RellenarEspacios(cat);
                }
            }
            else
            {
                // Muestra un mensaje de error si el ID ingresado no es válido
                MessageBox.Show("Por favor, ingrese un ID existente.");
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para actualizar datos de la categoría
        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            // Crea un objeto Categorias con los datos del formulario
            var CateUpdate = CrearCate();
            // Actualiza la categoría en el repositorio y obtiene el número de filas actualizadas
            var Actualizada = CategoriaR.ActualizarCategoria(CateUpdate);
            // Muestra un mensaje de éxito con el número de filas actualizadas
            MessageBox.Show($"Se ha actualizado: {Actualizada}");
        }

        // Método que crea y devuelve un objeto Categorias con los datos del formulario
        private Categorias CrearCate()
        {
            var nueva = new Categorias
            {
                // Convierte el ID de categoría a entero y asigna los demás campos
                CategoryID = int.Parse(txtCategoríaID.Text),
                CategoryName = txtNameCat.Text,
                Description = txtDescripcion.Text
            };
            return nueva; // Devuelve el objeto Categorias creado
        }

        // Método que rellena los campos del formulario con los datos de la categoría
        private void RellenarEspacios(Categorias categoria)
        {
            // Asigna los datos de la categoría a los campos del formulario
            txtCategoríaID.Text = categoria.CategoryID.ToString();
            txtNameCat.Text = categoria.CategoryName;
            txtDescripcion.Text = categoria.Description;
        }

        // Evento que se ejecuta al cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Este método está vacío, pero aquí se pueden inicializar componentes o cargar datos al iniciar el formulario
        }
    }
}
