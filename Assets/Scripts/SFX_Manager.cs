using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SFX_Manager : MonoBehaviour
{
    public AudioClip player_fired_sfx;
    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        Broadcaster.Instance.Bullet_Fired += OnBulletFired;

    }
    private void OnBulletFired()
    {
        audioSource.PlayOneShot(player_fired_sfx);
    }
}
