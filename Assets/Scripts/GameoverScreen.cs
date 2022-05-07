using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameoverScreen : MonoBehaviour
{
    public Text pointsText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Puntos ";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Base juego");
    }

    public void ExittButton()
    {
        SceneManager.LoadScene("Menu Principal");
    }
}
