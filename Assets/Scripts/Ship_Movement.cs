using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Movement : MonoBehaviour
{
    public float Ship_Speed = 10f;
    public float X_min;
    public float X_max;

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
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, X_min, X_max);
        transform.position = position;
        
    }
}
