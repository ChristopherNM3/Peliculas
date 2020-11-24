using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas
{
    class Usuario
    {
        public int ID_usuario;
        public string nombre_usuario;
        private Random random = new Random();
        int contPeliculas = 0;
        public static int contDramaUs = 0, contMusicalesUs = 0, contInfantilesUs = 0, contComediaUs = 0, contCFUs = 0, contAventuraUs = 0, contGuerraUs = 0, contTerrorUs = 0, contAccionUs = 0, contCrimenUs = 0;
        public string[] DramaPreguntas = new string[5];
        public string[] MusicalesPreguntas = new string[5];
        public string[] InfantilesPreguntas = new string[5];
        public string[] ComediaPreguntas = new string[5];
        public string[] CFPreguntas = new string[5];
        public string[] AventuraPreguntas = new string[5];
        public string[] GuerraPreguntas = new string[5];
        public string[] TerrorPreguntas = new string[5];
        public string[] AccionPreguntas = new string[5];
        public string[] CrimenPreguntas = new string[5];
        public string[] Preguntas = new string[10];
        public string[] peliMostrar = new string[25];
        public string[] peli_nmbMostrar = new string[25];
        public int[] peli_IdMostrar = new int[25];


        Pelicula pelicula = new Pelicula();
        string[] imgPeliculas = new string[30];
        string[] nmbPeliculas = new string[30];
        int[] IDPeliculas = new int[30];

        public string[] pedirCuestionario()
        {
            DramaPreguntas[0] = "¿Te gustan las historias con habiente tenso?";
            DramaPreguntas[1] = "¿Te gustan los giros de trama repentinos?";
            DramaPreguntas[2] = "¿Te gustan las historias con situaciones reales?";
            DramaPreguntas[3] = "¿Te gustan las historias emotivas?";
            DramaPreguntas[4] = "¿Te gustan las historias inquietantes?";

            MusicalesPreguntas[0] = "¿Es importante una buena banda sonora?";
            MusicalesPreguntas[1] = "¿Te gustan los numero musicales en películas?";
            MusicalesPreguntas[2] = "¿te gusta que los personajes dialoguen cantando?";
            MusicalesPreguntas[3] = "¿Conoces el baile de Jonh Travolta?";
            MusicalesPreguntas[4] = "“Me gusta pensar en la vida como un musical, porque en los musicales, nada malo sucede”";

            InfantilesPreguntas[0] = "¿Eres un niño?";
            InfantilesPreguntas[1] = "¿Reconoces la frase “El ciclo de la vida”?";
            InfantilesPreguntas[2] = "¿Los juguetes pueden ser protagonistas?";
            InfantilesPreguntas[3] = "¿Los ogros son como cebollas?";
            InfantilesPreguntas[4] = "¿Te gusta soñar como niño?";

            ComediaPreguntas[0] = "¿Te gustan las películas divertidas?";
            ComediaPreguntas[1] = "¿Te gustan las parodias?";
            ComediaPreguntas[2] = "¿Conoces a Jim Carrey?";
            ComediaPreguntas[3] = "¿Te gusta reír con amigos?";
            ComediaPreguntas[4] = "¿Te gusta el humor absurdo?";

            CFPreguntas[0] = "¿Te gustan las historias futuristas?";
            CFPreguntas[1] = "¿Te gustan los escenarios en el espacio?";
            CFPreguntas[2] = "¿Te gustaría un protagonista extraterrestre?";
            CFPreguntas[3] = "¿Te gustan los autos voladores?";
            CFPreguntas[4] = "¿Te gustaría ver robots asesinos?";

            AventuraPreguntas[0] = "¿Te gustan los viajes en las películas?";
            AventuraPreguntas[1] = "¿Te gusta un ambiente de supervivencia?";
            AventuraPreguntas[2] = "¿Conoces a Indiana Jones?";
            AventuraPreguntas[3] = "¿Te gustan los grupos grandes de personajes en películas?";
            AventuraPreguntas[4] = "¿Te gustan las películas de náufragos?";

            GuerraPreguntas[0] = "¿Te gustaría un ambiente militar?";
            GuerraPreguntas[1] = "¿Eres una persona de poco tacto?";
            GuerraPreguntas[2] = "¿Conoces el desembarco de Normandía?";
            GuerraPreguntas[3] = "¿Te suena “Salvando al soldado Ryan”?";
            GuerraPreguntas[4] = "¿Te gusta la temática de guerra?";

            TerrorPreguntas[0] = "¿Te suena una sombra en una cortina en la ducha?";
            TerrorPreguntas[1] = "¿Reconoces a un muñeco caminado solo?";
            TerrorPreguntas[2] = "¿Recuerdas la frase “Veo gente muerta”?";
            TerrorPreguntas[3] = "¿Reconoces estas palabras, payaso, globo, alcantarilla?";
            TerrorPreguntas[4] = "¿Reconoces la frase “sé lo que hiciste el verano pasado”?";

            AccionPreguntas[0] = "¿Te gustan los súper héroes?";
            AccionPreguntas[1] = "¿Te gustan los disparos excesivos?";
            AccionPreguntas[2] = "¿Te gusta la velocidad?";
            AccionPreguntas[3] = "¿Conoces a Tom Cruise?";
            AccionPreguntas[4] = "¿Reconoces a 007?";

            CrimenPreguntas[0] = "¿Quieres ver algo relacionado al crimen?";
            CrimenPreguntas[1] = "¿Te gusta que la película vaya aclarando las cosas?";
            CrimenPreguntas[2] = "¿Quieres que la historia a tratar se relacione con un crimen?";
            CrimenPreguntas[3] = "¿Quieres personajes policías?";
            CrimenPreguntas[4] = "¿Te gustan las escenas de abogados?";


            //Elegir las preguntas al azar
            Preguntas[0] = DramaPreguntas[random.Next(0, 4)];
            Preguntas[1] = MusicalesPreguntas[random.Next(0, 4)];
            Preguntas[2] = InfantilesPreguntas[random.Next(0, 4)];
            Preguntas[3] = ComediaPreguntas[random.Next(0, 4)];
            Preguntas[4] = CFPreguntas[random.Next(0, 4)];
            Preguntas[5] = AventuraPreguntas[random.Next(0, 4)];
            Preguntas[6] = GuerraPreguntas[random.Next(0, 4)];
            Preguntas[7] = TerrorPreguntas[random.Next(0, 4)];
            Preguntas[8] = AccionPreguntas[random.Next(0, 4)];
            Preguntas[9] = CrimenPreguntas[random.Next(0, 4)];


            return Preguntas; //regresa un arreglo con las preguntas elegidas al azar


        }

        public void hacerCuestionario(bool contDrama, bool contMusicales, bool contInfantiles, bool contComedia, bool contCF, bool contAventura, bool contGuerra, bool contTerror, bool contAccion, bool contCrimen)
        {
            if (contDrama == true) //En el cuestionario si eligio "si" entonces se recibe un true que aumenta el contador de la categoria asociada a la pregunta
            {
                contDramaUs++;
            }
            if (contMusicales == true)
            {
                contMusicalesUs++;
            }
            if (contInfantiles == true)
            {
                contInfantilesUs++;
            }
            if (contComedia == true)
            {
                contComediaUs++;
            }
            if (contCF == true)
            {
                contCFUs++;
            }
            if (contAventura == true)
            {
                contAventuraUs++;
            }
            if (contGuerra == true)
            {
                contGuerraUs++;
            }
            if (contTerror == true)
            {
                contTerrorUs++;
            }
            if (contAccion == true)
            {
                contAccionUs++;
            }
            if (contCrimen == true)
            {
                contCrimenUs++;
            }


            /*Console.WriteLine(contDramaUs);
            Console.WriteLine(contMusicalesUs);
            Console.WriteLine(contInfantilesUs);
            Console.WriteLine(contComediaUs);
            Console.WriteLine(contCFUs);
            Console.WriteLine(contAventuraUs);
            Console.WriteLine(contGuerraUs);
            Console.WriteLine(contTerrorUs);
            Console.WriteLine(contAccionUs);
            Console.WriteLine(contCrimenUs);*/

        }

        public void elegirPelicula()
        { //Guardo la direccion de las imaganes en un arreglo, tu cambiaselas a donde las tengas
            string[] imgPeliculas = pelicula.imgPeliculas;
            string[] nmbPeliculas = pelicula.nombrePeliculas;
            int[] IDPeliculas = pelicula.ID_pelicula;

            if (contPeliculas < 6) //contPeliculas es un contador que va subiendo para en caso de llegar a 6 detenerse que es el maximo de peliculas que se muestran
            {
                if (contDramaUs >= 2)
                {
                    peliMostrar[contPeliculas] = imgPeliculas[10]; //se le asigna al arreglo una direccion con el link de la imagen
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[10];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[10];
                    contPeliculas++; //aumenta el contador ya que se agrego una pelicula


                    peliMostrar[contPeliculas] = imgPeliculas[11];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[11];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[11];
                    contPeliculas++;
                }
            }

            if (contPeliculas < 6)
            {
                if (contAventuraUs >= 2)
                {
                    peliMostrar[contPeliculas] = imgPeliculas[2];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[2];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[2];
                    contPeliculas++;


                    peliMostrar[contPeliculas] = imgPeliculas[3];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[3];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[3];
                    contPeliculas++;
                }
            }

            if (contPeliculas < 6)
            {
                if (contCFUs >= 2)
                {
                    peliMostrar[contPeliculas] = imgPeliculas[4];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[4];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[4];
                    contPeliculas++;

                    peliMostrar[contPeliculas] = imgPeliculas[5];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[5];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[5];
                    contPeliculas++;
                }

            }

            if (contPeliculas < 6)
            {
                if (contComediaUs >= 2)
                {
                    peliMostrar[contPeliculas] = imgPeliculas[6];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[6];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[6];
                    contPeliculas++;

                    peliMostrar[contPeliculas] = imgPeliculas[7];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[7];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[7];
                    contPeliculas++;
                }

            }

            if (contPeliculas < 6)
            {
                if (contCrimenUs >= 2)
                {
                    peliMostrar[contPeliculas] = imgPeliculas[8];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[8];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[8];
                    contPeliculas++;

                    peliMostrar[contPeliculas] = imgPeliculas[9];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[9];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[9];
                    contPeliculas++;
                }

            }

            if (contPeliculas < 6)
            {
                if (contAccionUs >= 2)
                {
                    peliMostrar[contPeliculas] = imgPeliculas[0];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[0];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[0];
                    contPeliculas++;

                    peliMostrar[contPeliculas] = imgPeliculas[1];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[1];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[1];
                    contPeliculas++;
                }

            }

            if (contPeliculas < 6)
            {
                if (contGuerraUs >= 2)
                {
                    peliMostrar[contPeliculas] = imgPeliculas[12];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[12];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[12];
                    contPeliculas++;

                    peliMostrar[contPeliculas] = imgPeliculas[13];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[13];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[13];
                    contPeliculas++;
                }

            }

            if (contPeliculas < 6)
            {
                if (contInfantilesUs >= 2)
                {
                    peliMostrar[contPeliculas] = imgPeliculas[14];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[14];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[14];
                    contPeliculas++;

                    peliMostrar[contPeliculas] = imgPeliculas[15];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[15];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[15];
                    contPeliculas++;
                }

            }

            if (contPeliculas < 6)
            {
                if (contMusicalesUs >= 2)
                {
                    peliMostrar[contPeliculas] = imgPeliculas[16];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[16];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[16];
                    contPeliculas++;

                    peliMostrar[contPeliculas] = imgPeliculas[17];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[17];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[17];
                    contPeliculas++;
                }

            }

            if (contPeliculas < 6)
            {
                if (contTerrorUs >= 2)
                {
                    peliMostrar[contPeliculas] = imgPeliculas[18];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[18];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[18];
                    contPeliculas++;

                    peliMostrar[contPeliculas] = imgPeliculas[19];
                    peli_nmbMostrar[contPeliculas] = nmbPeliculas[19];
                    peli_IdMostrar[contPeliculas] = IDPeliculas[19];
                    contPeliculas++;
                }

            }
            //regresa el arreglo con las direcciones de las imagenes

        } 
        public void reinciar()
        {
            contAccionUs = 0;
            contAventuraUs = 0;
            contCFUs = 0;
            contComediaUs = 0;
            contCrimenUs = 0;
            contDramaUs = 0;
            contGuerraUs = 0;
            contInfantilesUs = 0;
            contMusicalesUs = 0;
            contPeliculas = 0;
            contTerrorUs = 0;
        }
    }
}
