using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movrieles : MonoBehaviour
{

    public float speed;
    Vector2 nuevapos;
    public int riel = 0;
    // Start is called before the first frame update
    private void Start()
    {
        nuevapos.y = 2.36f;
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

        riel = Mathf.Clamp(riel, -2, 2);

        if (riel == -2)
            nuevapos.x = -8;

        if (riel == -1)
            nuevapos.x = -4;

        if (riel == 0)
            nuevapos.x = 0;

        if (riel == 1)
            nuevapos.x = 4;

        if (riel == 2)
            nuevapos.x = 8;

        transform.position = nuevapos;
    }

    
}
