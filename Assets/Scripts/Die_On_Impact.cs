using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die_On_Impact : MonoBehaviour
{
    public int Health = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.tag.Equals("Bullet"))
        {
            Health--;
            if (Health == 0) 
            {
                Destroy(this.gameObject);
                Broadcaster.Instance.RaiseEnemyDestroyed();
            }
            else
            {
                Broadcaster.Instance.RaiseEnemyHit();
            }
        }

    }
}
