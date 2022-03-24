//Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente
//manera:
//• Si trabaja 40 horas o menos se le paga $16 por hora (crear una constante para almacenar
//el 16)
//• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20
//por cada hora extra. (crear una constante para almacenar el 20)
//Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla
//el salario correspondiente.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    public int horas;
    int hora_extra = 20;
    int salario;
    // Start is called before the first frame update
    void Start()
    {
        if (horas <= 40)
        {
            salario = 16 * horas;
            Debug.Log("$"+salario);
        }
        else
        {
            salario = 16 * 40 + (horas - 40) * hora_extra;
            Debug.Log("$" + salario);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
