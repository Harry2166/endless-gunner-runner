using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("PRESSED!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
