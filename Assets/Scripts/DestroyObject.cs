using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
{

    //declared player health and player object
    private PlayerHealth playerHealth;
    private GameObject player;

    void Start()
    {
        //takes information from PlayerHealth Script
        playerHealth = GetComponent<PlayerHealth>();
        player = GameObject.FindWithTag("Player"); //finds object with player tag
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Cursor.lockState = CursorLockMode.None; //unlocks mouse cursor when dead
            Destroy(player); //destroys player

            playerHealth.Dead();

            SceneManager.LoadScene("GameOver"); //loads end scene

            Debug.Log("Dead");
        }
    }
}
