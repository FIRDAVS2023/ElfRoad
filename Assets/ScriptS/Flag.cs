using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace The_Final_Drop_abduosaber
{
    public class Flag : MonoBehaviour
    {
        [SerializeField] GameObject False;
        [SerializeField] GameObject True;
        [SerializeField] GameObject End;
        [SerializeField] GameObject point;
        [SerializeField] GameObject rocket;
        [SerializeField] GameObject Player;
        [SerializeField] GameObject rocketcol;
        [SerializeField] bool tf = false;

        [SerializeField] GameObject[] Rocks = new GameObject[1];
        [SerializeField] GameObject[] lights = new GameObject[1];
        [SerializeField] GameObject[] Go = new GameObject[1];

        [SerializeField] GameObject informationsmoon;
        [SerializeField] GameObject flag;

        [SerializeField] GameObject robot;
        [SerializeField] GameObject robottrue;

        // Start is called before the first frame update
        public void OnTriggerEnter(Collider col)
        {
            if (col.gameObject == False)
            {
                False.SetActive(false);
                True.SetActive(true);
                lights[0].SetActive(true);
                lights[1].SetActive(true);
                Go[0].SetActive(false);
                Go[1].SetActive(true);
                flag.SetActive(true);
            }
            if (col.gameObject == Rocks[0])
            {
                informationsmoon.SetActive(true);
                flag.SetActive(false);
                Rocks[0].SetActive(false);
                lights[0].SetActive(false);
            }
            if (col.gameObject == Rocks[1])
            {
                informationsmoon.SetActive(true);
                flag.SetActive(false);
                Rocks[1].SetActive(false);
                lights[1].SetActive(false);
                robot.SetActive(true);
                Go[1].SetActive(false);
                Go[2].SetActive(true);
            }
            if (col.gameObject == robot)
            {
                robottrue.SetActive(true);
                robot.SetActive(false);
                Go[2].SetActive(false);
                Go[3].SetActive(true);
                informationsmoon.SetActive(false);
                tf = true;
            }

            if (tf)
            {
                point.SetActive(true);
            }
            if (col.gameObject == point)
            {
                rocket.transform.Translate(0, 45, 0);
                Player.SetActive(false);
                rocketcol.SetActive(true);
                End.SetActive(true);
            }
        }
    }
}