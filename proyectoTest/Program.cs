using System;
using System.Collections.Generic;
using System.Linq;
using Clientes;
using crearVariables;
using extensionesPersonalizadas;
using static Clientes.Cliente;

namespace proyectoTest
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Precio precio1=new Precio("descuento1",10);
            Precio precio2=new Precio("descuento2",20);
            Precio precio3=new Precio("descuento3",30);
            Precio precio4=new Precio("descuento4",40);
            Precio precio5=new Precio("descuento5",50);
            Precio precio6=new Precio("descuento6",60);
            Precio precio7=new Precio("descuento7",70);
            Precio precio8=new Precio("descuento8",80);
            Precio precio9=new Precio("descuento9",10000);

            ClienteInterno cliInt1=new ClienteInterno("2000","eletronica","juan muñoz","1234567h",precio1);
            ClienteInterno cliInt2=new ClienteInterno("2005","televisores","alberto sosa","1234567h",precio2);
            ClienteInterno cliInt3=new ClienteInterno("1985","restaurante","antonio heredia","1234567h",precio3);
            ClienteExterno cliInt4=new ClienteExterno("cliente1@gmal.com","123456999","casa de cliente4","Juan el ausente","126548-4",precio4);
            ClienteExterno cliInt5=new ClienteExterno("cliente2@gmal.com","123456-5-9","casa de cliente5","antonio el ausente","126548-5",precio5);
            ClienteExternoVip cliInt6=new ClienteExternoVip("123432h","perico palotes","perico@gmail.com","988767898","calle palotes","descuento numero 1",precio6);
            ClienteExternoVip cliInt7=new ClienteExternoVip("123432sddh","juanico palotes","juanico@gmail.com","988767445","calle desconocida","descuento numero 2",precio7);       
            ClienteInternoDirectivo cliInt8=new ClienteInternoDirectivo("24/08/1980","Hogar","cuenta gastos 1","Maria de la O","3333444555",precio8);
            ClienteInternoDirectivo cliInt9=new ClienteInternoDirectivo("24/08/1990","Hogar","cuenta gastos 2","Elena de la O","33335554479",precio9);
           
            List<object> listaClientes = new List<object>(); 

            listaClientes.Add(cliInt1);
            listaClientes.Add(cliInt2);
            listaClientes.Add(cliInt3);
            listaClientes.Add(cliInt4);
            listaClientes.Add(cliInt5);
            listaClientes.Add(cliInt6);
            listaClientes.Add(cliInt7);
            listaClientes.Add(cliInt8);
            listaClientes.Add(cliInt9);

            Console.WriteLine("<--------LISTADO TODOS LOS CLIENTES EN LISTACLIENTES-------------->");

            foreach (object cliente in listaClientes){

                    Console.WriteLine (cliente);                                               

                    }

            Console.WriteLine("<--------LISTADO TODOS LOS CLIENTES EN LISTACLIENTES-------------->"); 

            List<ClienteExternoVip> listaClientes1= new List<ClienteExternoVip>();
            List<ClienteExternoVip> listaClientes2= new List<ClienteExternoVip>();
            List<ClienteExternoVip> listaClientes3= new List<ClienteExternoVip>();

            ClienteExternoVip cliExVip1=new ClienteExternoVip("123432h1","1perico palotes1","perico@gmail.com1","9887678981","calle palotes1","descuento numero 11",precio6);
            ClienteExternoVip cliExVip2=new ClienteExternoVip("123432h2","2perico palotes2","perico@gmail.com2","9887678982","calle palotes2","descuento numero 12",precio9);
            ClienteExternoVip cliExVip3=new ClienteExternoVip("123432h3","3perico palotes3","perico@gmail.com3","9887678983","calle palotes3","descuento numero 13",precio8);
            ClienteExternoVip cliExVip4=new ClienteExternoVip("123432h4","4perico palotes4","perico@gmail.com4","9887678984","calle palotes4","descuento numero 11",precio8);
            ClienteExternoVip cliExVip5=new ClienteExternoVip("123432h5","5perico palotes5","perico@gmail.com5","9887678985","calle palotes5","descuento numero 15",precio3);

            listaClientes1.Add(cliExVip1);
            listaClientes1.Add(cliExVip2);
            listaClientes1.Add(cliExVip3);

            listaClientes2.Add(cliExVip4);
            listaClientes2.Add(cliExVip5);

            Console.WriteLine("<--------RESULTADO LISTAS-------------->"); 

            // añado los valoresa de lista1 a lista3
            foreach (ClienteExternoVip x  in listaClientes1)
            {
                listaClientes3.Add(x);
            }
            
            // añado los valoresa de lista2 a lista3
            foreach (ClienteExternoVip x  in listaClientes2)
            {
                listaClientes3.Add(x);
            }

            // saco por pantalla los valores que ha recogido listaclientes3 para comprobar
            foreach (ClienteExternoVip x in listaClientes3)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("<--------RESULTADO LISTAS-------------->"); 

            string bonoDescuento="descuento numero 11";
            // hago una consulta linq sobre la lista de clientes3 y almaceno los objects en extraerDatos
            var extraerDatos = 
                from ClienteExternoVip in listaClientes3
                where ClienteExternoVip.Bonodescuento==bonoDescuento
                select new {ClienteExternoVip.Nombre , ClienteExternoVip.Nif};

            Console.WriteLine("<--------RESULTADO LINQ-------------->");    

            //recorro extraer datos y saco por pantalla los valores que necesito
            foreach (object clienteExterno in extraerDatos){
                Console.WriteLine(clienteExterno);
            }

            Console.WriteLine("<--------RESULTADO LINQ-------------->");    
         
        string metodoPersonalizado="Frase de prueba para probar si c# sabe contar vocales";

        Console.WriteLine("<--------FRASE PARA CONTAR-------------->");    

        Console.WriteLine(metodoPersonalizado);

        Console.WriteLine("<--------FRASE PARA CONTAR-------------->");    
        
        Console.WriteLine("la frase introducida contiene  " + metodoPersonalizado.CountCustom() + " vocales");


        /*Console.WriteLine("<--------RECOGER DATOS -------------->");  

        Crear objetoCreado = new Crear();
        List<Precio> listaPrecios1=new List<Precio>();
        listaPrecios1=objetoCreado.cargadorListaPrecios();
        List<object> listaObjetos = new List<object>();
        listaObjetos=objetoCreado.cargadorListaPreciosCliente(listaPrecios1);
        
        foreach (Precio cli in listaObjetos){

            Console.WriteLine(cli.Nombre+"---"+cli.Cantidad);

        }*/


         }



    }

}
