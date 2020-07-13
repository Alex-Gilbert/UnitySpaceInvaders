using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Broadcaster : Singleton<Broadcaster>
{
    public event Action Bullet_Fired;
    public event Action enemy_hit;
    public event Action enemy_destroyed;
    public void RaiseBulletFired()
    {
        Bullet_Fired?.Invoke();
    }
    public void RaiseEnemyHit()
    {
        enemy_hit?.Invoke();
    }
    public void RaiseEnemyDestroyed()
    {
        enemy_destroyed?.Invoke();
    }
}
