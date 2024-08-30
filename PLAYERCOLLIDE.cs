
using UnityEngine;

public class PLAYERCOLLIDE : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "OBSTACLE")
        {
            PlayerMovement.enabled = false;
            Debug.Log("you hit an obstacle");
            FindObjectOfType<GameManager>().Endgame(); 
        }
    }
}
