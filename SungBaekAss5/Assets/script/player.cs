using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float speed;
    //private Rigidbody rb;
    public Text countText;
    private int count;
    public Animator animate;
    public float rotate = 50;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        count = 0;
        animate = GetComponent<Animator>();
        countText.text = "Score: " + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        //Rotation
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotate);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * -rotate);
        }
        //Animations
        //Walk forward
        if (Input.GetKey(KeyCode.W))
        {
            animate.SetBool("idle", false);
            animate.SetBool("walkfoward", true);
        }
        //walk back
        else if (Input.GetKey(KeyCode.S))
        {
            animate.SetBool("walkback", true);
            animate.SetBool("idle", false);
        }
        else
        {
            animate.SetBool("walkfoward", false);
            animate.SetBool("walkback", false);
            animate.SetBool("runforward", false);
            animate.SetBool("runback", false);
            animate.SetBool("idle", true);
        }
        //run
        /*
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            animate.SetBool("runforward", true);
            animate.SetBool("idle", false);
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            animate.SetBool("runback", true);
            animate.SetBool("idle", false);
        }
        //dont walk
        else
        {
            animate.SetBool("walkfoward", false);
            animate.SetBool("walkback", false);
            animate.SetBool("runforward", false);
            animate.SetBool("runback", false);
            animate.SetBool("idle", true);
        }*/

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Capsule"))
        {
            other.gameObject.SetActive(false);
            count++;
            countText.text = "Collect the medicine to open the door. " + 7 + count.ToString() + " left";
        }
        
    }

}
