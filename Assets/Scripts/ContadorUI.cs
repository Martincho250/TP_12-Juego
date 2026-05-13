using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ContadorUI : MonoBehaviour
{
   public TextMeshProUGUI textoTiempo;

    float tiempoTranscurrido = 0f;

    bool corriendo = true;

    void Update()
    {
        if(corriendo)
        {
            tiempoTranscurrido += Time.deltaTime;

            int minutos = Mathf.FloorToInt(tiempoTranscurrido / 60);
            int segundos = Mathf.FloorToInt(tiempoTranscurrido % 60);
            int milisegundos = Mathf.FloorToInt((tiempoTranscurrido * 1000) % 1000);

            textoTiempo.text = string.Format("{0:00}:{1:00}:{2:000}",
                                             minutos,
                                             segundos,
                                             milisegundos);
        }
    }

    // FUNCIÓN PARA DETENER EL CRONÓMETRO
    public void DetenerCronometro()
    {
        corriendo = false;
    }
}