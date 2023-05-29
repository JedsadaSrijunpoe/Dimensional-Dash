using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] AudioClip collectSound;

    void OnTriggerEnter2D(Collider2D other) 
    {
        //Add the coin to the player wallet when collectd
        Wallet wallet = other.GetComponent<Wallet>();
        if(wallet != null)
        {
            wallet.IncrementCoins();
            Destroy(gameObject);
            SoundManager.Instance.Play(collectSound);
        }
    }
}
