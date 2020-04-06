using UnityEngine;

public class MainMenuQuitButton : MonoBehaviour {

    void Start() {
#if UNITY_EDITOR && !UNITY_STANDALONE
        gameObject.SetActive(false);
#endif
    }
}
