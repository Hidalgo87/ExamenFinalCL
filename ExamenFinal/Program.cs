

//using ExamenFinal.App1;
//using ExamenFinal.App2;
//using ExamenFinal.App2;
using ExamenFinal.AppAdapter;
/*
PRUEBAS DEL PUNTO NÚMERO 1

En la app1
Como el metodo load data de USER CREATOR 
lo unico que hace es llamar al read data de reader
es un metodo desechable que se puede llamar desde create 
users con un nuevo parametro reader

En la app2
EL metodo filter_data de la clase MatchReader es innecesario,
con los otros dos métodos es suficiente para que funcione adecuadamente
*/

/*
UserCreator creator = new UserCreator();
var lista = creator.load_data(new Reader(), "app_1_data.txt");
List<User> lista_usuarios =  creator.create_users(lista);
foreach (User usuario in lista_usuarios) {
    Console.WriteLine(usuario.username);
}
*/
/*
MatchReader matchReader = new MatchReader();
var lista = matchReader.read_file("app_2_data.txt");
List<User> lista_usuarios = matchReader.create_people(lista);
foreach (User usuario in lista_usuarios)
{
    Console.WriteLine(usuario.id);
    Console.WriteLine(usuario.username);
    Console.WriteLine(usuario.password);
}
*/


/*
PRUEBAS DEL PUNTO NÚMERO 2

El patrón de diseño a usar es ADAPTER, porque está hecho
justamente para estos casos, donde necesitamos integrar dos clases
que funcionan con formatos diferentes y donde no podemos cambiar 
los formatos con los que trabajan

Adapter funciona implementando una clase "Mediadora" entre las 
clases que se quieren integrar.
Pero se necesita que el "Cliente" se comunique con una interfaz,
no con una clase específica como se plantea en el ejercicio
y esta clase tendrá como atributo una instancia de la otra clase
(En este caso de la app2 MatchReader) para que sólo sea traducir las peticiones
y hacerlas a este objeto.
 
*/

//Prueba con el formato app1
IUserCreator userCreatorApp1 = new ReaderApp1();
var lista = userCreatorApp1.load_data("app_1_data.txt");
List<User> lista_usuarios = userCreatorApp1.create_users(lista);
foreach (User usuario in lista_usuarios)
{
    Console.WriteLine(usuario.id);
    Console.WriteLine(usuario.username);
    Console.WriteLine(usuario.password);
}


//Prueba con el adapter formato app2
/*
MatchReader mr = new MatchReader();
IUserCreator userCreatorADAPTER = new AdapterApp2(mr);
var lista = userCreatorADAPTER.load_data("app_2_data.txt");
List<User> lista_usuarios = userCreatorADAPTER.create_users(lista);
foreach (User usuario in lista_usuarios)
{
    Console.WriteLine(usuario.id);
    Console.WriteLine(usuario.username);
    Console.WriteLine(usuario.password);
}
*/