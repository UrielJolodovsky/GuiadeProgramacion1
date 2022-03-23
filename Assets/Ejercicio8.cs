//Crear una variable entera que pueda ser modificada desde el Inspector. Suponiendo que
//el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
//valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
//mensaje de error "El día ingresado no es válido".

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public int dia;
    // Start is called before the first frame update
    void Start()
    {
        if (dia > 0 && dia < 8)
        {
            if (dia == 1)
            {
                Debug.Log("Domingo");
            }
            if (dia == 2)
            {
                Debug.Log("Lunes");
            }
            if (dia == 3)
            {
                Debug.Log("Martes");
            }
            if (dia == 4)
            {
                Debug.Log("Miércoles");
            }
            if (dia == 5)
            {
                Debug.Log("Jueves");
            }
            if (dia == 6)
            {
                Debug.Log("Viernes");
            }
            if (dia == 7)
            {
                Debug.Log("Sabado");
            }
        }
        else
        {
            Debug.Log("El día ingresado no es valido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
