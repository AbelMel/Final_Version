using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHealth : MonoBehaviour
{

    public int currentHealth = 100; //setting full health to wolfs

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DamageEnemy(){

        currentHealth--; //adding a curren health variable
        
        if(currentHealth <= 0){ 
            Destroy(gameObject); //if the health is less than or equal to 0 then the object gets destroyed
        }
    }
}
