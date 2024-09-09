using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float delay = 2f;
    public GameObject completeUI;

    public void CompleteLevel()
    {
        completeUI.SetActive(true);
    }

    public void EndGame () 
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Invoke("StartGame", delay);
        }
    }

    void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
