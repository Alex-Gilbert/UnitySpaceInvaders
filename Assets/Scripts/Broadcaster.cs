using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Broadcaster : Singleton<Broadcaster>
{
    public event Action Bullet_Fired;
    public void RaiseBulletFired()
    {
        Bullet_Fired?.Invoke();
    }
}
