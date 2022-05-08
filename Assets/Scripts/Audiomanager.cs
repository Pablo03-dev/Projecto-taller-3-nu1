using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    public static AudioClip FireSound;
    public static AudioClip HappySound;
    public static AudioClip StepSound;
    public static AudioClip PointSound;
    public static AudioClip FailSound;
    //public static AudioClip healSound;

    static AudioSource audioScr;
    // Start is called before the first frame update
    void Start()
    {
        FireSound = Resources.Load<AudioClip>("Lanzar");
        HappySound = Resources.Load<AudioClip>("Yahoo");
        StepSound = Resources.Load<AudioClip>("Pisada");
        PointSound = Resources.Load<AudioClip>("Coin");
        FailSound = Resources.Load<AudioClip>("Fail");
    //    healSound = Resources.Load<AudioClip>("Powerup 2");

       audioScr = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Lanzar": audioScr.PlayOneShot(FireSound);
                break;

            case "Yahoo":
                audioScr.PlayOneShot(HappySound);
                break;

            case "Pisada":
                audioScr.PlayOneShot(StepSound);
                break;

            case "Coin":
                audioScr.PlayOneShot(PointSound);
                break;

            case "Fail":
                audioScr.PlayOneShot(FailSound);
                break;

    //        case "Powerup 2":
    //            audioScr.PlayOneShot(healSound);
    //            break;
        }
    }
}
