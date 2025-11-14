using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float speed=100f;
    private float jumpForce = 5f;
 
   
    private void Start()
    {
 
    }
    private void Update()
    {

        gameObject.transform.Rotate(Vector3.up * speed * Time.deltaTime);
        

    }

   
}
