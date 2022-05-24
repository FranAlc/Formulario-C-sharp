// See https://aka.ms/new-console-template for more information


//Datos personales basicos

//nombre
Console.Write("Hola ingresa tu Nombre: ");
string nombre = Convert.ToString(Console.ReadLine());
Console.WriteLine();
//apellido
Console.Write("Ingresa tu Apellido: ");
string apellido = Convert.ToString(Console.ReadLine());
Console.WriteLine();

Console.Write("Hola " + nombre +" "+ apellido + " ¿como se encuentra?"); //saluda
Console.WriteLine();

//Elegir si proseguir con el formulario o dejarlo
Console.WriteLine("¿Desea continuar con el formulario?");
//aceptar = 1  rechazar = 2

Console.WriteLine("1- Aceptar y continuar.");
Console.WriteLine("2- Rechazar formulario.");

int contRechazar = Convert.ToInt32(Console.ReadLine());

if (contRechazar == 1) {
Console.WriteLine("Gracias {0}, por elegir Aceptar y continuar, prosigamos con el formulario.", nombre);
Console.WriteLine();
Console.WriteLine("¿Podria ingresar su edad?");
Console.WriteLine();

//Edad
Console.Write("Ingresa tu edad: ");

//Se compara si es mayor o menor con IF
int edad = Convert.ToInt32(Console.ReadLine());
if(edad >= 18) 
{
    Console.WriteLine("Tienes " + edad + " y eres mayor de edad");

}
if (edad >= 17)
{
    Console.WriteLine("Usted tiene menos de 18 años");
}

//año de nacimiento
Console.WriteLine();
Console.Write("Ingrese su año de nacimiento: ");
int fecha = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Muy bien. Gracias por responder las preguntas formuladas {0} {1}",nombre , apellido);

//Selecciona nivel educativo con un IF

Console.WriteLine();
Console.WriteLine("Seleccione su nivel educativo actualmente: ");

Console.WriteLine();
Console.WriteLine("1- Secundaria");
Console.WriteLine("2- Terciario");
Console.WriteLine("3- Estudio x merito propio");

//opcion de estudio
int opcion = Convert.ToInt32(Console.ReadLine());


if (opcion == 1) //secundario
{

    Console.WriteLine("Ha seleccionado nivel de estudio Secundario");
    Console.WriteLine("¿En que año se encuentra? ");
    Console.WriteLine("Seleccionar: ");

    Console.WriteLine("1- PRIMER AÑO");
    Console.WriteLine("2- SEGUNDO AÑO");
    Console.WriteLine("3- TERCER AÑO");
    Console.WriteLine("4- CUARTO AÑO");
    Console.WriteLine("5- QUINTO AÑO");
    Console.WriteLine("6- SEXTO AÑO");
    int año = Convert.ToInt32(Console.ReadLine());
    if (año == 1) //primer año
    {
        Console.WriteLine("Ha marcado primer año");
    }
    if (año == 2) //segundo año
    {
        Console.WriteLine("Ha marcado segundo año");
    }
    if (año == 3) //tercer año
    {
        Console.WriteLine("Ha marcado tercer año");
    }
    if (año == 4) //cuarto año
    {
        Console.WriteLine("Ha marcado cuarto año");
    }
    if (año == 5) //quinto año
    {
        Console.WriteLine("Ha marcado quinto año");
    }

    if (año == 6) //sexto año
    {
        Console.WriteLine("Ha marcado sexto año");
    }
    
}

if(opcion == 2) //terciario
{
    Console.Write("¿Que materia orienta en su terciario?: ");
    int terciario = Convert.ToInt32(Console.ReadLine());
}


if (opcion == 3) //materia
{
    Console.Write("¿Que materia orienta en su tiempo de estudio?: ");
    int materia = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("Estos son los resultados de su formulario: ");

Console.WriteLine("NOMBRE: " + nombre);
Console.WriteLine("APELLIDO: "+ apellido);
Console.WriteLine("EDAD: " + edad);
Console.WriteLine("ESTUDIO: " + opcion);
Console.WriteLine("NACIMIENTO: "+ fecha);

}
else
{

    Console.WriteLine("Estos son los resultados de su formulario: ");
    Console.WriteLine("NOMBRE: " + nombre);
    Console.WriteLine("APELLIDO: " + apellido);

}