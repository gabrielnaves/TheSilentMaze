using System.Collections;
using UnityEngine;

public class GameOverScreen : MonoBehaviour {

    static public GameOverScreen instance { get; private set; }

    public GameEvent restartPlayerPositionEvent;
    public ShuffledAudioClips screamingSounds;

    CanvasGroupFader fader;
    bool busy;

    void Awake() {
        instance = (GameOverScreen)Singleton.Setup(this, instance);
        fader = GetComponent<CanvasGroupFader>();
    }

    void Start() {
        fader.SetAlphaValue(0);
    }

    public void Show() {
        if (!busy)
            StartCoroutine(GameOverRoutine());
    }

    IEnumerator GameOverRoutine() {
        busy = true;
        screamingSounds.Play();
        fader.RequestFadeIn();
        yield return new WaitUntil(() => fader.IsIdle());
        yield return new WaitForSeconds(2);
        restartPlayerPositionEvent.Raise();
        fader.RequestFadeOut();
        busy = false;
    }
}
