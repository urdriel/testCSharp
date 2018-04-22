using System;
using System.Collections.Generic;

namespace Clientes{
public  class  Cliente{
    string nombre;
    string nif;    
    public Precio precio;

    public Cliente(string nombreV,string nifV, Precio precioV)
        {
            this.nombre=nombreV;
            this.nif=nifV;
            this.precio=precioV;
        }
 

    public string Nombre { get => nombre; set => nombre = value; }
    public string Nif { get => nif; set => nif = value; }
} 
    
public class Precio{
    string nombre;
    decimal cantidad;

     public Precio(string nombreV, decimal cantidadV)
        {
            this.nombre=nombreV;
            this.cantidad=cantidadV;
        }
    public string Nombre { get => nombre; set => nombre = value; }
    public decimal Cantidad { get => cantidad; set => cantidad = value; }
}


public class ClienteInterno:Cliente{
   
  // ClienteInternoVip cliInVip;
   string fechaNacimiento;    
   string departamento;

        public ClienteInterno(string fecNacV,string depV,string nombreV, string nifV, Precio precioV) : base(nombreV, nifV,  precioV)
        {
            this.fechaNacimiento=fecNacV;
            this.departamento=depV;
        }

        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public string Departamento { get => departamento; set => departamento = value; }

     public decimal Suma(){       
         
         return (this.precio.Cantidad) * (decimal)(0.8);
                  
         }
     public override string ToString(){

         string x="Cliente Interno -->"+this.Suma()+"---" +this.departamento+"---"+this.Nif;
         
         return x;

     }
    
}



public class ClienteExterno:Cliente{

    string email;
    string telefono;
    string direccion;

            public ClienteExterno(string emailV , string telefonoV , string direccionV , string nombreV, string nifV, Precio precioV) : base(nombreV, nifV, precioV)
            {
                this.email=emailV;
                this.telefono=telefonoV;
                this.direccion=direccionV;

            }

        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public decimal Suma(){return this.precio.Cantidad;}

        public override string ToString(){

         string x="Cliente Externo-->"+this.Suma() +"---"+ this.email+"---"+this.Nif;
         
         return x;

     }
    
    }

public class ClienteExternoVip:Cliente{

    string telefono;
    string email;
    string direccion; 
    string bonodescuento;

            public ClienteExternoVip(string nifV, string nombreV, string emailV, string telefonoV,string direccionV,string bonoV , Precio precioV) : base(nombreV, nifV, precioV)
            {
                this.Telefono=telefonoV;
                this.email=emailV;
                this.Direccion=direccionV;
                this.bonodescuento=bonoV;
            }

    
    public string Email { get => email; set => email = value; }
    public string Bonodescuento { get => bonodescuento; set => bonodescuento = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public decimal Suma(){return this.precio.Cantidad /* *(Convert.ToDecimal(this.bonodescuento)/100)*/;}

    override public string ToString(){

        string x="Cliente Externo VIP-->"+this.Suma()+"---" + this.email+"---"+this.Nif+"---"+this.Bonodescuento;
         
         return x;
    }           
    
    }

    public class ClienteInternoDirectivo:Cliente{

    string fechaNacimiento;
    string departamento;
    string cuentaGastos;

            public ClienteInternoDirectivo(string fecNacV,string departamentoV, string cuentaGastosV,string nombreV, string nifV, Precio precioV) : base(nombreV, nifV, precioV)
            {
                this.fechaNacimiento=fecNacV;
                this.departamento=departamentoV;
                this.cuentaGastos=cuentaGastosV;
            }

            public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public string Departamento { get => departamento; set => departamento = value; }
    public string CuentaGastos { get => cuentaGastos; set => cuentaGastos = value; }

    public decimal Suma(){
        
        decimal resultado=0;

        if(this.precio.Cantidad<1000)
            resultado = (this.precio.Cantidad)*((decimal)(0.8));
        else
            resultado = (this.precio.Cantidad)*((decimal)(0.5));

        return resultado;}

    override public string ToString(){

        string x="Cliente Interno Directivo--> "+this.Suma()+"---"+this.departamento+"---"+this.Nif+
                 "---"+this.cuentaGastos;
         
         return x;
    }           
    
    }

}

