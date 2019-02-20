using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatescript : MonoBehaviour
{

    GameObject part;
    GameObject part1;
    GameObject part2;
    GameObject part3;
    GameObject part4;
    GameObject part5;
    GameObject part6;
    //public ParticleSystem stuff;
    void Start()
    {

        /*
        part = GameObject.Find("part");
        part1 = GameObject.Find("part1");
        part2 = GameObject.Find("part2");
        part3 = GameObject.Find("part3");
        part4 = GameObject.Find("part4");
        part5 = GameObject.Find("part5");
        part6 = GameObject.Find("part6");
        part.SetActive(false);
        part1.SetActive(false);
        part2.SetActive(false);
        part3.SetActive(false);
        part4.SetActive(false);
        part5.SetActive(false);
        part6.SetActive(false);*/
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(20, 50, 70) * Time.deltaTime);
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.name == "part")
            {

                part.SetActive(true);
            }
            if (other.gameObject.name == "part1")
            {

                part1.SetActive(true);
            }
            if (other.gameObject.name == "part2")
            {

                part2.SetActive(true);
            }
            if (other.gameObject.name == "part3")
            {

                part3.SetActive(true);
            }
            if (other.gameObject.name == "part4")
            {

                part4.SetActive(true);
            }
            if (other.gameObject.name == "part5")
            {

                part5.SetActive(true);
            }
            if (other.gameObject.name == "part6")
            {

                part6.SetActive(true);
            }
        }
    }*/
    
}
