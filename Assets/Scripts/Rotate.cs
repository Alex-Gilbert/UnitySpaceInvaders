using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float Rotate_Speed = 10;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Rotate_Speed * Time.deltaTime);
        //transform.Translate(Vector3.right);
    }
}
