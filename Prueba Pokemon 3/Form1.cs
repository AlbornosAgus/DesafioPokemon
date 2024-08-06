using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Pokemon_3
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonList = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            pokemonList = pokemonNegocio.listar();
            dtgDatos.DataSource = pokemonList;
            cargarImagen(pokemonList[0].UrlImagen);


        }

 

        private void dtgDatos_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon) dtgDatos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                PBPokemon.Load(imagen);
            }
            catch
            {
                PBPokemon.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }

        }
    }
}
