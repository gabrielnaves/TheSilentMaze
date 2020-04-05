using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour {

    static public GameInput instance { get; private set; }

    public enum ControllerType { Keyboard, Controller, PS4 }

    public float mouseSensitivity = 100f;
    public float controllerSensitivity = 1000f;

    [ViewOnly] public ControllerType controllerType;
    [ViewOnly] public Vector2 movement;
    [ViewOnly] public Vector2 joystickCameraMovement;
    [ViewOnly] public Vector2 mouseCameraMovement;
    [ViewOnly] public bool isWalkingSlowly;
    [ViewOnly] public bool isRunning;

    const string controllerTypeKey = "GameInput/ControllerType";

    GameControls controls;

    public Vector2 cameraMovement {
        get {
            if (controllerType == ControllerType.Keyboard)
                return mouseCameraMovement * mouseSensitivity;
            return joystickCameraMovement * controllerSensitivity;
        }
    }

    public void EnableGameplayControls() {
        controls.Gameplay.Enable();
    }

    public void DisableGameplayControls() {
        controls.Gameplay.Disable();
        movement = Vector2.zero;
        joystickCameraMovement = Vector2.zero;
        mouseCameraMovement = Vector2.zero;
    }

    void Awake() {
        instance = (GameInput)Singleton.Setup(this, instance);
        controllerType = (ControllerType)PlayerPrefs.GetInt(controllerTypeKey, 0);
        SetupGameControls();
    }

    void SetupGameControls() {
        controls = new GameControls();
        controls.Gameplay.PlayerMovement.performed += GetMovementInput;
        controls.Gameplay.PlayerMovement.canceled += GetMovementInput;
        controls.Gameplay.CameraMovementJoystick.performed += GetJoystickCameraInput;
        controls.Gameplay.CameraMovementJoystick.canceled += GetJoystickCameraInput;
        controls.Gameplay.Enable();
        controls.UI.Enable();
        controls.ControlType.Enable();
    }

    void GetMovementInput(InputAction.CallbackContext context) {
        movement = context.ReadValue<Vector2>();
    }

    void GetJoystickCameraInput(InputAction.CallbackContext context) {
        joystickCameraMovement = context.ReadValue<Vector2>();
    }

    void Update() {
        UpdateControllerType();
        mouseCameraMovement = 0.75f * mouseCameraMovement + 0.25f * controls.Gameplay.CameraMovementMouse.ReadValue<Vector2>();
        isWalkingSlowly = controls.Gameplay.SlowWalk.ReadValue<float>() != 0;
        isRunning = controls.Gameplay.Run.ReadValue<float>() != 0;
    }

    void UpdateControllerType() {
        if (controls.ControlType.Keyboard.triggered)
            controllerType = ControllerType.Keyboard;
        else if (controls.ControlType.PS4.triggered)
            controllerType = ControllerType.PS4;
        else if (controls.ControlType.Controller.triggered)
            controllerType = ControllerType.Controller;
    }

    void OnDestroy() {
        PlayerPrefs.SetInt(controllerTypeKey, (int)controllerType);
    }
}
