using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoiseLevelHUD : MonoBehaviour {

    public TextMeshProUGUI text;

    string prefix;

    void Start() {
        prefix = text.text;
    }

    void Update() {
        var noiseLevel = Player.instance.noiseLevel;
        text.text = prefix + noiseLevel;
        if (noiseLevel == FPSController.NoiseLevel.high)
            text.text += "!";
        text.color = Color.Lerp(Color.green, Color.red, (float)noiseLevel / 3);
    }
}
