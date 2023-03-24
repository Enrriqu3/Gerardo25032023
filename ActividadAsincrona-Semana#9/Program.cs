// See https://aka.ms/new-console-template for more information
using ActividadAsincrona_Semana_8.Models;
using ActividadAsincrona_Semana_8.DAO;

Console.WriteLine();

Console.WriteLine("           ******************************************************************       ");
Console.WriteLine("             BIENVENIDO HA INSERTAR PRODUCTOS EN LA BASE DE DATOS <ALMACEN>        ");
Console.WriteLine("           ******************************************************************       ");

CrudProductos crudProductos = new CrudProductos();
Producto producto = new Producto();

Console.WriteLine("Menu");
Console.WriteLine("=> Pulse 1 para insertar productos en la base de datos <Almacen>");
Console.WriteLine("=> Pulse 2 para recibir una sorpresa");
Console.WriteLine();
var Menu = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

switch (Menu)
{

    case 1:
        int bucle = 1;
        while (bucle == 1)
        {
            Console.Write("- Ingresa El nombre de el producto a ingresar ----> ");
            producto.Nombre = Console.ReadLine();
            Console.Write("- Ingresa la descripcion de el producto ingresado ----> ");
            producto.Descripcion = Console.ReadLine();
            Console.Write("- Ingresa el precio de el producto ingresado ----> ");
            producto.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.Write("- Ingrese la cantidad de productos ---> ");
            producto.Stock = Convert.ToInt32(Console.ReadLine());
            crudProductos.AgregarProductos(producto);
            Console.WriteLine();
            Console.WriteLine("**EL PRODUCTO SE REGISTRO CORRECTAMENTE**");
            Console.WriteLine();
            Console.WriteLine("=> Pulsa 1 para continuar insertando usuarios");
            Console.WriteLine("=> Pulsa 0 para salir");
            bucle = Convert.ToInt32(Console.ReadLine());
        }
        break;

        Console.WriteLine();

    case 2:
        Console.WriteLine("¡Gracias por utilizar esté programa!");

        Console.WriteLine();
        Console.WriteLine("=> Pulsa 0 para salir");
        Console.WriteLine();
        bucle = Convert.ToInt32(Console.ReadLine());
       

      
        
        break;


}


#region Proyecto Asincrona-Semana#8

//AlmacenContext db = new AlmacenContext();
//Producto producto = new Producto();

//Console.WriteLine();

//Console.Write("- Ingrese un Nombre de producto ---> ");
//producto.Nombre = Console.ReadLine();
//Console.Write("- Ingrese la descripción del producto ---> ");
//producto.Descripcion = Console.ReadLine();
//Console.Write("- Ingrese el presio de el producto ---> ");
//producto.Precio = Convert.ToDecimal(Console.ReadLine());
//Console.Write("- Ingrese la cantidad de productos ---> ");
//producto.Stock = Convert.ToInt32(Console.ReadLine());

//db.Productos.Add(producto);
//db.SaveChanges();

//Console.WriteLine();

//Console.WriteLine("             -----------------------------------------                  ");
//Console.WriteLine("             PRODUCTOS REGISTRADOS EN LA BASE DE DATOS                  ");
//Console.WriteLine("             -----------------------------------------                  ");

//Console.WriteLine();

//var LisProducto = db.Productos.ToList();
//foreach (var usu in LisProducto)
//{
//    Console.WriteLine($"Id: {usu.Id}, NOMBRE: {usu.Nombre}, DESCRIPCION: {usu.Descripcion}, PRECIO: {usu.Precio}, STOCK: {usu.Stock}");
//}

//Console.WriteLine();

//Console.Write("*FIN DE REGISTROS*");

//Console.WriteLine();

#endregion

