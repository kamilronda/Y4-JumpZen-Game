using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseState : MonoBehaviour
{
    public Controller controller;

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "Monk")
        {
            controller.isLoseState = true;
            Debug.Log("GAME OVER");
        }

        if(controller.isLoseState == true)
        {
            SceneManager.LoadScene("LoseState");
        }
    }
}
