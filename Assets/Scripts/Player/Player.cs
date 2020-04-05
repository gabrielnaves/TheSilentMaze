using UnityEngine;

public class Player : MonoBehaviour {

    static public Player instance { get; private set; }

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
}
