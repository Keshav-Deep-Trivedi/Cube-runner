
using UnityEngine;

public class OBSTACLE_MOVEMENT : MonoBehaviour
{
    public Transform Transform;
    public Rigidbody rb;
    public float SidewayForce = 1500f;
    public int left = 0;
    public float JumpForce = 1000f;
    void FixedUpdate()
    {
        /* if (Transform.position.z>0)
         {
             rb.AddForce(0,0, -Sidewayforce * Time.deltaTime,ForceMode.VelocityChange);
             left = 0;
         }
         if (Transform.position.z < 0)
         {
             rb.AddForce(0, 0, Sidewayforce * Time.deltaTime,ForceMode.VelocityChange);
             left = 1;
         }
         if (Transform.position.z > 1 && Transform.position.z < -1 )
         {
             rb.AddForce(0,2000000f * Time.deltaTime, 200000 * Time.deltaTime, ForceMode.VelocityChange);
         }
         if (Transform.position.z == 0 && (left == 0 || left == 1))
         {
             rb.AddForce(0, 2000000f * Time.deltaTime , -200000 * Time.deltaTime, ForceMode.VelocityChange);
         }*/

        if (Input.GetKey(KeyCode.D))
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
        }
    }
}
