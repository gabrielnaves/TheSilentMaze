using UnityEngine;

public class PlayerLook : MonoBehaviour {

    public Transform playerCamera;

    float xRotation = 0;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update() {
        Vector2 cameraMovement = GameInput.instance.cameraMovement * Time.deltaTime;

        xRotation -= cameraMovement.y;
        xRotation = Mathf.Clamp(xRotation, -45f, 90f);

        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * cameraMovement.x);
    }
}
