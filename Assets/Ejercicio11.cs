//Realizá un programa que resuelva el siguiente problema:
//Deberá ingresarse por Inspector una fecha de compra (String en el siguiente formato:
//YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
//producto comprado. Mostrá a modo de ticket, la información ingresada y el monto a pagar.
//Modelo de Ticket:
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    public string fecha_compra;
    public string nom_comprador;
    public string producto_solicitado;
    public int cant_solicitada;
    public float precio_unitario;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fecha de Compra: "+ fecha_compra + "\n Nombre del comprador: "+nom_comprador+ "\n Producto solicitado: "+producto_solicitado+ "\n Cantidad solicitada: "+cant_solicitada+ "\n Precio unitario: $"+precio_unitario+ "\n Total a pagar: $"+precio_unitario*cant_solicitada);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
