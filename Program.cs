using System;

namespace ActividadDiccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> inventario = new Dictionary<string, int>(); 

            inicializarInventario(inventario);

            int eleccionUsuario;
            menuPrincipal();
            eleccionUsuario = InputHelper.IngresarInt("Elija que hacer: ", 1, 5);
            while (eleccionUsuario != 5)
            {
                switch (eleccionUsuario)
                {
                    case 1:
                        verInventario(inventario);
                        break;
                    case 2:
                        actualizarStock(inventario);
                        break;
                    case 3:
                        consumirRecurso(inventario);
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    
                    default:
                        Console.WriteLine("[ERROR] Valor inválido. Volviendo al menú...");
                        break;
                }
            }
        }

        static void inicializarInventario(Dictionary<string,int> inventario)
        {
            inventario.Add("Madera", 10);
            inventario.Add("Hierro", 10);
            inventario.Add("Piedra", 10);
        }

        static void menuPrincipal(){
            Console.WriteLine("Menú Principal");
            Console.WriteLine("----------------------------");
            Console.WriteLine(">>> Ver inventario       [1]");
            Console.WriteLine(">>> Actualizar stock     [2]");
            Console.WriteLine(">>> Consumir recurso     [3]");
            Console.WriteLine(">>> Consultar Recurso    [4]");
            Console.WriteLine(">>> Salir                [5]");
            Console.WriteLine("----------------------------");
        }

        static void verInventario(Dictionary<string,int> inventario)
        {
            foreach(string s in inventario.Keys)
            {
                Console.WriteLine($"Nombre: {s}");
                Console.WriteLine($"Cantidad: {inventario[s]}");
            }
        }

        static void actualizarStock(Dictionary<string,int> inventario)
        {
            string materialUsuario = InputHelper.IngresarString("Ingrese el material para actualizar el stock:");
            if(inventario.ContainsKey(materialUsuario))
            {
                int cantidadStock = InputHelper.IngresarInt("Este material ya existe. Ingrese la cantidad de stock que le desea agregar: ");
                while (cantidadStock == -1){
                    Console.WriteLine("[ERROR] Valor inválido. Volver a intentar...");
                    cantidadStock = InputHelper.IngresarInt("Ingrese la cantidad de stock que le desea agregar: ");
                }
                inventario[materialUsuario] += cantidadStock;
                Console.WriteLine("Se ha actualizado el stock correctamente!");
            }
            else{
                string deseaAgregarlo;
                do{
                    deseaAgregarlo = InputHelper.IngresarString("Este material no existe. Desea agregarlo al inventario (y/n):");
                    if (deseaAgregarlo.ToLower() == "y"){
                        inventario.Add(materialUsuario, 0)
                        Console.WriteLine("Se ha agregado el nuevo material con éxito. Stock actual del material: 0");
                    }
                    else if (deseaAgregarlo.ToLower() == "n"){
                        Console.WriteLine("Volviendo al menú...");
                    }
                    else{
                        Console.WriteLine("[ERROR] Valor inválido. Volver a intentar...");
                    }
                } while(deseaAgregarlo.ToLower() != "y" && deseaAgregarlo.ToLower() != "n");
            }
        }

        static void consumirRecurso(Dictionary<string,int> inventario){
            string materialUsuario = InputHelper.IngresarString("Ingrese el material para consumir:");
            if(inventario.ContainsKey(materialUsuario))
            {
                int cantidadStockConsumido = InputHelper.IngresarInt($"Ingrese la cantidad de stock consumido. Stock de {materialUsuario}: {inventario[materialUsuario]}: ");
                while (cantidadStock == -1){
                    Console.WriteLine("[ERROR] Valor inválido. Volver a intentar...");
                    cantidadStock = InputHelper.IngresarInt("Ingrese la cantidad de stock que le desea agregar: ");
                }
                inventario[materialUsuario] += cantidadStock;
                Console.WriteLine("Se ha actualizado el stock correctamente!");
            }
        }
    }
}
