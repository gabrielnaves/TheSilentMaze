using UnityEngine;
using UnityEngine.UI;

public class NoiseLevelHUD : MonoBehaviour {

    public Sprite[] sprites;

    Image image;

    void Awake() {
        image = GetComponent<Image>();
    }

    void Update() {
        image.sprite = sprites[(int)Player.instance.noiseLevel];
    }
}
