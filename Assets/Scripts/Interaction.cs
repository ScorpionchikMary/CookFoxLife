using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour
{
    public GameObject apple;
    public GameObject carrot;

    public GameObject meet;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && apple.GetComponent<Collider>().bounds.Intersects(GetComponent<Collider>().bounds))
        {
            Interact();
            SceneManager.LoadSceneAsync("Apple");
            SceneManager.LoadScene("Apple");
        }
        if (Input.GetKeyDown(KeyCode.E) && carrot.GetComponent<Collider>().bounds.Intersects(GetComponent<Collider>().bounds))
        {
            InteractCarrot();
            SceneManager.LoadSceneAsync("Carrot");
            SceneManager.LoadScene("Carrot");
        }
       /* if (Input.GetKeyDown(KeyCode.E) && fish.GetComponent<Collider>().bounds.Intersects(GetComponent<Collider>().bounds))
        {
            InteractFish();
            SceneManager.LoadSceneAsync("Fish");
            SceneManager.LoadScene("Fish");
        }*/
        if (Input.GetKeyDown(KeyCode.E) && meet.GetComponent<Collider>().bounds.Intersects(GetComponent<Collider>().bounds))
        {
            InteractMeet();
            SceneManager.LoadSceneAsync("Meet");
            SceneManager.LoadScene("Meet");
        }
      


    }

    void Interact()
    {
        // ���������� ��������� �������
        apple.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
    void InteractCarrot()
    {
        // ���������� ��������� �������
        carrot.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
   
    void InteractMeet()
    {
        // ���������� ��������� �������
        meet.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}

