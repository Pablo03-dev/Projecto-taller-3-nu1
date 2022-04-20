using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boton : MonoBehaviour
{

    public GameManager Manager;
    private void OnMouseDown()
    {
        //Manager.GameOver();
        GameManager.felicidad++;
    }
}
