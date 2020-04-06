using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour {

    static public MySceneManager instance { get; private set; }

    public string menuScene;

    [ViewOnly] public bool changingScene;

    public void LoadScene(string sceneName) {
        if (!changingScene)
            StartCoroutine(ChangeToSceneRoutine(sceneName));
    }

    public void RestartScene() {
        if (!changingScene)
            StartCoroutine(ChangeToSceneRoutine(SceneManager.GetActiveScene().name));
    }

    public void QuitToMainMenu() {
#if !UNITY_EDITOR && UNITY_STANDALONE
        if (SceneManager.GetActiveScene().name == menuScene)
            Application.Quit();
#endif
        if (!changingScene)
            StartCoroutine(ChangeToSceneRoutine(menuScene));
    }

    IEnumerator ChangeToSceneRoutine(string scene) {
        changingScene = true;
        yield return new WaitUntil(() => ScreenFader.instance.IsIdle());
        ScreenFader.instance.useUnscaledTime = true;
        ScreenFader.instance.RequestFadeOut();
        yield return new WaitUntil(() => ScreenFader.instance.IsIdle());
        SceneManager.LoadScene(scene);
        changingScene = false;
    }
}
