using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace The_Final_Drop_abduosaber
{
    public class Lerp : MonoBehaviour
    {
        [SerializeField] GameObject cameraPoint;
        [SerializeField] Transform Lookat;

        [SerializeField] float lerpspeed = 0.5f;



        void Update()
        {
            transform.position = Vector3.Lerp(transform.position, cameraPoint.transform.position, Time.deltaTime);
            transform.LookAt(Lookat, Vector3.left);
            float minAngle = 0.0f;
            float maxAngle = 90.0f;


            float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time);
            transform.eulerAngles = new Vector3(0, angle, 0);

        }
    }
}