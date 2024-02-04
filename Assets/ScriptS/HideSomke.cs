using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSomke : MonoBehaviour
{
    [SerializeField] byte Seconds;
    private void Start()
    {

        Destroy(gameObject, Seconds);
    }
    public void Update()
    {
        if (Seconds == 5)
        {
            gameObject.AddComponent<Rigidbody>();
            
        }
    }
}
