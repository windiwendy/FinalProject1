using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] Player_health playerh ;
    public int damage;
    


     void Start()
    {
        
        playerh = FindObjectOfType<Player_health>();
        

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerh.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
