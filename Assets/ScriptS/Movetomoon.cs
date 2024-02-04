using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace The_Final_Drop_abduosaber
{
    public class Movetomoon : MonoBehaviour
    {
        /// <summary>
        /// speed for rocket
        /// </summary>
        [SerializeField] float speed = 5.0f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float HInput = Input.GetAxis("Horizontal");
            //float VInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.right * Time.deltaTime * speed * HInput);
            //transform.Translate(Vector3.up * Time.deltaTime * speed * -VInput);
            transform.Translate(0, Time.deltaTime * speed, 0);



            //if (Input.GetKey(KeyCode.W))
            //{
            //    transform.rotation = Quaternion.Euler(-90, 0, 0);
            //}
            //else
            //{
            //    transform.rotation = Quaternion.Euler(-90, 0, 0);
            //}

        }

        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.tag == "ene")
            {
                SceneManager.LoadScene(4);
                Debug.Log("hi");
            }
        }
    }
}
