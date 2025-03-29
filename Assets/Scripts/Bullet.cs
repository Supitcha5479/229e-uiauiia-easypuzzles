using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object collided is an obstacle
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Destroy both the bullet and the obstacle upon collision
            Destroy(collision.gameObject); // Destroy the obstacle
            Destroy(gameObject); // Destroy the bullet
        }
    }
}
