using UnityEngine;

public class MazeEnd : MonoBehaviour {

    public GameEvent victoryEvent;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject == Player.instance.gameObject)
            victoryEvent.Raise();
    }
}
