using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace The_Final_Drop_abduosaber
{
    public class EndLevel : MonoBehaviour
    {
        [SerializeField] float Timer = 100f;
        // Start is called before the first frame update

        // Update is called once per frame
        void FixedUpdate()
        {
            Timer -= 0.5f;
            if (Timer == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}