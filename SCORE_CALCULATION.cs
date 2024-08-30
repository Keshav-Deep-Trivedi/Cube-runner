
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SCORE_CALCULATION : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score;
    void Update()
    {
        score.text = player.position.x.ToString("0");
    }
}
