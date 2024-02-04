using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace The_Final_Drop_abduosaber
{
    public class MoveMentrocket : MonoBehaviour
    {
        [SerializeField] float movmentSpace = 0.5f;

        private void Start()
        {

        }
        public void Update()
        {
            //if (Input.GetKey(KeyCode.W))
            //{
            //    movmentSpace = 400f;

            //}





        }
        public void FixedUpdate()
        {

            if (movmentSpace < 400)
            {
                movmentSpace += 1f;
                transform.Translate(0, movmentSpace * Time.deltaTime, 0);
            }
            else
            {
                movmentSpace = 400f;
                transform.Translate(0, movmentSpace * Time.deltaTime, 0);

            }

        }

    }
}
