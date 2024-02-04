using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Transform earth;
    public bool alignToEarth = true;

    float gravity = 9.8f;
    Rigidbody r;

    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 toCenter = earth.position - transform.position;
        toCenter.Normalize();

        r.AddForce(toCenter * gravity, ForceMode.Acceleration);

        if (alignToEarth)
        {
            Quaternion q = Quaternion.FromToRotation(transform.up, -toCenter);
            q = q * transform.rotation;
            transform.rotation = Quaternion.Slerp(transform.rotation, q, 1);
        }
    }
}
