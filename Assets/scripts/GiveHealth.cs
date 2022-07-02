using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveHealth : MonoBehaviour
{
    public float bonusHP;

    private void Start()
    {
        bonusHP = 15f;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<HealthManager>().HealthPickup(bonusHP);
            Destroy(gameObject);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
