using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        Application.LoadLevel("Maze1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}