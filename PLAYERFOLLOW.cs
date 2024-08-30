
using JetBrains.Annotations;
using UnityEngine;

public class PLAYERFOLLOW : MonoBehaviour
{

    public Transform playerposition;
    public Vector3 offset;
    public float smoothtime = 0.125f;
    private Vector3 velocity = Vector3.zero;
    
    void FixedUpdate()
    {
        // Debug.Log(playerposition.position);
        Vector3 desiredposition = playerposition.position + offset;
        Vector3 smoothedposition = Vector3.SmoothDamp(transform.position, desiredposition, ref velocity , smoothtime);
        transform.position = smoothedposition;

        transform.LookAt(playerposition);
    }
}
