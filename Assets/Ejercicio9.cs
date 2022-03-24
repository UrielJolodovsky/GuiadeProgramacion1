//Realizá un programa que resuelva el siguiente problema:
//Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: % .... , Monto total aportado: $ ….

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public string nom1;
    public float monto1;
    public string nom2;
    public float monto2;
    public string nom3;
    public float monto3;
    
    // Start is called before the first frame update
    void Start()
    {
        float capital1 = monto1 * 100 / (monto1 + monto2 + monto3);
        float capital2 = monto2 * 100 / (monto1 + monto2 + monto3);
        float capital3 = monto3 * 100 / (monto1 + monto2 + monto3);
        Debug.Log("Nombre: " + nom1 + " Capital aportado: $" + monto1 + " Porcentaje del capital: %" + capital1 + " Monto total aportado: $" + (monto1 + monto2 + monto3));
        Debug.Log("Nombre: " + nom2 + " Capital aportado: $" + monto2 + " Porcentaje del capital: %" + capital2 + " Monto total aportado: $" + (monto1 + monto2 + monto3));
        Debug.Log("Nombre: " + nom3 + " Capital aportado: $" + monto3 + " Porcentaje del capital: %" + capital3 + " Monto total aportado: $" + (monto1 + monto2 + monto3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
