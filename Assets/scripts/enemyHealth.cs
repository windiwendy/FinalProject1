using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public int point;

    public ScoreManager scoreManager;
    //public GameObject Explosion;



    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();    
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0 )
        {

            Destroy(gameObject);
            
            scoreManager.ChangesScore(point);
        
        }
        
    }
}
