using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Movement : MonoBehaviour
{
    public float Ship_Speed = 10f; 

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Ship_Speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Ship_Speed * Time.deltaTime);

        }
    }
}
