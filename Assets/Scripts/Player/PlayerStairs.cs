using UnityEngine;

public class PlayerStairs : MonoBehaviour {

    public string stairsTag = "Stairs";

    [ViewOnly] public bool inStairs;

    private void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.transform.CompareTag(stairsTag)) {
            inStairs = true;
        }
    }
}
