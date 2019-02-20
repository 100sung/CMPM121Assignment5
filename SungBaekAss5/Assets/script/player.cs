using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Text countText;
    private int count;
    public Animator animate;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        animate = GetComponent<Animator>();
        countText.text = "Score: " + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
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
    void FixedUpdate()
    {
        float movehoriz = Input.GetAxis("Horizontal");
        float movevert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movehoriz, 0, movevert);

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity += new Vector3(0, 10, 0);
            
        }
        // superspeed
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Vector3 movements = new Vector3(movehoriz * 4, 0, movevert * 4);
            rb.AddForce(movements * speed);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Capsule"))
        {
            other.gameObject.SetActive(false);
            count++;
            countText.text = "Score: " + count.ToString();
        }
        
    }

}
