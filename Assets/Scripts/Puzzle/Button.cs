using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float torque;
    private Fan fanScript;// for link the fan from Fan scripts
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        fanScript = FindFirstObjectByType<Fan>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Renderer>().material.color = Color.green;

            // force the fan to stop spinning
            if (fanScript != null) // Check if fanScript is exist if it's exist the code will work
            {
                fanScript.StopFan();  // call method StopFan in Fan
            }
        }


    }// End OntriggerEnter
}// End button
