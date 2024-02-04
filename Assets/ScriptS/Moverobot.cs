using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace The_Final_Drop_abduosaber
{
    public class Moverobot : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {

        float H = 5f;
        bool move;
        public Vector3 move1;
        [SerializeField] GameObject robot;


        // Update is called once per frame
        public void Update()
        {
            if (move)
            {
                robot.transform.Translate(move1 * Time.deltaTime * H);
            }

        }
        //public void UP(int i)
        //{
        //    if (i == 0)
        //        transform.Translate(0, 0, Time.deltaTime * H);
        //    else if (i == 1)
        //        transform.Translate(Time.deltaTime * H, 0, 0);
        //    else if (i == 2)
        //        transform.Translate(-Time.deltaTime * H, 0, 0);
        //    else
        //        transform.Translate(0, 0, -Time.deltaTime * H);
        //}
        public void OnPointerDown(PointerEventData eventData)
        {
            move = true;
            //if (move == true)
            //{
            //    if (i == 0)
            //        transform.Translate(0, 0, Time.deltaTime * H);
            //    else if (i == 1)
            //        transform.Translate(Time.deltaTime * H, 0, 0);
            //    else if (i == 2)
            //        transform.Translate(-Time.deltaTime * H, 0, 0);
            //    else
            //        transform.Translate(0, 0, -Time.deltaTime * H);
            //}

        }
        public void OnPointerUp(PointerEventData eventData)
        {
            move = false;
        }


    }
}
