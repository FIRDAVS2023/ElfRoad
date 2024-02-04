using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace The_Final_Drop_abduosaber
{
    public class PlayerOnMoon : MonoBehaviour
    {

        [SerializeField] GameObject PP;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.U))
            {
                PP.SetActive(true);
            }




        }
    }
}