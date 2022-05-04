using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    private void Awake()
    {
        manager = this;
    }

    public int vidas;
   public void GameOver()
    {
        print("EndGame");
    }


    public void WinGame()
    {

    }

    public void ResetearJuego()
    {

    }

    public void QuitarVidas()
    {
        vidas--;

        if(vidas < 1)
        {
            GameOver();
        }
    }

}
