using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
namespace The_Final_Drop_abduosaber
{
    public class Video : MonoBehaviour
    {
        [SerializeField] float Timer = 300f;
        [SerializeField] GameObject viseo;
        
        [SerializeField] GameObject text;
        //VideoTimeSource video2;
        [SerializeField] VideoPlayer h;
        [SerializeField] GameObject audio1;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            Timer -= 0.5f;
            if (Timer == 0)
            {
                audio1.SetActive(true);
                viseo.SetActive(false);
                h.Pause();
                text.SetActive(true);
            }
        }
    }
}