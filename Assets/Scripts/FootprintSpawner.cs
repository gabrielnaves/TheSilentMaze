using UnityEngine;

public class FootprintSpawner : MonoBehaviour {

    public GameObject footprintPrefab;
    public float distanceDelta;
    public Groundcheck groundcheck;
    public Transform footprintContainer;

    Vector3 previousPosition;
    bool flip;

    void Start() {
        previousPosition = transform.position;
        groundcheck.OnReachedGround += SpawnDoubleFootprints;
    }

    public void SpawnDoubleFootprints() {
        flip = false;
        SpawnFootprint();
        SpawnFootprint();
    }

    void Update() {
        if (ShouldSpawnFootprint())
            SpawnFootprint();
    }

    bool ShouldSpawnFootprint() {
        return groundcheck.isGrounded && Vector3.Distance(previousPosition, transform.position) >= distanceDelta;
    }

    void SpawnFootprint() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, groundcheck.groundMask)) {
            var footprint = Instantiate(footprintPrefab, footprintContainer);
            footprint.transform.position = hit.point + Vector3.up * 0.02f;
            footprint.transform.rotation = Quaternion.Euler(90, transform.rotation.eulerAngles.y, 0);
            footprint.transform.position += footprint.transform.right * (flip ? .15f : -.15f);
            if (flip) {
                var scale = footprint.transform.localScale;
                scale.x *= -1;
                footprint.transform.localScale = scale;
            }
            flip = !flip;
            previousPosition = transform.position;
        }
    }
}
