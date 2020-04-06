using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

    public EnemyManager enemyManager;
    public GameEvent onPlayerDied;

    public int currentFloor = 2;

    public Transform startingPos;

    public float[] arcs = new float[0];
    public Color[] colors = new Color[0];
    public float[] speeds;

    [ViewOnly] public bool followingPlayer;
    
    NavMeshAgent agent;
    AudioSource source;
    float sourceVolumeVelocity;

    void Awake() {
        agent = GetComponent<NavMeshAgent>();
        source = GetComponent<AudioSource>();
        enemyManager.AddEnemy(this);
    }

    void Update() {
        float targetVolume = (Player.instance.currentFloor == currentFloor ? 1 : 0);
        source.volume = Mathf.SmoothDamp(source.volume, targetVolume, ref sourceVolumeVelocity, 0.5f);
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
            onPlayerDied.Raise();
        }
    }
}
