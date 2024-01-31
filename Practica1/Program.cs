// See https://aka.ms/new-console-template for more information
using Practica1;

Console.WriteLine("Bienvenida al sistema de Recursos Humanos!");

DateTime fecha = DateTime.Now;

string respuestaPositiva = "no";
List<Estudiante> estudiantes = new List<Estudiante>();
int consecutivoInicial = 1;

do
{
    Console.WriteLine("Ingrese el nombre: ");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese el primer apellido: ");
    string primerApellido = Console.ReadLine();

    Console.WriteLine("Ingrese el segundo apellido: ");
    string segundoApellido = Console.ReadLine();



    string nombreUsuario = nombre.Substring(0, 1).ToLower() + primerApellido.ToLower() + segundoApellido.Substring(0, 1).ToLower();
    string nombreUsuarioBase = nombre.Substring(0, 1).ToLower() + primerApellido.ToLower();


    int anoActual = fecha.Year % 100;

    string mesActual = fecha.ToString("MM");

    int diaActual = fecha.Day;

    string nombreUsuarioMasChars = nombreUsuario;

    int contadorApellido = 2;
    HashSet<string> nombresUsuariosGenerados = new HashSet<string>();
    while (estudiantes.Any(e => e.NombreUsuario == nombreUsuario))
    {
        if (contadorApellido <= segundoApellido.Length)
        {
            nombreUsuario = nombreUsuarioBase + segundoApellido.Substring(0, contadorApellido).ToLower();
        }
        else {

            int numeroAleatorio;

            Random r = new Random();
            do
            {
                numeroAleatorio = r.Next(0, 99);
            }
            while (nombresUsuariosGenerados.Contains(nombreUsuario + numeroAleatorio));
            nombreUsuario += numeroAleatorio.ToString();
            //nombreUsuario = nombreUsuarioBase + segundoApellido.ToLower() + 
        } 

        nombresUsuariosGenerados.Add(nombreUsuario);

        contadorApellido++;
    }


    string numeroCarnet = anoActual.ToString() + mesActual.ToString() + diaActual.ToString() + consecutivoInicial.ToString();

    Estudiante es = new Estudiante();
    es.Nombre = nombre;
    es.PrimerApellido = primerApellido;
    es.SegundoApellido = segundoApellido;
    es.NombreUsuario = nombreUsuario;
    es.NumeroCarnet = int.Parse(numeroCarnet);
    
    estudiantes.Add(es);

    consecutivoInicial++;

    foreach (Estudiante e in estudiantes) {
        Console.WriteLine(" ");
        Console.WriteLine(String.Format("Nombre: {0} \n Primer Apellido: {1} \n Segundo Apellido: {2} \n Nombre de Usuario: {3} \n Numero de Carnet: {4}", e.Nombre, e.PrimerApellido, e.SegundoApellido, e.NombreUsuario, e.NumeroCarnet));
        Console.WriteLine(" ");
    }

    Console.WriteLine("Desea agregar otro estudiante?");
    Console.WriteLine(" ");
    respuestaPositiva = Console.ReadLine().ToLower();

} while (respuestaPositiva == "si");


