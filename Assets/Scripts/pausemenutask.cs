using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenutask : MonoBehaviour
{
    public GameObject knifeObject;
    private bool isPaused=false;
    public GameObject pauseMenu;
    public GameObject avatarka;
    public GameObject Text;
    void Update()
    {
        
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
        isPaused = false;
        knifeObject.SetActive(true);
        Cursor.visible = false; // �� ���������� ������
        Time.timeScale = 1f;
        avatarka.SetActive(true);
        Text.SetActive(true);
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        isPaused = true;
        // ������������ ������ ����
        knifeObject.SetActive(false);
        Cursor.visible = true; // ���������� ������
        Cursor.lockState = CursorLockMode.None; // ������������ ������
        Time.timeScale = 0f;
        avatarka.SetActive(false);
        Text.SetActive(false);

    }

    public void LoadMenu()
    {
        KnifeController.isKnifeEquipped = false;
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
