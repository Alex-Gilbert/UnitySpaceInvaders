using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Movement : MonoBehaviour
{
    public float Bullet_Speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Bullet_Speed * Time.deltaTime);
    }
}
