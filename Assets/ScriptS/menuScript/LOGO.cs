using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace The_Final_Drop_abduosaber
{
    public class LOGO : MonoBehaviour
    {
        [SerializeField] byte Scene;
        [SerializeField] byte Seconds;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine("Countdown");
        }

        [System.Obsolete]
        public IEnumerator Countdown()
        {
            yield return new WaitForSeconds(Seconds);
            Application.LoadLevel(Scene);
        }
    }
}