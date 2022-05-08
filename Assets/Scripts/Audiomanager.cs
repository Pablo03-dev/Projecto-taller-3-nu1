using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    public static AudioClip FireSound;
    public static AudioClip HappySound;
    public static AudioClip StepSound;
    //public static AudioClip powerupSound;
    //public static AudioClip impactSound;
    //public static AudioClip healSound;

    static AudioSource audioScr;
    // Start is called before the first frame update
    void Start()
    {
        FireSound = Resources.Load<AudioClip>("Lanzar");
        HappySound = Resources.Load<AudioClip>("Yahoo");
        StepSound = Resources.Load<AudioClip>("Pisada");
    //    powerupSound = Resources.Load<AudioClip>("Power up");
    //    impactSound = Resources.Load<AudioClip>("impacto");
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

    //        case "Power up":
    //            audioScr.PlayOneShot(powerupSound);
    //            break;

    //        case "impacto":
    //            audioScr.PlayOneShot(impactSound);
    //            break;

    //        case "Powerup 2":
    //            audioScr.PlayOneShot(healSound);
    //            break;
        }
    }
}
