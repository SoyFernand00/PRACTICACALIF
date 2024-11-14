using T3;

byte opcion;
string regre;
int num;
Estudiante estud=new Estudiante();
Cita cita=new Cita();

do
{
    Console.WriteLine("Menu");
    Console.WriteLine("Crear [1]: ");
    Console.WriteLine("Lista [2]: ");
    Console.WriteLine("Modificar[3]: ");
    Console.WriteLine("Salir [0]: ");


    Console.WriteLine("Ingrese opcion: ");
    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
    {
        Console.WriteLine("Error: Ingrese una opcion valida: ");
    }
    switch (opcion)
    {
        case 0: Environment.Exit(0); break;
        case 1:
            Console.WriteLine("Cuantos estudiantes desea ingresar: ");
            num =int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                estud.String();
                cita.String();
            }
            break;
        case 2:
            cita.Lista();
            estud.Lista();
            break;
        case 3:
            Console.WriteLine("Ingresar nombre de Universidad a eliminar: ");
            string Uni=Console.ReadLine();
            estud.Eliminar(Uni);
            break;
    }
    Console.WriteLine("volver al menu [si]");
    regre =Console.ReadLine().ToLower();
    Console.Clear();
}while (regre=="si");



//secund