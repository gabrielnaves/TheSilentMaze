using UnityEngine;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour {

    static public PauseMenu instance { get; private set; }

    public GameObject resumeButton;

    void Awake() {
        instance = (PauseMenu)Singleton.Setup(this, instance);
    }

    void Start() {
        Hide();
    }

    public void Show() {
        GetComponent<CanvasGroup>().alpha = 1;
        GetComponent<CanvasGroup>().interactable = true;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        EventSystem.current.SetSelectedGameObject(resumeButton);
    }

    public void Hide() {
        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().interactable = false;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        EventSystem.current.SetSelectedGameObject(null);
    }
}
