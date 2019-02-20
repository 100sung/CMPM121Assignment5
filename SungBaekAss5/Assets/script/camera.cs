using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//reference https://www.youtube.com/watch?v=WBzh7XhCF6s

public class camera : MonoBehaviour
{
    public Camera first;
    public Camera third;
    public Camera back;
    public GameObject Hero;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //offset = transform.position - Hero.transform.position;
        third.enabled = true;
        first.enabled = false;
        back.enabled = false;
    }
    void OnGUI()
    {
        if(GUI.Button(new Rect(0, 150, 200, 50), "Third Person"))
        {
            first.enabled = false;
            third.enabled = true;
            back.enabled = false;
        }
        if(GUI.Button(new Rect(0, 200, 200, 50), "First Person"))
        {
            first.enabled = true;
            third.enabled = false;
            back.enabled = false;
        }
        if(GUI.Button(new Rect(0, 250, 200, 50), "Back Cam"))
        {
            first.enabled = false;
            third.enabled = false;
            back.enabled = true;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            first.enabled = false;
            third.enabled = true;
            back.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            first.enabled = true;
            third.enabled = false;
            back.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            first.enabled = false;
            third.enabled = false;
            back.enabled = true;
        }
    }

    void LateUpdate()
    {
        //transform.position = Hero.transform.position;
    }
}
