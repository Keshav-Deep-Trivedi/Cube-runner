
using UnityEngine;
using UnityEngine.SceneManagement;
public class START_GAME : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
