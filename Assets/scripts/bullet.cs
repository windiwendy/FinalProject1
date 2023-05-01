using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public GameObject Hiteffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
       
        GameObject effect = Instantiate(Hiteffect, transform.position, Quaternion.identity);   
        Destroy(effect, 2f);
        Destroy(gameObject);

    }
}
