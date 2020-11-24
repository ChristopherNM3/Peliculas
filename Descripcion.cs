using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas
{
    class Descripcion
    {
        public string[] duracion = new string[100];
        public string[] sipsosis = new string[100];
        public string[] director = new string[100];
        public Pelicula pelicula = new Pelicula();
        
        public Descripcion()
        {
            duracion[0] = "181";
            duracion[1] = "132";
            duracion[2] = "115";
            duracion[3] = "95";
            duracion[4] = "131";
            duracion[5] = "101";
            duracion[6] = "101";
            duracion[7] = "101";
            duracion[8] = "119";
            duracion[9] = "130";
            duracion[10] = "98";
            duracion[11] = "103";
            duracion[12] = "119";
            duracion[13] = "139";
            duracion[14] = "92";
            duracion[15] = "103";
            duracion[16] = "110";
            duracion[17] = "128";
            duracion[18] = "98";
            duracion[19] = "102";

            director[0] = "Anthony y Joe Russo";
            director[1] = "James McTeigue";
            director[2] = "Steven Spielberg";
            director[3] = "Masayuki Kojima";
            director[4] = "Steven Spielberg";
            director[5] = "Hermanos Wachowski";
            director[6] = "Chuck Russell";
            director[7] = "Dennis Dugan";
            director[8] = "Fernando González Molina";
            director[9] = "Rian Johnson";
            director[10] = "Mamoru Hosoda";
            director[11] = "Stephen Chbosky";
            director[12] = "Sam Mendes";
            director[13] = "Steven Spielberg";
            director[14] = "Andrew Adamson, Vicky Jenson";
            director[15] = "Tim Hill";
            director[16] = "Randal Kleiser";
            director[17] = "Damien Chazelle";
            director[18] = "John R. Leonetti";
            director[19] = "James Wan";


            sipsosis[0] = "Los Vengadores restantes deben encontrar una manera de recuperar a sus aliados para un " +
                           "enfrentamiento épico con Thanos, el malvado que diezmó el planeta y el universo.";
            sipsosis[1] = "Evey, una joven proveniente de la clase trabajadora, es rescatada por “V”, un misterioso enmascarado " +
                           "que busca la destrucción del gobierno cruel y corrupto, y la libertad del pueblo.";
            sipsosis[2] = "El arqueólogo Indiana Jones necesita encontrar el Arca de la Alianza, una reliquia bíblica que contiene los Diez Mandamientos " +
                           "y que convierte en invencible a su poseedor. Jones deberá adelantarse a los nazis, quienes también buscan el Arca.";
            sipsosis[3] = "Película secuela de la serie anime 'Made in Abyss', que cuenta las aventuras de Reg y Riko en su descenso por el abismo, ahora junto " +
                          "con Nanachi hacia la quinta capa del abismo, 'El Mar de Cadáveres'. Allí encontrarán a Bondrewd, un silbato blanco legendario que está relacionado con el pasado de Nanachi. Bondrewd es hospitalario con ellos, pero las cosas no son como parecen en Abyss.";
            sipsosis[4] = "Un adolescente y un inventor extravagante viajan al pasado y al futuro para alterar una serie de eventos desastrosos.";
            sipsosis[5] = "Un experto en computadoras descubre que su mundo es una simulación total creada con maliciosas intenciones por parte de la ciberinteligencia.";
            sipsosis[6] = "Una máscara antigua transforma a un monótono empleado bancario en un Romeo sonriente con poderes sobrehumanos.";
            sipsosis[7] = "El último día de escuela trae sorpresas y experiencias de aprendizaje inesperadas a un grupo de padres.";
            sipsosis[8] = "La detective Amaia Salazar se ve obligada a volver al valle del Baztán para investigar una serie de suicidios. Estas tragedias parecen estar conectadas y siguen un patrón " +
                          "determinado. Sin embargo algo atrae la atención de Salazar, un acusado de asesinato deja una nota de suicidio para ella y una sola palabra abrirá la caja de pandora: Tarttalo.";
            sipsosis[9] = "Benoit Blanc, un detective implacable, investiga la muerte de un anciano escritor de novelas policíacas en la mansión del difunto. Benoit tendrá que sortear las trampas y mentiras que " +
                           "la excéntrica familia y los sirvientes del novelista han urdido.";
            sipsosis[10] = "Una adolescente intenta usar a su favor su nueva capacidad para viajar en el tiempo.";
            sipsosis[11] = "Charlie es un joven socialmente torpe y siempre está viendo la vida desde la barrera, hasta que dos estudiantes carismáticos se convierten en sus mentores. Sam y su hermanastro Patrick ayudan a " +
                           "Charlie a descubrir las alegrías de la amistad, el primer amor, la música y mucho más, mientras que un maestro provoca que él sueñe con ser un escritor. Sin embargo, mientras sus nuevos amigos se preparan para ir " +
                           "a la universidad, su tristeza interior amenaza con destruir su confianza.";
            sipsosis[12] = "Durante la Primera Guerra Mundial, dos jóvenes soldados británicos reciben una orden, aparentemente, imposible de ejecutar: en una carrera contra el reloj, deben infiltrarse en territorio enemigo para entregar un mensaje " +
                            "que podría salvar a miles de compañeros.";
            sipsosis[13] = "Después de desembarcar en Normandía, en plena Segunda Guerra Mundial, unos soldados norteamericanos deben arriesgar sus vidas para salvar al soldado James Ryan, cuyos tres hermanos han muerto en la guerra.";
            sipsosis[14] = "Un ogro llamado Shrek vive en su pantano, pero su preciada soledad se ve súbitamente interrumpida por la invasión de los ruidosos personajes de los cuentos de hadas. Todos fueron expulsados de sus reinos por el malvado Lord Farquaad. " +
                           "Decidido a salvar su hogar, Shrek hace un trato con Farquaad y se prepara para rescatar a la princesa Fiona, quien será la esposa de Farquaad.";
            sipsosis[15] = "Bob Esponja y Patricio deciden viajar a la ciudad perdida de Atlantic City para encontrar a Gary, el caracol.";
            sipsosis[16] = "El rebelde Danny Zuko y la inocente australiana Sandy mantienen un romance durante las vacaciones, creyendo que no se volverán a ver; sin embargo, para sorpresa de ambos, se reencuentran en la escuela secundaria al empezar el nuevo curso.";
            sipsosis[17] = "Sebastian, un pianista de jazz, y Mia, una aspirante a actriz, se enamoran locamente; pero la ambición desmedida que tienen por triunfar en sus respectivas carreras, en una ciudad como Los Ángeles, repleta de competencia y carente de piedad, pone en peligro su amor.";
            sipsosis[18] = "John Form encuentra el regalo perfecto para Mia, su esposa embarazada: una preciosa muñeca antigua llamada Annabelle. Una noche, una secta satánica les ataca brutalmente y provocan que un ente maligno se apodere de Annabelle.";
            sipsosis[19] = "Josh y Renai se mudan a una nueva casa, donde su hijo tiene un terrible accidente y queda en estado de coma.";



        }
        public void asignarDescripcion()
        {


        }

        public string[] pedirDescripcion(int id)
        {
            string[] nmb_pelicula = pelicula.nombrePeliculas;
            string[] img_pelicula = pelicula.imgPeliculas;
            string[] descripcionPelicula = new string[10];

            descripcionPelicula[0] = img_pelicula[id];
            descripcionPelicula[1] = nmb_pelicula[id];
            descripcionPelicula[2] = director[id];
            descripcionPelicula[3] = duracion[id];
            descripcionPelicula[4] = sipsosis[id];
            

            return descripcionPelicula;
            
        }
    }
}
