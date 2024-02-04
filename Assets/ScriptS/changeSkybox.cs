using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace The_Final_Drop_abduosaber
{
    public class changeSkybox : MonoBehaviour
    {

        [SerializeField] Material Sky1;
        [SerializeField] Material Sky2;
        [SerializeField] GameObject Fire1;
        [SerializeField] GameObject Fire2;
        [SerializeField] GameObject Fire3;
        [SerializeField] GameObject Fire4;
        [SerializeField] GameObject level2;
        // false
        [SerializeField] GameObject Layer1;
        [SerializeField] GameObject Troposphere;
        // true and false

        [SerializeField] GameObject Layer2;
        [SerializeField] GameObject Stratosphere;
        // true and false
        [SerializeField] GameObject Layer3;
        [SerializeField] GameObject Mesosphere;
        // true and false
        [SerializeField] GameObject Layer4;
        [SerializeField] GameObject Thermosphere;
        // true and false
        [SerializeField] GameObject Layer5;
        [SerializeField] GameObject ionosphere;
        // true 
        [SerializeField] GameObject Layer6;
        [SerializeField] GameObject Exosphere;


        // Start is called before the first frame update
        void Start()
        {


        }

        // Update is called once per frame
        void OnTriggerEnter(Collider col)
        {
            //if (col.gameObject.tag == "changesky")
            //{

            //    RenderSettings.skybox = Sky1;
            //    DynamicGI.UpdateEnvironment();
            //    Troposphere.SetActive(false);
            //    Stratosphere.SetActive(true);
            //}


            if (col.gameObject == Layer1)
            {
                RenderSettings.skybox = Sky1;
                DynamicGI.UpdateEnvironment();
                Troposphere.SetActive(false);
                Stratosphere.SetActive(true);
            }
            if (col.gameObject == Layer2)
            {
                Stratosphere.SetActive(false);
                Mesosphere.SetActive(true);
            }
            if (col.gameObject == Layer3)
            {
                Mesosphere.SetActive(false);
                Thermosphere.SetActive(true);
            }
            if (col.gameObject == Layer4)
            {

                Thermosphere.SetActive(false);
                ionosphere.SetActive(true);

            }
            if (col.gameObject == Layer5)
            {
                RenderSettings.skybox = Sky2;
                DynamicGI.UpdateEnvironment();
                ionosphere.SetActive(false);
                Exosphere.SetActive(true);
                Fire1.GetComponent<Transform>().Translate(0, 0, -0.2f * Time.deltaTime);
                Fire1.GetComponent<Transform>().Rotate(6.847f * Time.deltaTime, 0, 0);
                Fire1.AddComponent<Rigidbody>().mass = 100;

            }

            if (col.gameObject == Layer6)
            {

                Fire2.GetComponent<Transform>().Translate(0, 0, -0.2f * Time.deltaTime);
                Fire2.GetComponent<Transform>().Rotate(6.847f * Time.deltaTime, 0, 0);
                Fire2.AddComponent<Rigidbody>().mass = 100;
                Fire3.SetActive(false);
                Fire4.AddComponent<Rigidbody>().mass = 100;
            }

            if (col.gameObject == level2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }
    }
}
