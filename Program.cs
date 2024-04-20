using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;

static void EjemploPolimorfismo()
{
    Animal[] animales = new Animal[3];
    animales[0] = new Tortuga();
    animales[1] = new Gato();
    animales[2] = new Perro();
    foreach (Animal animal in animales)
    {
        animal.HacerSonido();
    }
}   

static void Laboratorio()
{
    VideoJuego videoJuego = new VideoJuego();
    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    videoJuego.Desarrolladora = "Nintendo";
    videoJuego.Calificacion = 10; //la calificacion es un 10 solo por ser zelda :), el error es que lo estaba asignando en 50
    videoJuego.anioLanzamiento = 2017; //en program tenia el error que AnioLanzamiento estaba en mayuscula cuando es anioLandamiento
    videoJuego.MostrarInformacion();
}

//Laboratorio();
VideoJuego.listaDeJuegos();



