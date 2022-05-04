using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("Profe cam Izqui", true);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("Profe cam Izqui", false);
        }
    }
}
