using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatescript : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(20, 50, 70) * Time.deltaTime);
    }
}
