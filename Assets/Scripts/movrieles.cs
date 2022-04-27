using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movrieles : MonoBehaviour
{

    public float speed;
    public float distanciaRiel;
    Vector2 nuevapos;
    public float distanciaMax;

    private void Start()
    {
        nuevapos.y = transform.position.y;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) )
        {
            nuevapos.x += distanciaRiel;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           nuevapos.x -= distanciaRiel;
        }

        nuevapos.x = Mathf.Clamp(nuevapos.x, 0, distanciaMax);



        transform.position = Vector2.MoveTowards(transform.position, nuevapos, speed * Time.deltaTime);
    }

    
}
