using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragydrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        print("Ndda");
    }

    private void OnMouseDrag()
    {
        Vector3 posicionMouse = Input.mousePosition;
        posicionMouse.z = 10;
        Vector3 posicionCorregida = Camera.main.ScreenToWorldPoint(posicionMouse);
        transform.position = posicionCorregida;
    }
}
