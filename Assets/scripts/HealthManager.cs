using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    const float MAXHEALTH = 100f;
    float health = 100f;
    public Slider healthSlider;

    private void Start()
    {
        health = MAXHEALTH;
        healthSlider.value = health / MAXHEALTH;
    }



    void Die()
    {
        GetComponent<Test>().enabled = false;
        GetComponentInChildren<Animator>().SetBool("Dead", true);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            health = 0;
            Die();
        }

        healthSlider.value = health / MAXHEALTH;
    }

    public void HealthPickup(float amount)
    {
        if (health < MAXHEALTH)
        {
            health += amount;
            if (health > MAXHEALTH)
                health = MAXHEALTH;
        }

    }

}
