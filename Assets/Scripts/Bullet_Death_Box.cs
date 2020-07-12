using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Death_Box : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.tag.Equals("Bullet"))
        {
            Destroy(obj);
        }

    }
}
