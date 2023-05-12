using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_health : MonoBehaviour
{

    public int phealth;
    public int MaxHealth = 10;
    //public health healthBar;

    // Start is called before the first frame update
    void Start()
    {
        phealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
    



        
    }

    public void TakeDamage(int amount)
    {
        phealth -= amount;

        if (phealth <= 0)
        {
            gameObject.GetComponent<Renderer>().enabled = false;

            Destroy(gameObject);

        }
    }
}
