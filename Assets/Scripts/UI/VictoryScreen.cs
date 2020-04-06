using System.Collections;
using UnityEngine;

public class VictoryScreen : MonoBehaviour {

    static public VictoryScreen instance { get; private set; }

    public CanvasGroupFader whiteFader;
    public CanvasGroupFader imageFader;

    void Awake() {
        instance = (VictoryScreen)Singleton.Setup(this, instance);
    }

    void Start() {
        whiteFader.SetAlphaValue(0);
        imageFader.SetAlphaValue(0);
    }

    public void Show() {
        StartCoroutine(VictoryRoutine());
    }

    IEnumerator VictoryRoutine() {
        whiteFader.RequestFadeIn();
        yield return new WaitUntil(() => whiteFader.IsIdle());
        yield return new WaitForSeconds(2);
        imageFader.RequestFadeIn();
        yield return new WaitUntil(() => imageFader.IsIdle());
        yield return new WaitForSeconds(3);
        yield return new WaitUntil(() => Input.anyKeyDown);
        MySceneManager.instance.QuitToMainMenu();
    }
}
