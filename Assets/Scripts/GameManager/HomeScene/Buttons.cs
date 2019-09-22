using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("highscore", 0);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}