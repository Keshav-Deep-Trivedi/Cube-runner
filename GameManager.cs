
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameover = false;
    public float restarttime = 1f;
    public GameObject GameCompleteUI;
    public void Endgame()
    {
            if(gameover == false)
        {
            gameover = true;
            Debug.Log("Game over");
            Invoke("RestartGame", restarttime);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameover = false;
    }
    public void GameComplete()
    {
        GameCompleteUI.SetActive(true);
    }
}
