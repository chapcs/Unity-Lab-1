using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 = y axis, 180 degrees
        // Time.deltaTime turns it by seconds instead of frames, this is static
        transform.Rotate(Vector3.up, 180 * Time.deltaTime);
    }
}
