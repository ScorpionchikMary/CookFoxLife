using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class KnifeController : MonoBehaviour
{
    private int scene;
    public GameObject knifeObject; // объект ножа
    public static bool isKnifeEquipped = false; // флаг, является ли нож экипированным
    public Camera mainCamera; // основная камера
    private Rigidbody rb;
    public static int index = 0;
    public GameObject iteration1;
    public GameObject iteration2;
    public GameObject iteration3;
    public GameObject iteration4;
    public GameObject iteration5;
    public GameObject iteration6;
    public GameObject iteration7;
    public GameObject iteration8;
    public GameObject iteration9;
    public GameObject contur1;
    public GameObject contur2;
    public GameObject contur3;
    public GameObject contur4;
    public GameObject contur5;
    public GameObject contur6;
    public GameObject contur7;
    public GameObject contur8;
    public float GameSeconds;
    int intseconds;
    public TextMeshProUGUI textComponent;
    public static int[,] playerscore = new int[100, 5];
    public static string[] players = new string[100];

    void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1f;
        if (scene == 2)
        {
           textComponent.text = "Возьми нож, нажав на клавишу E. Чтобы выйти в главное меню, нажми сначала ESC, а потом уже на кнопку Главное меню. Подготовим яблоко. Убираем плодоножку и очищаем кожуру яблока."; 
        }
        if (scene == 3)
        {
            textComponent.text = "Возьми нож, нажав на клавишу E. Чтобы выйти в главное меню, нажми сначала ESC, а потом уже на кнопку Главное меню. Очищаем морковь от кожуры и стебля"; 
        }
        if (scene == 4)
        {
            textComponent.text = "Возьми нож, нажав на клавишу E. Чтобы выйти в главное меню, нажми сначала ESC, а потом уже на кнопку Главное меню. Находим место где соединяется тушка и голень. По центру нужно вывернуть кость, пока она не щелкнет и именно здесь срезать ножом."; 
        }
        
    }

    void Update()
    {
        GameSeconds = GameSeconds + Time.deltaTime;
        intseconds = (int)GameSeconds;
        // Обновляем координаты курсора, чтобы он был на том же месте, что и нож
        Cursor.visible = false; // скрываем курсор
        Cursor.lockState = CursorLockMode.Confined; // блокируем курсор в центре экрана
                                                    // Если нажата клавиша E и нож не экипирован
       
        if (Input.GetKeyDown(KeyCode.E) && isKnifeEquipped==false)
        {
            EquipKnife();
        }

        // Если нож экипирован, перемещаем его как курсор
        if (isKnifeEquipped)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 1; // Устанавливаем координату Z для правильного расположения ножа по глубине
            Vector3 knifePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            knifeObject.transform.position = new Vector3(knifePosition.x, 3.4f, knifePosition.z);} 
        }
    

    void EquipKnife()
    {
        // Активируем объект ножа
        knifeObject.SetActive(true);
        knifeObject.transform.rotation = Quaternion.Euler(0, -90, 85);
        isKnifeEquipped = true;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (scene == 2)
        {
            if (collision.gameObject.CompareTag("contur1"))
            {
                // Если объект найден, выполняем действие
                iteration1.SetActive(false);
                contur1.SetActive(false);
                textComponent.text = "Кладем очищенное яблоко вертикально на разделочную доску. Разрезаем его пополам прямо через сердцевину, используя острый нож.";
                iteration2.SetActive(true);
                contur2.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur2"))
            {
                // Если объект найден, выполняем действие
                iteration2.SetActive(false);
                contur2.SetActive(false);
                textComponent.text = "Затем разрезаем первую половинку пополам, чтобы получить 2 примерно равных ломтика.";
                iteration3.SetActive(true);
                contur3.SetActive(true);
            }
            // Проверяем, является ли объект целевым
            if (collision.gameObject.CompareTag("contur3"))
            {
                // Если объект найден, выполняем действие
                iteration3.SetActive(false);
                contur3.SetActive(false);
                textComponent.text = "Теперь разрезаем вторую половинку пополам, чтобы получить 2 примерно равных ломтика.";
                iteration4.SetActive(true);
                contur4.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur4"))
            {
                // Если объект найден, выполняем действие
                iteration4.SetActive(false);
                contur4.SetActive(false);
                textComponent.text = "Дальше удаляем сердцевины. Используя нож, извлекаем часть яблока без косточек из каждого ломтика.";
                iteration5.SetActive(true);
                contur5.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur5"))
            {
                // Если объект найден, выполняем действие
                iteration5.SetActive(false);
                contur5.SetActive(false);
                iteration6.SetActive(true);
                contur6.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur6"))
            {
                // Если объект найден, выполняем действие
                iteration6.SetActive(false);
                contur6.SetActive(false);
                textComponent.text = "Вырезаем только маленький полумесяц, который покрывает семена, чтобы сохранить яблоко как можно лучше. Сердцевину выбрасываем в мусорную корзину.";
                iteration7.SetActive(true);
                contur7.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur7"))
            {
                // Если объект найден, выполняем действие
                iteration7.SetActive(false);
                contur7.SetActive(false);
                iteration8.SetActive(true);
                contur8.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur8"))
            {
                // Если объект найден, выполняем действие
                iteration8.SetActive(false);
                contur8.SetActive(false);
                iteration9.SetActive(true);
                textComponent.text = "Молодец! Теперь ты умеешь правильно нарезать яблоко!";
                index = PlayerPrefs.GetInt("index");
                if (PlayerPrefs.HasKey("Player"))
                {
                    playerscore[index, 1] = intseconds;
                }
                isKnifeEquipped = false;
                Time.timeScale = 1f;
                Invoke("Delay", 3.0f);
            }
        }
        if (scene == 3)
        {
            if (collision.gameObject.CompareTag("contur1"))
            {
                // Если объект найден, выполняем действие
                iteration1.SetActive(false);
                contur1.SetActive(false);
                textComponent.text = "Потом обрезаем верхний и нижний концы моркови, чтобы она стала ровной и удобной для нарезки.";
                iteration2.SetActive(true);
                contur2.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur2"))
            {
                // Если объект найден, выполняем действие
                iteration2.SetActive(false);
                contur2.SetActive(false);
                iteration3.SetActive(true);
                contur3.SetActive(true);
            }
            // Проверяем, является ли объект целевым
            if (collision.gameObject.CompareTag("contur3"))
            {
                // Если объект найден, выполняем действие
                iteration3.SetActive(false);
                contur3.SetActive(false);
                textComponent.text = "Чтобы нарезать кружочками, сначала нарезаем морковь на кружки, начиная от верхнего конца и двигаясь вниз, используя острый нож.";
                iteration4.SetActive(true);
                contur4.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur4"))
            {
                // Если объект найден, выполняем действие
                iteration4.SetActive(false);
                contur4.SetActive(false);
                iteration5.SetActive(true);
                contur5.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur5"))
            {
                // Если объект найден, выполняем действие
                iteration5.SetActive(false);
                contur5.SetActive(false);
                textComponent.text = "Стараемся нарезать кружки равномерно, чтобы они были ровными и аккуратными.";
                iteration6.SetActive(true);
                contur6.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur6"))
            {
                // Если объект найден, выполняем действие
                iteration6.SetActive(false);
                contur6.SetActive(false);
                iteration7.SetActive(true);
                contur7.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur7"))
            {
                // Если объект найден, выполняем действие
                iteration7.SetActive(false);
                contur7.SetActive(false);
                iteration8.SetActive(true);
                contur8.SetActive(false);
                textComponent.text = "Молодец! Теперь ты умеешь правильно нарезать морковь кружочками";
                index = PlayerPrefs.GetInt("index");
                if (PlayerPrefs.HasKey("Player"))
                {
                    playerscore[index, 2] = intseconds;
                }
                Time.timeScale = 1f;
                isKnifeEquipped = false;
                Invoke("Delay", 3.0f);
            }
         
        }
        if (scene == 4)
        {
            if (collision.gameObject.CompareTag("contur1"))
            {
                // Если объект найден, выполняем действие
                iteration1.SetActive(false);
                contur1.SetActive(false);
                textComponent.text = "Тоже самое повторяем со второй.";
                iteration2.SetActive(true);
                contur2.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur2"))
            {
                // Если объект найден, выполняем действие
                iteration2.SetActive(false);
                contur2.SetActive(false);
                textComponent.text = "Дальше идут крылья: делаем надрезы у хреща, есть кость - выворачиваем, чтобы сустав было видно, и срезаем крыло.";
                iteration3.SetActive(true);
                contur3.SetActive(true);
            }
            // Проверяем, является ли объект целевым
            if (collision.gameObject.CompareTag("contur3"))
            {
                // Если объект найден, выполняем действие
                iteration3.SetActive(false);
                contur3.SetActive(false);
                iteration4.SetActive(true);
                contur4.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur4"))
            {
                // Если объект найден, выполняем действие
                iteration4.SetActive(false);
                contur4.SetActive(false);
                textComponent.text = "По центру грудки идёт кость и поэтому режем рядом с ней по центру. Чем ближе к кости срезаем, тем больше мяса останется на грудке. Кончиком ножа подрезаем мясо и приподнимаем грудку.";
                iteration5.SetActive(true);
                contur5.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur5"))
            {
                // Если объект найден, выполняем действие
                iteration5.SetActive(false);
                contur5.SetActive(false);
                iteration6.SetActive(true);
                contur6.SetActive(true);
            }
            if (collision.gameObject.CompareTag("contur6"))
            {
                // Если объект найден, выполняем действие
                iteration6.SetActive(false);
                contur6.SetActive(false);
                iteration7.SetActive(true);
                contur7.SetActive(false);
                textComponent.text = "Каркас, который остаётся, можно использовать для супа или соуса. Молодец! Теперь ты умеешь правильно разделывать курицу";
                index = PlayerPrefs.GetInt("index");
                if (PlayerPrefs.HasKey("Player"))
                {
                    playerscore[index, 3] = intseconds;
                }
                Time.timeScale = 1f;
                isKnifeEquipped = false;
                Invoke("Delay", 3.0f);
            }

        }
    }
    public void Delay()
    {
        SceneManager.LoadSceneAsync("Kitchen_work");
        SceneManager.LoadScene("Kitchen_work");
    }
}
