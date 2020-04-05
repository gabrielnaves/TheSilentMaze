using UnityEngine;

public class FPSController : MonoBehaviour {

    public float slowWalkSpeed = 2;
    public float walkSpeed = 5;
    public float runSpeed = 10;
    public float movSpeedToBobSpeed;
    public float headBobHeight;
    public float headBobSmoothing;
    public Transform fpsCamera;
    public Groundcheck groundcheck;
    public ShuffledAudioClips footstepSound;

    FPSLook fpsLook;
    FPSMovement fpsMovement;
    FPSHeadBob fpsHeadBob;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        fpsLook = new FPSLook(transform, fpsCamera);
        fpsMovement = new FPSMovement(transform, groundcheck, GetComponent<CharacterController>());
        fpsHeadBob = new FPSHeadBob(fpsCamera, headBobHeight, headBobSmoothing);
    }

    void Update() {
        fpsLook.Update();
        fpsMovement.Update(GetCurrentSpeed());
        fpsHeadBob.Update(IsMoving(), GetCurrentSpeed() * movSpeedToBobSpeed);
        if (fpsHeadBob.steppedDown)
            footstepSound.Play();
    }

    bool IsMoving() {
        return GameInput.instance.movement != Vector2.zero;
    }

    float GetCurrentSpeed() {
        if (GameInput.instance.isWalkingSlowly)
            return slowWalkSpeed;
        if (GameInput.instance.isRunning)
            return runSpeed;
        return walkSpeed;
    }
}

class FPSMovement {

    readonly Transform transform;
    readonly Groundcheck groundcheck;
    readonly CharacterController characterController;

    Vector3 fallingVelocity;

    public FPSMovement(Transform transform, Groundcheck groundcheck, CharacterController characterController) {
        this.transform = transform;
        this.groundcheck = groundcheck;
        this.characterController = characterController;
    }

    public void Update(float movementSpeed) {
        if (groundcheck.isGrounded && fallingVelocity.y < 0)
            fallingVelocity.y = -2f;

        float x = GameInput.instance.movement.x;
        float z = GameInput.instance.movement.y;

        Vector3 move = transform.right * x + transform.forward * z;
        characterController.Move(move * movementSpeed * Time.deltaTime);

        fallingVelocity.y += Physics.gravity.y * Time.deltaTime;

        characterController.Move(fallingVelocity * Time.deltaTime);
    }
}

class FPSLook {

    readonly Transform transform;
    readonly Transform camera;

    float xRotation = 0;

    public FPSLook(Transform transform, Transform camera) {
        this.transform = transform;
        this.camera = camera;
    }

    public void Update() {
        Vector2 cameraMovement = GameInput.instance.cameraMovement * Time.deltaTime;

        xRotation -= cameraMovement.y;
        xRotation = Mathf.Clamp(xRotation, -45f, 90f);

        camera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * cameraMovement.x);
    }
}

class FPSHeadBob {

    public bool steppedDown;

    readonly Transform camera;
    float bobHeight;
    float smoothing;

    float originalHeight = 0;
    float elapsedTime = 0;
    float currentVelocity = 0;
    float previousBobSineWave = 0;

    public FPSHeadBob(Transform camera, float bobHeight, float smoothing) {
        this.camera = camera;
        this.bobHeight = bobHeight;
        this.smoothing = smoothing;
        originalHeight = camera.localPosition.y;
    }

    public void Update(bool isMoving, float bobbingSpeed) {
        steppedDown = false;
        if (isMoving)
            BobCamera(bobbingSpeed);
        else
            ReturnToRestingPoint();
    }

    void BobCamera(float speed) {
        elapsedTime += Time.deltaTime;
        float bobSineWave = Mathf.Sin(elapsedTime * speed);
        if (Mathf.Sign(bobSineWave) != Mathf.Sign(previousBobSineWave))
            steppedDown = true;
        previousBobSineWave = bobSineWave;
        MoveTowards(originalHeight + Mathf.Abs(bobSineWave) * bobHeight);
    }

    void ReturnToRestingPoint() {
        elapsedTime = 0;
        MoveTowards(Mathf.SmoothDamp(camera.localPosition.y, originalHeight, ref currentVelocity, smoothing));
    }

    void MoveTowards(float height) {
        camera.localPosition = new Vector3(camera.localPosition.x, height, camera.localPosition.z);
    }
}
