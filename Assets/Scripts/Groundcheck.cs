using UnityEngine;

public class Groundcheck : MonoBehaviour {

    public float groundDistance = .4f;
    public LayerMask groundMask;

    [ViewOnly] public bool isGrounded;

    public System.Action OnLeftGround;
    public System.Action OnReachedGround;

    void Update() {
        bool grounded = Physics.CheckSphere(transform.position, groundDistance, groundMask);
        if (grounded && !isGrounded)
            OnReachedGround?.Invoke();
        else if (!grounded && isGrounded)
            OnLeftGround?.Invoke();
        isGrounded = grounded;
    }
}
