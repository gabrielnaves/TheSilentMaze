using UnityEngine;

public class PlayerFloorArrival : MonoBehaviour {

    public GameObject previousFloorBlockingWall;

    bool playerPassed;

    void Start() {
        previousFloorBlockingWall.SetActive(false);
    }

    void OnTriggerEnter(Collider other) {
        if (!playerPassed && other.gameObject == Player.instance.gameObject) {
            previousFloorBlockingWall.SetActive(true);
            Player.instance.currentFloor++;
            playerPassed = true;
        }
    }
}
