using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyObject2 : MonoBehaviour
{
        //declared player object

    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");//finds object with player tag
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {

            Cursor.lockState = CursorLockMode.None;//unlocks mouse cursor when dead
            Destroy(player);//destroys player


            SceneManager.LoadScene("GameOver2");//loads end scene

            Debug.Log("Dead");
        }
    }
}
