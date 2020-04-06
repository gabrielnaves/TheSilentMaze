using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

    public EnemyManager enemyManager;

    public int currentFloor = 2;

    public Transform startingPos;

    public float[] arcs = new float[0];
    public Color[] colors = new Color[0];
    public float[] speeds;

    NavMeshAgent agent;
    [ViewOnly] public bool followingPlayer;

    void Awake() {
        agent = GetComponent<NavMeshAgent>();
        enemyManager.AddEnemy(this);
    }

    void FixedUpdate() {
        CheckNoiseLevel();
        Move();
    }

    void CheckNoiseLevel() {
        FPSController.NoiseLevel noiseLevel = Player.instance.noiseLevel;
        if (currentFloor == Player.instance.currentFloor && noiseLevel != FPSController.NoiseLevel.none)
            followingPlayer = Vector3.Distance(Player.instance.transform.position, transform.position) < arcs[(int)noiseLevel];
        else followingPlayer = false;
    }

    void Move() {
        if (followingPlayer) {
            agent.SetDestination(Player.instance.transform.position);
            agent.speed = speeds[(int)Player.instance.noiseLevel];
        }
        else {
            agent.SetDestination(startingPos.position);
            agent.speed = speeds[1];
        }
    }

    void OnDestroy() {
        enemyManager.RemoveEnemy(this);
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
