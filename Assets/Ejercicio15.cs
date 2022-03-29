//Existen dos reglas que identifican dos conjuntos de valores:
//-El número es de un solo dígito.
//- El número es impar.
//A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA,
//estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,
//para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a
//ninguno, respectivamente. Definí un lote de prueba de varios números y probá el algoritmo,
//escribiendo los resultados.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    public int num;
    bool estaEnA = false;
    bool estaEnB = false;
    bool estaEnAmbos = false;
    bool noEstaEnNinguno = false;
    // Start is called before the first frame update
    void Start()
    {
        if (num > -10 && num < 10 && num%2==1 || num%2==-1)
        {
            estaEnAmbos = true;
            Debug.Log("estaEnAmbos = " + estaEnAmbos);
        }
        else if (num > -10 && num < 10)
        {
            estaEnA = true;
            Debug.Log("estaEnA = " + estaEnA);
        }
        else if (num%2==1 || num%2==-1)
        {
            estaEnB = true;
            Debug.Log("estaEnB = " + estaEnB);
        }
        else
        {
            noEstaEnNinguno = true;
            Debug.Log("noEstaEnNinguno" + noEstaEnNinguno);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
