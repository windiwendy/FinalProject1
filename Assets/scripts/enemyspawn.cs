using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public float spawnRate = 1f;
    [SerializeField]   public GameObject[] enemyObj;
    public bool canSpawn = true;

   // public Player_health Phealth;
    






    // Start is called before the first frame update
    void Start()
    {
        //Phealth= FindObjectOfType<Player_health>();


    
        


        StartCoroutine(Spawner());
       
    }

    IEnumerator Spawner()
    {

        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (canSpawn) {
            yield return wait;


            int ran = Random.Range(0, enemyObj.Length);

            GameObject enemyToSpawn = enemyObj[ran];


            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);


        }


    }

}
