using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.transform.tag == "Player")
        {
            GameManager.numberOfCoins++;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            Destroy(gameObject, 0.5f);
        }
   }
}
