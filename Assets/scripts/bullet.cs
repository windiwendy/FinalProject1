using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public GameObject Hiteffect;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "randomstuff")
        {
            GameObject effect = Instantiate(Hiteffect, transform.position, Quaternion.identity);
            Destroy(effect, 2f);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            GameObject effect = Instantiate(Hiteffect, transform.position, Quaternion.identity);
            Destroy(effect, 2f);
            Destroy(gameObject);
            collision.gameObject.GetComponent<enemyHealth>().TakeDamage(2);

        }
        else
        {
            GameObject effect = Instantiate(Hiteffect, transform.position, Quaternion.identity);
            Destroy(effect, 2f);
            Destroy(gameObject);
        }


    }
}
