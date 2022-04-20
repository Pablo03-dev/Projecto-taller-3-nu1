using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movrieles : MonoBehaviour
{

    public float speed;
    Vector2 nuevapos;
    public float riel = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            riel++;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            riel--;
        }

        //riel == riel.clamp
    }

    
}
