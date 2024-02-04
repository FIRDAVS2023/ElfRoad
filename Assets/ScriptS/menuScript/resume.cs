using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace The_Final_Drop_abduosaber
{
    public class resume : MonoBehaviour
    {
        public static bool GameIsPaused = false;
        public GameObject pausemenuUI;
        public GameObject ESC;
        public GameObject Atmosphere;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Pause();

            }

        }

        public void Pause()
        {
            pausemenuUI.SetActive(true);
            ESC.SetActive(false);

            Time.timeScale = 0f;
            GameIsPaused = true;
            Atmosphere.SetActive(false);
        }

        public void Resume()
        {
            pausemenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
            ESC.SetActive(true);
            Atmosphere.SetActive(true);

        }

    }
}
