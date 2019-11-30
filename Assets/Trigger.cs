using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
     public Transform target;
     public Rigidbody rb;

     void OnTriggerEnter(Collider other) 
     {
          Debug.Log("object entered trigger area");
     }

     void OnTriggerStay(Collider other) 
     {
          //Debug.Log("object is in trigger area");
          if (Input.GetButtonDown("Use")) {
               Debug.Log("Use action!");
               //target.Translate(0, 50 * Time.deltaTime, 0);
               //rb.AddForce(transform.up * 50f);
          }

     }

     void OnTriggerExit(Collider other) 
     {
          Debug.Log("object left trigger area");
     }

}
