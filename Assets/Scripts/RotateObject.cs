using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float degreesPerSecond = 360f; // 1 rotation per second

    void Update()
    {
        // Get the center position of the object
        Vector3 position = GetComponent<Renderer>().bounds.center;

        // Rotate the object around its center point
        transform.RotateAround(position, Vector3.up, degreesPerSecond * Time.deltaTime);
    }
}
