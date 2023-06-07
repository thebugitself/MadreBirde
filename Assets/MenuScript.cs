using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
