using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas
{
    class Pelicula
    {
        public int[] ID_pelicula = new int[100];
        public string[] imgPeliculas = new string[100];
        public string[] nombrePeliculas = new string[100];


        public Pelicula()
        {
            for(int i =0; i < 20; i++)
            {
                ID_pelicula[i] = i;
            }

            nombrePeliculas[0] = "Avengers Endgame";
            nombrePeliculas[1] = "V de Vendetta";
            nombrePeliculas[2] = "Indiana Jones y el arca perdida";
            nombrePeliculas[3] = "Made in abyss: dawn of the deep soul";
            nombrePeliculas[4] = "Volver al futuro II";
            nombrePeliculas[5] = "Matrix";
            nombrePeliculas[6] = "La mascara";
            nombrePeliculas[7] = "Son como niños 2";
            nombrePeliculas[8] = "Legado de los huesos";
            nombrePeliculas[9] = "Entre navajas y secretos";
            nombrePeliculas[10] = "La chica que podia saltar atraves del tiempo";
            nombrePeliculas[11] = "Las ventajas de ser invisible";
            nombrePeliculas[12] = "1917";
            nombrePeliculas[13] = "Salvando al soldado Ryan";
            nombrePeliculas[14] = "Shrek";
            nombrePeliculas[15] = "Bob Esponja: un heroe al rescate";
            nombrePeliculas[16] = "Vaselina";
            nombrePeliculas[17] = "La La Land";
            nombrePeliculas[18] = "Annabelle";
            nombrePeliculas[19] = "La noche del demonio";

            imgPeliculas[0] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/accion1.jpg";
            imgPeliculas[1] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/accion2.jpg";
            imgPeliculas[2] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/aventura1.jpg";
            imgPeliculas[3] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/aventura2.jpg";
            imgPeliculas[4] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/cf1.jpg";
            imgPeliculas[5] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/cf2.jpg";
            imgPeliculas[6] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/comedia1.jpg";
            imgPeliculas[7] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/comedia2.jpg";
            imgPeliculas[8] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/crimen1.jpg";
            imgPeliculas[9] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/crimen2.jpg";
            imgPeliculas[10] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/drama1.jpg";
            imgPeliculas[11] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/drama2.jpg";
            imgPeliculas[12] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/guerra1.jpg";
            imgPeliculas[13] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/guerra2.jpg";
            imgPeliculas[14] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/infantil1.jpg";
            imgPeliculas[15] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/infantil2.jpg";
            imgPeliculas[16] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/musical1.jpg";
            imgPeliculas[17] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/musical2.jpg";
            imgPeliculas[18] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/terror1.jpg";
            imgPeliculas[19] = "C:/Users/Christopher/Desktop/Peliculas/peliculasimg/terror2.jpg";



        }
        public void insertar()
        {

        }

        public void eliminar()
        {

        }

        public void modificar()
        {

        }

        public void mostrar()
        {
            
        }
    }
    
}
