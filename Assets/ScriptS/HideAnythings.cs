using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace The_Final_Drop_abduosaber
{
    public class HideAnythings : MonoBehaviour
    {

        [SerializeField] byte Seconds;
        private void Start()
        {

            Destroy(gameObject, Seconds);
        }


    }
}
