using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    const float MAWHEALTH = 100f;
    private readonly float MAXHEALTH;
    float health;

    private void Start()
    {
        health = MAXHEALTH;
    }

    void Die()
    {
        GetComponent<test>().enabled = false;

    }
    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }
}
