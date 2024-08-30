using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement2 : MonoBehaviour
{
    public Transform Transform;
    public Rigidbody rb;
    public float Sidewayforce = 1500f;
    public void RightForce()
    {
        rb.AddForce(0, 0, Sidewayforce * Time.deltaTime, ForceMode.VelocityChange);
    }
    public void LeftForce()
    {
        rb.AddForce(0, 0, -Sidewayforce * Time.deltaTime, ForceMode.VelocityChange);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Transform.position.z > 0)
        {
            Invoke("LeftForce", 0.105f);
        }

        if (Transform.position.z < 0)
        {
            Invoke("RightForce", 0.105f);
        }

        if (Transform.position.z == 0)
        {
            rb.AddForce(0, 2000000f * Time.deltaTime, 200000 * Time.deltaTime, ForceMode.VelocityChange);
        }
        /*if(left == 0)
        {
            rb.AddForce(0, Sidewayforce * Time.deltaTime, -Sidewayforce * Time.deltaTime, ForceMode.Force);
            left = 1;
        }
        if(left == 1)
        {
            rb.AddForce(0, Sidewayforce * Time.deltaTime, -Sidewayforce * Time.deltaTime, ForceMode.Force);
            left = 0;
        }*/
    }
    }
