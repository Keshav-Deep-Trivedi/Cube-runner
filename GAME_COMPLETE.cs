
using UnityEngine;

public class GAME_COMPLETE : MonoBehaviour
{
    public GameManager GameManager;
    void OnTriggerEnter()
    {
        GameManager.GameComplete();
    }
}
    
