using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SFX_Manager : MonoBehaviour
{
    public AudioClip player_fired_sfx;
    public AudioClip enemy_hit_sfx;
    public AudioClip enemy_destroyed;

    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        Broadcaster.Instance.Bullet_Fired += () => audioSource.PlayOneShot(player_fired_sfx);
        Broadcaster.Instance.enemy_hit += () => audioSource.PlayOneShot(enemy_hit_sfx);
        Broadcaster.Instance.enemy_destroyed += () => audioSource.PlayOneShot(enemy_destroyed);

    }
    private void OnBulletFired()
    {
        audioSource.PlayOneShot(player_fired_sfx);
    }
}
