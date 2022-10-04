using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCode : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent agent;

    void Start() {
        StartCoroutine(LookForPlayer());
    }

    IEnumerator LookForPlayer() {
        while(true) {
            yield return new WaitForSeconds(0.5f);
            agent.SetDestination(player.transform.position);
        }
    }
}
