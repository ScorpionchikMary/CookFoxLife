using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class backnow : MonoBehaviour
{

    //для рейтинга
    public TextMeshProUGUI playername;
    public TextMeshProUGUI playername2;
    public TextMeshProUGUI playername3;
    public TextMeshProUGUI playername4;
    public TextMeshProUGUI Apple;
    public TextMeshProUGUI Apple2;
    public TextMeshProUGUI Apple3;
    public TextMeshProUGUI Apple4;
    public TextMeshProUGUI Carrot;
    public TextMeshProUGUI Carrot2;
    public TextMeshProUGUI Carrot3;
    public TextMeshProUGUI Carrot4;
    public TextMeshProUGUI Meet;
    public TextMeshProUGUI Meet2;
    public TextMeshProUGUI Meet3;
    public TextMeshProUGUI Meet4;
   /* public TextMeshProUGUI Fish;
    public TextMeshProUGUI Fish2;
    public TextMeshProUGUI Fish3;
    public TextMeshProUGUI Fish4;*/


    public void Display()
    {
        SceneManager.LoadScene(0);
    }
    public void Update()
    {
        playername.text = KnifeController.players[0];
        playername2.text = KnifeController.players[1];
        playername3.text = KnifeController.players[2];
        playername4.text = KnifeController.players[3];
        Apple.text = KnifeController.playerscore[0, 1].ToString();
        Apple2.text = KnifeController.playerscore[1, 1].ToString();
        Apple3.text = KnifeController.playerscore[2, 1].ToString();
        Apple4.text = KnifeController.playerscore[3, 1].ToString();
        Carrot.text = KnifeController.playerscore[0, 2].ToString();
        Carrot2.text = KnifeController.playerscore[1, 2].ToString();
        Carrot3.text = KnifeController.playerscore[2, 2].ToString();
        Carrot4.text = KnifeController.playerscore[3, 2].ToString();
        Meet.text = KnifeController.playerscore[0, 3].ToString();
        Meet2.text = KnifeController.playerscore[1, 3].ToString();
        Meet3.text = KnifeController.playerscore[2, 3].ToString();
        Meet4.text = KnifeController.playerscore[3, 3].ToString();

    }
}
