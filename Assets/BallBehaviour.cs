using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float XRotation = 0;
    public float YRotation = 1;
    public float ZRotation = 0;
    public float DegreesPerSecond = 180;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
        // Vector4 ally = new Vector4(YRotation, XRotation, ZRotation);
        transform.RotateAround(Vector3.zero, axis, DegreesPerSecond * Time.deltaTime);
        DegreesPerSecond += .1F;
        if (DegreesPerSecond > 1000)
            DegreesPerSecond = 180;
        if (DegreesPerSecond > 360)
        {
            // transform.position = new Vector3(5.0f, )
            // transform.RotateAround(Vector4.zero, ally, DegreesPerSecond * Time.deltaTime);
        }
        // transform.Rotate(axis, DegreesPerSecond * Time.deltaTime);
        Debug.DrawRay(Vector3.zero, axis, Color.yellow, .5f);
    }
}
