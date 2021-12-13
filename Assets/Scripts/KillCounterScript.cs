using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class KillCounterScript : MonoBehaviour
{


    //set the killcount start number
    public static int killCount = 0;
    //added score to update the text UI 
    Text score;

    void Start()
    {
        //score is equal to text
        score = GetComponent<Text>();
    }


    void Update()
    {
        //prints Kills: then score count
        score.text = "Kills: " + killCount;

        //if the kills reach to 4 then the game ends
        if(KillCounterScript.killCount == 4){
            SceneManager.LoadScene("Level1Complete"); //loads completed level scene

                        Cursor.lockState = CursorLockMode.None; //unlocks cursor


            Debug.Log("Working");
        }
    }
}
