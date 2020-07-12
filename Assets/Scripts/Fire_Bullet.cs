using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Bullet : MonoBehaviour
{
    public GameObject Bullet_Object;
    public Transform HotSpot_Position; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate a Game Object
            Instantiate(Bullet_Object,HotSpot_Position.position, Quaternion.identity);
            Broadcaster.Instance.RaiseBulletFired();
        }
    }
}
