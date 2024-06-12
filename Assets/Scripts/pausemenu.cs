using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public static bool isPaused;
    public GameObject pauseMenu;

    void Start()
    {
isPaused=false;
    }
    void Update()
    {
        if (isPaused)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.visible = false; // не показываем курсор
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
        Cursor.visible = true; // показываем курсор
        

    }

    public void LoadMenu()
    {
        KnifeController.isKnifeEquipped = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
