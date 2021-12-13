using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public static PlayerHealth phealth; //declared playerhealth
    public float currentHealth; //added current health variable
    public float maxHealth = 100f; //max health the player can have
    public bool isDead = false; //boolean for if the player is dead or alive

    private void Alive()
    {
        phealth = this; //player being alive
    }

    void Start()
    {
        currentHealth = maxHealth; //make the current health equal to max health when starting
    }

    public void PlayerDamage(float damage)
    {
        if(currentHealth > 0) 
        {
            
        if(damage >= currentHealth)
        {
            Dead(); //if player is lower than a certain health he is dead
        }

        else
        {
            currentHealth -= damage; //adding damage to player
           }
        }
    }

    // Update is called once per frame
    public void Dead()
    {
        currentHealth = 0; //if health is 0 he is dead
        isDead = true; //boolean is set to true so player is dead 
        Debug.Log("You are Dead!");
    }
}
