using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
 public void PlayGame()
        {
        SceneManager.LoadSceneAsync("Kitchen_work");// в кавычках название сцены на которую осуществляется переход
        }

 public void ExitGame()
        {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
    public void go()
    {
        SceneManager.LoadScene(5);
    }
    public void profile()
    {
        SceneManager.LoadScene(6);
    }
}
