//En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje
//obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes
//resultados:
//• Si los tres dados son seis, mostrar el mensaje “Excelente”
//• Si dos dados son seis, mostrar el mensaje “Muy bien”
//• Si un dado es seis, mostrar el mensaje “Regular”
//• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente”

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    
    int[] dados = new int[3];
    int dado1;
    int dado2;
    int dado3;
    // Start is called before the first frame update
    void Start()
    {
        dado1 = Random.Range(1, 7);
        dado2 = Random.Range(1, 7);
        dado3 = Random.Range(1, 7);

        dados[0] = dado1;
        dados[1] = dado2;
        dados[2] = dado3;
        System.Array.Sort(dados);
        if (dados[2] < 6)
        {
            Debug.Log("Insuficiente");
        }
        else if (dados[2] == 6 && dados[1] < 6)
        {
            Debug.Log("Regular");
        }
        else if (dados[1] == 6 && dados[0] < 6)
        {
            Debug.Log("Muy bien");
        }
        else if (dados[0] == 6)
        {
            Debug.Log("Excelente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
