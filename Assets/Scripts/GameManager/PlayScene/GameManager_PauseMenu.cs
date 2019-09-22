using UnityEngine;
using System.Collections;

public class GameManager_PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}