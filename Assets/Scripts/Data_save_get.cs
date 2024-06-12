using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Data_save_get : MonoBehaviour
{
    [SerializeField] TMP_InputField field;
    string Playname;
    int index = 0;
    string bang;

    public void Save()
    {
        Playname = field.text;
        PlayerPrefs.SetString("Player", Playname);

        if (PlayerPrefs.HasKey("index"))
        {
            bool found = false;
            for (int i = 0; i < 99; i++)
            {
                if (KnifeController.players[i] == PlayerPrefs.GetString("Player"))
                {
                    bang = PlayerPrefs.GetString("Player");
                    index = Array.IndexOf(KnifeController.players, bang);
                    PlayerPrefs.SetInt("index", index);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                for (int i = 0; i < 99; i++)
                {
                    if (string.IsNullOrEmpty(KnifeController.players[i]))
                    {
                        index = i;
                        PlayerPrefs.SetInt("index", index);
                        break;
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < 99; i++)
            {
                if (string.IsNullOrEmpty(KnifeController.players[i]))
                {
                    index = i;
                    PlayerPrefs.SetInt("index", index);
                    break;
                }
            }
        }
        KnifeController.players[index] = PlayerPrefs.GetString("Player");

        bang = index.ToString();
        Debug.Log(bang);
        SceneManager.LoadScene(0);
    }



    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
