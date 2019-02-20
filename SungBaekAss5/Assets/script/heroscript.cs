using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heroscript : MonoBehaviour
{
    public float speed;
    public Text countText;
    private int count;
    public Animator animate;
    public Animator door;
    public float rotate = 50;
    public float running;
    GameObject part;

    // Start is called before the first frame update
    void Start()
    {
        
        count = 0;
        animate = GetComponent<Animator>();
        countText.text = "Score: " + count.ToString();
        part = GameObject.Find("part");
       
        part.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            animate.SetBool("walkfoward", true);
            Debug.Log(animate.GetBool("walkforward"));
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
            animate.SetBool("walkforward", true);
            Debug.Log(animate.GetBool("walkforward"));
        }
        //walk back
        else if (Input.GetKey(KeyCode.S))
        {
            animate.SetBool("walkback", true);
        }
        else
        {
            animate.SetBool("walkforward", false);
            animate.SetBool("walkback", false);
            animate.SetBool("runforward", false);
            animate.SetBool("runback", false);
            //animate.SetBool("idle", true);
        }
        //run
        
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.forward * running * Time.deltaTime);
            animate.SetBool("runforward", true);
        }
        if(count == 7)
        {
            door.SetBool("open", true);
        }
        
        //dont walk
        /*else
        {
            animate.SetBool("walkforward", false);
            animate.SetBool("walkback", false);
            animate.SetBool("runforward", false);
            animate.SetBool("idle", true);
        }*/


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Capsule"))
        {
            other.gameObject.SetActive(false);
            count++;
            part.SetActive(true);
            countText.text = "Collect the medicine to open the door. Medicine Collected: " + count.ToString();
        }

    }

}
