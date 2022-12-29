using System;
using System.Collections.Generic;
using System.Linq;

namespace AmeliaHCross;
class Program
{
    static void Main(string[] args)
    {

        List<string> comprasSuper = new List<string>() {};
        List<string> comprasRopa = new List<string>() {};
        List<string> comprasMiscelaneos = new List<string>() {};
        List<string> usuarios = new List<string>() {"Amelia", "José", "María", "Luis"};
        string usuario;
        bool registrado = true;
        int opcion;
        int switchOpt;
        string newItem;

     // VALIDACIÓN DE USUARIO
        do
        {
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine("---   LISTA DE COMPRAS    -----");
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine("                               ");
            System.Console.WriteLine("Ingrese su usuario: ");
            usuario = Console.ReadLine();

            if (usuarios.Contains(usuario))
            {   Console.Clear();
                registrado = true;
                System.Console.WriteLine("Bienvenido/a " + usuario);
            } 
            if (string.IsNullOrWhiteSpace(usuario))
            {   Console.Clear();
                registrado = false;
                System.Console.WriteLine("Ha introducido un espacio en blanco. Intente de nuevo");
            } 
            if (!usuarios.Contains(usuario) && !string.IsNullOrWhiteSpace(usuario))
            {   Console.Clear();
                registrado = false;
                System.Console.WriteLine("Usuario no encontrado. No puede acceder. Intente de nuevo");
            }
        } while (!registrado);
    // SI SE INGRESA UN USUARIO EXISTENTE, SE DESARROLLA EL PROGRAMA:
        System.Console.WriteLine("[ ENTER ] (Presione cualquier tecla...)");
        Console.ReadKey();
        Console.Clear();
        bool salir = false;

            do
            {
            System.Console.WriteLine("---    MENÚ    -----");
            System.Console.WriteLine(usuario + " ,elije el número de la categoría a editar: ");
            System.Console.WriteLine(" 1 - Supermercado");
            System.Console.WriteLine(" 2 - Ropa");
            System.Console.WriteLine(" 3 - Misceláneos");
            System.Console.WriteLine(" 4 - SALIR");
            System.Console.WriteLine(" 5 - Ver cantidad de elementos en cada lista");
            opcion = int.Parse(Console.ReadLine());

            Console.Clear();
            string tarea;
            int eliminar;
            int editar;
            string confirm;

            // Menú principal
            switch (opcion)
                        {
                            case 1:
                            System.Console.WriteLine("Supermercado");
                            Console.WriteLine("Selecciona una opción: ");
                            Console.WriteLine(" 1-  Agregar elemento");
                            Console.WriteLine(" 2-  Ver lista");
                            Console.WriteLine(" 3-  Eliminar");
                            Console.WriteLine(" 4-  Editar elemento");
                            Console.WriteLine(" 5-  SALIR");
                            switchOpt = int.Parse(Console.ReadLine());
                                // Submenú SUPERMERCADO
                                    switch (switchOpt)
                            {           //SUPERMERCADO
                                        case 1:
                                            Console.WriteLine(usuario + ", ingresa el nombre del elemento a agregar en SUPERMERCADO:");
                                            tarea = Console.ReadLine();
                                            if (!String.IsNullOrWhiteSpace(tarea))
                                            {   
                                                comprasSuper.Add(tarea);
                                                Console.WriteLine(" ");
                                                Console.WriteLine("Tarea agregada!");
                                               
                                            } else {
                                                Console.WriteLine(usuario + ", no puedes agregar una tarea vacía");
                                            }
                                           
                                            Console.ReadKey();
                                            Console.Clear();
                                        break;

                                        case 2:
                                            Console.WriteLine(usuario + ", tu lista de SUPERMERCADO:");
                                            foreach (var item in comprasSuper)
                                            {
                                                Console.WriteLine(item);
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                        break;

                                        case 3:
                                            Console.WriteLine(usuario +  ", digita el número del item a eliminar:");
                                        for (int i = 0; i < comprasSuper.Count; i++)
                                        {
                                            Console.WriteLine(i + "- "+  comprasSuper[i]);
                                        }
                                        eliminar = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Seguro/a que desea eliminar el item: " + comprasSuper[eliminar] + " ? [Si] o [No]" );
                                        confirm = Console.ReadLine();

                                        if (confirm=="Si" || confirm=="si")
                                        {
                                            Console.WriteLine("Item eliminado." );
                                            comprasSuper.RemoveAt(eliminar);
                                        }
                                            Console.ReadKey();
                                            Console.Clear();
                                        break;

                                        case 4:
                                            Console.WriteLine("Para editar un item, selecciona su índice:");
                                            for (int i = 0; i < comprasSuper.Count; i++)
                                        {
                                            Console.WriteLine(i + "- "+  comprasSuper[i]);
                                        }
                                            editar =  int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ok, escribe el nuevo nombre de  " + comprasSuper.ElementAt(editar));
                                            newItem = Console.ReadLine();
                                            comprasSuper.RemoveAt(editar);
                                            comprasSuper.Insert(editar, newItem);
                                        break;

                                        case 5:
                                            Console.WriteLine(usuario +  ", has salido de la categoría SUPERMERCADO:");
                                            Console.ReadKey();
                                            Console.Clear();
                                        break;

                                        default:
                                        System.Console.WriteLine("Opción inválida");
                                        break;
                                    }
                                // Fin del submenú de SUPERMERCADO
                            break;

                            case 2:
                            System.Console.WriteLine("Ropa");
                            Console.WriteLine("Seleccione una opción: ");
                            Console.WriteLine(" 1-  Agregar elemento");
                            Console.WriteLine(" 2-  Ver lista");
                            Console.WriteLine(" 3-  Eliminar");
                            Console.WriteLine(" 4-  Editar elemento");
                            Console.WriteLine(" 5-  SALIR");
                            switchOpt = int.Parse(Console.ReadLine());
                                // Submenú ROPA
                                    switch (switchOpt)
                                {           //ROPA
                                            case 1:
                                                Console.WriteLine(usuario +  ", ingresa el nombre del elemento a agregar en ROPA:");
                                                tarea = Console.ReadLine();
                                                if (String.IsNullOrWhiteSpace(tarea))
                                                {
                                                    Console.WriteLine(usuario +  ", no puedes agregar una tarea vacía");
                                                } else {
                                                    comprasRopa.Add(tarea);
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine("Tarea agregada!");
                                                }
                                                Console.ReadKey();
                                                Console.Clear();
                                            break;

                                            case 2:
                                                Console.WriteLine("Tu lista de ROPA:");
                                                foreach (var item in comprasRopa)
                                                {
                                                    Console.WriteLine(item);
                                                }
                                                Console.ReadKey();
                                                Console.Clear();
                                            break;

                                            case 3:
                                                Console.WriteLine(usuario +  ", digita el número del item a eliminar:");
                                            for (int i = 0; i < comprasRopa.Count; i++)
                                            {
                                                Console.WriteLine(i + "- "+  comprasRopa[i]);
                                            }
                                            eliminar = int.Parse(Console.ReadLine());
                                            Console.WriteLine("¿Seguro/a que desea eliminar el item: " + comprasRopa[eliminar] + " ? [Si] o [No]" );
                                            confirm = Console.ReadLine();

                                            if (confirm=="Si" || confirm=="si")
                                            {
                                                Console.WriteLine("Item eliminado." );
                                                comprasRopa.RemoveAt(eliminar);
                                            }
                                                Console.ReadKey();
                                                Console.Clear();
                                            break;

                                            case 4:
                                                Console.WriteLine("Para editar un item, selecciona su índice:");
                                                for (int i = 0; i < comprasRopa.Count; i++)
                                            {
                                                Console.WriteLine(i + "- "+  comprasRopa[i]);
                                            }
                                                editar =  int.Parse(Console.ReadLine());
                                                Console.WriteLine("Ok, escribe el nuevo nombre de  " + comprasRopa.ElementAt(editar));
                                                newItem = Console.ReadLine();
                                                comprasRopa.RemoveAt(editar);
                                                comprasRopa.Insert(editar, newItem);
                                            break;

                                            case 5:
                                                Console.WriteLine(usuario +  ", has salido de la categoría ROPA:");
                                                Console.ReadKey();
                                                Console.Clear();
                                            break;

                                            default:
                                            System.Console.WriteLine("Opción inválida");
                                            break;
                                        }
                                // Fin del submenú de ROPA
                            break;

                            case 3:
                            System.Console.WriteLine("Calzados");
                            Console.WriteLine("Seleccione una opción: ");
                            Console.WriteLine(" 1-  Agregar elemento");
                            Console.WriteLine(" 2-  Ver lista");
                            Console.WriteLine(" 3-  Eliminar");
                            Console.WriteLine(" 4-  Editar elemento");
                            Console.WriteLine(" 5-  SALIR");
                            switchOpt = int.Parse(Console.ReadLine());
                                // Submenú MISCELANEOS
                                    switch (switchOpt)
                            {           //MISCELANEOS
                                        case 1:
                                            Console.WriteLine(usuario +  ", ingresa el nombre del elemento a agregar en MISCELANEOS:");
                                            tarea = Console.ReadLine();
                                            if (!String.IsNullOrWhiteSpace(tarea))
                                            {
                                                comprasMiscelaneos.Add(tarea);
                                                Console.WriteLine(" ");
                                                Console.WriteLine("Tarea agregada!");
                                            } else {
                                                Console.WriteLine(usuario +  ", no puedes agregar una tarea vacía");
                                               
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                        break;

                                        case 2:
                                            Console.WriteLine("Tu lista de MISCELANEOS:");
                                            foreach (var item in comprasMiscelaneos)
                                            {
                                                Console.WriteLine(item);
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                        break;

                                        case 3:
                                            Console.WriteLine(usuario +  ", digita el número del item a eliminar:");
                                        for (int i = 0; i < comprasMiscelaneos.Count; i++)
                                        {
                                            Console.WriteLine(i + "- "+  comprasMiscelaneos[i]);
                                        }
                                        eliminar = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Seguro/a que desea eliminar el item: " + comprasMiscelaneos[eliminar] + " ? [Si] o [No]" );
                                        confirm = Console.ReadLine();

                                        if (confirm=="Si" || confirm=="si")
                                        {
                                            Console.WriteLine("Item eliminado." );
                                            comprasMiscelaneos.RemoveAt(eliminar);
                                        }
                                            Console.ReadKey();
                                            Console.Clear();
                                        break;

                                        case 4:
                                            Console.WriteLine("Para editar un item, selecciona su índice:");
                                            for (int i = 0; i < comprasMiscelaneos.Count; i++)
                                        {
                                            Console.WriteLine(i + "- "+  comprasMiscelaneos[i]);
                                        }
                                            editar =  int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ok, escribe el nuevo nombre de  " + comprasMiscelaneos.ElementAt(editar));
                                            newItem = Console.ReadLine();
                                            comprasMiscelaneos.RemoveAt(editar);
                                            comprasMiscelaneos.Insert(editar, newItem);
                                        break;

                                        case 5:
                                            Console.WriteLine(usuario +  ", has salido de la categoría MISCELANEOS:");
                                            Console.ReadKey();
                                            Console.Clear();
                                        break;

                                        default:
                                        System.Console.WriteLine("Opción inválida");
                                        break;
                                    }
                                 // Fin del submenú de MISCELANEOS
                            break;

                            case 4:
                            //salirDeAqui();
                            Console.Clear();
                            Console.WriteLine("                               ");
                            Console.WriteLine("¡HASTA LUEGO, " + usuario + "! ");
                            Console.WriteLine("                               ");
                            salir=true;
                            break;

                            case 5:
                            Console.WriteLine("En ROPAS tienes " + comprasRopa.Count() +  " items");
                            Console.WriteLine("En SUPERMERCADO tienes " + comprasSuper.Count() +  " items");
                            Console.WriteLine("En MISCELANEOS tienes " + comprasMiscelaneos.Count() +  " items");
                            Console.WriteLine("Presiona [ ENTER ] para ver qué contiene cada una ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("SUPERMERCADO:");
                                foreach (var item in comprasSuper)
                                                {
                                                    Console.Write(item + ", ");
                                                }
                            Console.WriteLine(" ");
                            Console.WriteLine("ROPA:");
                                foreach (var item in comprasRopa)
                                                {
                                                    Console.Write(item + ", ");
                                                }
                            Console.WriteLine(" ");
                            Console.WriteLine("MISCELANEOS:");
                                foreach (var item in comprasMiscelaneos)
                                                {
                                                    Console.Write(item + ", ");
                                                }
                            Console.ReadKey();
                            Console.Clear();
                            break;

                            default:
                            System.Console.WriteLine(usuario +  ", lo siento, categoría no encontrada.");
                            break;
                        }   
            } while (!salir);

    }
    // static void salirDeAqui(){
    //     Console.Clear();
    //     Console.WriteLine("                               ");
    //     Console.WriteLine("¡HASTA LUEGO, " + usuario + "! ");
    //     Console.WriteLine("                               ");
    //     salir=true;
    // }
}
