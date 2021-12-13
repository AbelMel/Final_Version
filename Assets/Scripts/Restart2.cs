using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame()
    {
        SceneManager.LoadScene("Level2"); //loading scene when button is pressed
    }

    // Update is called once per frame
    public void Update()
    {

    }
}
