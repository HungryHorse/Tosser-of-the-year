using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Camera theCamera;
    public float smoothing = 5.0f;
    public float adjustmentAngle = 0.0f;
    public Transform target;

    void Start()
    {
    }

    void FixedUpdate()
    {

        if (Input.GetButton("Fire1"))
        {
            Vector3 newPos = theCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.Lerp(transform.position, newPos, (smoothing * 0.1f));
        }
    }
}

