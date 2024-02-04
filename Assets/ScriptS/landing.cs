using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace The_Final_Drop_abduosaber
{
    public class landing : MonoBehaviour
    {
        [SerializeField] string coltext;
        [SerializeField] GameObject RocketStatic;
        [SerializeField] GameObject RocketHide;
        [SerializeField] GameObject rocketLanding;
        [SerializeField] GameObject RR;
        [SerializeField] GameObject CameraLanding;
        [SerializeField] GameObject Ubutton;

        private void OnTriggerEnter(Collider col)
        {
            if (col.gameObject == RR)
            {
                RocketStatic.SetActive(true);
                RocketHide.SetActive(false);
                rocketLanding.AddComponent<CharacterController>();
                CameraLanding.SetActive(true);
                Ubutton.SetActive(true);
            }
        }
    }
}
