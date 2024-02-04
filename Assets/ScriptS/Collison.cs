using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace The_Final_Drop_abduosaber
{
    public class Collison : MonoBehaviour
    {
        [SerializeField] int abduo2233;
        [SerializeField] string tag1;
        [SerializeField] GameObject player;
        [SerializeField] GameObject Rocket;
        [SerializeField] GameObject level2;
        [SerializeField] GameObject Atmosphere1;
        [SerializeField] GameObject Frist;





        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.tag == tag1)
            {

                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                player.SetActive(false);
                level2.SetActive(true);
                Rocket.AddComponent<MoveMentrocket>();
                Atmosphere1.SetActive(true);
                Frist.SetActive(false);

            }
        }
    }
}
