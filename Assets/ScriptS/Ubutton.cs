using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace The_Final_Drop_abduosaber
{
public class Ubutton : MonoBehaviour
{
    [SerializeField] GameObject rocket1;
    [SerializeField] GameObject rocket2;
    [SerializeField] GameObject U;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.U))
        {
            rocket1.SetActive(false);
            rocket2.SetActive(true);
            U.SetActive(false);
        }
    }
}
}
