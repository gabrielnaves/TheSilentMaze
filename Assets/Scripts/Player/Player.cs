using UnityEngine;

public class Player : MonoBehaviour {

    static public Player instance { get; private set; }

    public Transform initialPosition;
    public int currentFloor = 1;
    
    public FPSController.NoiseLevel noiseLevel {
        get {
            return fpsController.noiseLevel;
        }
    }

    FPSController fpsController;

    void Awake() {
        instance = (Player)Singleton.Setup(this, instance);
        fpsController = GetComponent<FPSController>();
    }

    public void UpdateFloor(int newFloor, Transform newInitialPosition) {
        currentFloor = newFloor;
        initialPosition = newInitialPosition;
    }

    public void ResetPosition() {
        transform.position = initialPosition.position;
    }
}
