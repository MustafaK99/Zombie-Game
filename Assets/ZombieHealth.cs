using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public float health = 90f;
 

    public void TakeDamage(float amount) {

      
        health -= amount;
      

    }

     void Update()
    {
        if (health <= 0)
        {
           
            Destroy(gameObject);
        }
    }

}
