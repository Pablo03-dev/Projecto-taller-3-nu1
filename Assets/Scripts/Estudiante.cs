using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estudiante : MonoBehaviour
{
    public bool tieneNota = false;
    public void AsignarNota()
    {
        tieneNota = true;
    }
     
    public void ChequearNota()
    {
        if(tieneNota == false)
        {
            GameManager.manager.QuitarVidas();
        }

        gameObject.SetActive(false);
    }

}
