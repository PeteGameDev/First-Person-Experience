using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
* TASK: Fix the errors in this code
    * Use the Unity Console and Google
* TASK: Comment on each line explaining what it does
*/

public class FPSPG_PlayerHealth : MonoBehaviour
{
    public float playerHealth; //What's this?

    void Update()
    {
        if(playerHealth <= 0) //What's the condition here?
        {
           GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //What does this do?
    }
}
