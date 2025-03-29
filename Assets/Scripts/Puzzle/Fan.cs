using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fan : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 spin;
    float spinSpeed = 10f;

    private bool isFanActive = true;  // Check if Fan still moving 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isFanActive = FindAnyObjectByType<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        FanSpin();
    }

    private void FanSpin()
    {
        if (isFanActive == true)
        {
            rb.AddTorque(spin * spinSpeed);
        }

        else if (isFanActive == false)
        {
            // Instane stop
            rb.angularVelocity = Vector3.zero;
        }

    }

    // MEthod for stop the fan
    public void StopFan()
    {
        isFanActive = false;  // set Fan to stop moving
    }
}// End Fan
