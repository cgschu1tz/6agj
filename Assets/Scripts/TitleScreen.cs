using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class TitleScreen : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Start clicked");
    }

    public void EndGame()
    {
        Application.Quit(0);
        Debug.Log("End clicked");
    }
}
