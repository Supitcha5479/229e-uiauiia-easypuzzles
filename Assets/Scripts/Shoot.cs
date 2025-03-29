using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab; // Attach the bullet prefab
    [SerializeField] private Transform firePosition;  // For tell which direction bullet from
    private float bulletForce;
    private float bulletMass;
    private float bulletSpeed;


    // Start is called before the first frame update
    void Start()
    {
        bulletMass = 5f;
        bulletSpeed = 150f;
        bulletForce = bulletMass * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            shooting();
        }
    }// end update

    void shooting()
    {
        // created bullet
        GameObject bullet = Instantiate(bulletPrefab, firePosition.position, Quaternion.identity);

        // Fire a bullet
        bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * bulletForce);

        // Destroy the bullet after 7 seconds
        Destroy(bullet, 7f);

    }
}// End shoot
