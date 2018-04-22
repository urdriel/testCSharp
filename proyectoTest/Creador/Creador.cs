
using System.Collections.Generic;
using Clientes;
using static Clientes.Cliente;

namespace crearVariables{

    public class  Crear{

        public List<Precio> cargadorListaPrecios(){

            List<Precio> cargadorListaPrecios = new List<Precio>();
            Precio precio1=new Precio("descuento1",10);
            Precio precio2=new Precio("descuento2",20);
            Precio precio3=new Precio("descuento3",30);
            Precio precio4=new Precio("descuento4",40);
            Precio precio5=new Precio("descuento5",50);
            Precio precio6=new Precio("descuento6",60);
            Precio precio7=new Precio("descuento7",70);
            Precio precio8=new Precio("descuento8",80);
            Precio precio9=new Precio("descuento9",10000);

            cargadorListaPrecios.Add(precio1);
            cargadorListaPrecios.Add(precio2);
            cargadorListaPrecios.Add(precio3);
            cargadorListaPrecios.Add(precio4);
            cargadorListaPrecios.Add(precio5);
            cargadorListaPrecios.Add(precio6);
            cargadorListaPrecios.Add(precio7);
            cargadorListaPrecios.Add(precio8);
            cargadorListaPrecios.Add(precio9);

            return cargadorListaPrecios;
       }

        public List<object> cargadorListaPreciosCliente(List<Precio> listPre){

            List<object> listaObjetos = new List<object>();

            foreach (object ob in listPre) {

               listaObjetos.Add(ob);

            }

            return listaObjetos;

        }




    }

}