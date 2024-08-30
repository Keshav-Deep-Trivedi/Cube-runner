
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 1000f;
    public float SidewayForce = 500f;
    public float JumpForce = 1000f;
    public void Jump()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
         //rb.useGravity = false;
       // rb.AddForce(2000, 0, 0);
        

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(ForwardForce* Time.deltaTime, 0, 0);

        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0, 0, -SidewayForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0, 0, SidewayForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.Impulse);
            Invoke("Jump", 1f);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
