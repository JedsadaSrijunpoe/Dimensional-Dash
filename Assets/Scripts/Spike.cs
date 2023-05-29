using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] AudioClip dieSound;

    void OnTriggerEnter2D(Collider2D other) {
        LevelManager.Instance.ReloadLevel();    
        SoundManager.Instance.Play(dieSound);
    }
}
