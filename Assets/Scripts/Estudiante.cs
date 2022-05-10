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
            Audiomanager.PlaySound("Fail");
            GameManager.manager.QuitarVidas();
        }
        else
        {
            GameManager.manager.AddScore(10);
        }

        Invoke("DesactEstudiante", 0.3f);
       


    }

    void DesactEstudiante()
    {
        gameObject.SetActive(false);
    }

    private void Start()
    {
        
    }

}
