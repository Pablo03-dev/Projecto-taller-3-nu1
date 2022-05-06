using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    public Slider barrahp;
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
        barrahp.value = vidas;
        vidas--;

        if(vidas < 1)
        {
            GameOver();
        }
    }

}
