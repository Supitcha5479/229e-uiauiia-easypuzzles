using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;
    public float rotationSpeed = 500f;
    public float jumpHeight = 2f;
    public float gravity = 30f;

    private CharacterController characterController;
    private Vector3 velocity; // Stores vertical velocity
    private bool isGrounded;

    void Start()
    {
        // Get the CharacterController component attached to the GameObject
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Check if character is on the ground
        isGrounded = characterController.isGrounded;

        // Reset downward velocity when grounded
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Small negative value to ensure the character stays grounded
        }

        // Get input from the player (WASD)
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow
        float verticalInput = Input.GetAxis("Vertical");   // W/S or Up/Down Arrow

        // Calculate movement direction in local space (based on character's orientation)
        Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;

        // Normalize the movement vector to prevent faster movement diagonally
        if (moveDirection.magnitude > 1f)
        {
            moveDirection.Normalize();  // Normalize the vector to make diagonal movement speed consistent
        }

        // If there's any input, rotate the character to face the movement direction
        if (moveDirection.magnitude >= 0.1f)
        {
            // Rotate the character to face the movement direction ONLY if moving forward
            if (verticalInput > 0)
            {
                float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationSpeed, 0.1f);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
            }
        }

        // Apply movement
        characterController.Move(moveDirection * speed * Time.deltaTime);

        // Jumping logic
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * 2f * gravity);
        }

        // Apply gravity
        velocity.y -= gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }

}
