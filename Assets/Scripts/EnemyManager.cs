using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Managers/Enemy Manager")]
public class EnemyManager : ScriptableObject {

    List<Enemy> enemies = new List<Enemy>();

    public void AddEnemy(Enemy enemy) {
        if (!enemies.Contains(enemy))
            enemies.Add(enemy);
    }

    public void RemoveEnemy(Enemy enemy) {
        if (enemies.Contains(enemy))
            enemies.Remove(enemy);
    }

    public float GetPlayerDistanceToClosestEnemy(float maxCheckDistance = Mathf.Infinity) {
        float distance = maxCheckDistance;
        Vector3 playerPosition = Player.instance.transform.position;
        foreach (var enemy in enemies) {
            if (enemy.currentFloor != Player.instance.currentFloor)
                continue;

            if (Vector3.Distance(enemy.transform.position, playerPosition) < distance) {
                NavMeshPath path = new NavMeshPath();
                enemy.GetComponent<NavMeshAgent>().CalculatePath(playerPosition, path);
                if (path.status != NavMeshPathStatus.PathInvalid) {
                    float length = 0;
                    for (int i = 1; i < path.corners.Length; ++i)
                        length += Vector3.Distance(path.corners[i - 1], path.corners[i]);
                    distance = Mathf.Min(distance, length);
                }
            }
        }
        return distance;
    }
}
