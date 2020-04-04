using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float slowWalkSpeed = 1f;
    public float walkSpeed = 4f;
    public float runSpeed = 8f;

    public Transform groundcheck;
    public float groundDistance = .4f;
    public LayerMask groundMask;
    [ViewOnly] bool isGrounded;

    CharacterController characterController;
    Vector3 velocity;


    void Awake() {
        characterController = GetComponent<CharacterController>();
    }

    void Update() {
        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
            velocity.y = -2f;

        float x = GameInput.instance.movement.x;
        float z = GameInput.instance.movement.y;

        Vector3 move = transform.right * x + transform.forward * z;
        characterController.Move(move * GetCurrentSpeed() * Time.deltaTime);

        velocity.y += Physics.gravity.y * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);
    }

    float GetCurrentSpeed() {
        if (GameInput.instance.isWalkingSlowly)
            return slowWalkSpeed;
        if (GameInput.instance.isRunning)
            return runSpeed;
        return walkSpeed;
    }
}
