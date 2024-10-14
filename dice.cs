using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class dice : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI highscore;

    private void Start()
    {
        highscore.text = PlayerPrefs.GetInt("Highscore",0).ToString();
    }

    public void rolldice()
    {
        int n = Random.Range(1, 7);
        score.text = n.ToString();
        if (n > PlayerPrefs.GetInt("Highscore",0))
        {
            PlayerPrefs.SetInt("Highscore", n);
            highscore.text = n.ToString() ;
        }
    }

    public void resethighscore()
    {
        PlayerPrefs.DeleteKey("Highscore");
        highscore.text = "0";
    }
}
