using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag=="Star")
        {
            gameObject.tag = "PowerUp";
            gameObject.GetComponentInChildren<Renderer>().material.color = Color.green;
            StartCoroutine("reset");
            Destroy(collision.gameObject);
        }
    }
    IEnumerator reset()
    {
        yield return new WaitForSeconds(5f);
        gameObject.tag = "Player";
        gameObject.GetComponentInChildren<Renderer>().material.color = Color.white;
    }
}
