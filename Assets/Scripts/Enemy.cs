using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

    public Transform startingPos;

    public float[] arcs = new float[0];
    public Color[] colors = new Color[0];
    public float[] speeds;

    NavMeshAgent agent;
    bool move;

    void Awake() {
        agent = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate() {
        CheckNoiseLevel();
        Move();
    }

    void CheckNoiseLevel() {
        FPSController.NoiseLevel noiseLevel = Player.instance.noiseLevel;
        if (noiseLevel != FPSController.NoiseLevel.none)
            move = Vector3.Distance(Player.instance.transform.position, transform.position) < arcs[(int)noiseLevel];
        else move = false;
    }

    void Move() {
        if (move) {
            agent.SetDestination(Player.instance.transform.position);
            agent.speed = speeds[(int)Player.instance.noiseLevel];
        }
        else {
            agent.SetDestination(startingPos.position);
            agent.speed = speeds[1];
        }
    }

    void OnDrawGizmosSelected() {
        for (int i = 0; i < arcs.Length; ++i) {
            Gizmos.color = colors[i];
            Gizmos.DrawWireSphere(transform.position, arcs[i]);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject == Player.instance.gameObject) {
            GetComponent<FootprintSpawner>().SpawnDoubleFootprints();
            Debug.Log("Killed Player");
        }
    }
}
