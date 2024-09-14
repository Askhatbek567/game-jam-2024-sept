using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset  = new Vector3(0, 0, -10f);
    private float smoothTime = 0.3f;


    [SerializeField] public Transform target;

    private Vector3 velocity = Vector3.zero;

    // Upd  ate is called once per frame
    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        targetPosition.z = transform.position.z;

    }
}
