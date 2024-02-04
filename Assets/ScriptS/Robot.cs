using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace The_Final_Drop_abduosaber
{
    public class Robot : MonoBehaviour
    {
        bool active = false;
        [SerializeField] GameObject camRobot;



        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.U) && active == false)
            {
                camRobot.SetActive(true);
                active = true;
            }
            else if (Input.GetKey(KeyCode.O) && active == true)
            {
                camRobot.SetActive(false);
                active = false;
            }
        }

    }
}
