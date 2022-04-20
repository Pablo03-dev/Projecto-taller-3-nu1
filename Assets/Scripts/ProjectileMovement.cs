using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public enum DirectionType
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    public DirectionType direction = DirectionType.RIGHT;

    public float moveSpeed = 10f;

    void Update()
    {   
        switch (direction)
        {
            case DirectionType.UP:
                transform.position += transform.up * moveSpeed * Time.deltaTime;
                break;
            case DirectionType.DOWN:
                transform.position -= transform.up * moveSpeed * Time.deltaTime;
                break;
            case DirectionType.RIGHT:
                transform.position += transform.right * moveSpeed * Time.deltaTime;
                break;
            case DirectionType.LEFT:
                transform.position -= transform.right * moveSpeed * Time.deltaTime;
                break;
            default:
                break;
        }
    }
}
