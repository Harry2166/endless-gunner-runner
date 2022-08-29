using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("QUIT GAME!");
        Application.Quit();
    }
}
