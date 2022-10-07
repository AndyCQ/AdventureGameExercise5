using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCode : MonoBehaviour
{
    public GameObject player;
    public PlayerCode playerHP;
    public EnemyHealth enemyHP;
    public NavMeshAgent agent;
    public Transform target;
    public float lookRadius = 5f;
    public float damageAmt = 1f;
    public float hitCooldown = 1f;
    public float distance;

    void Update() {
        if (distance < lookRadius) {
            StartCoroutine(LookForPlayer());
        }
    }

    void FixedUpdate() {
        distance = Vector3.Distance(target.position,transform.position);
        if (hitCooldown > 0) {
            hitCooldown -= Time.deltaTime;
        }
    }

    IEnumerator LookForPlayer() {
        while(true) {
            yield return new WaitForSeconds(0.5f);
            agent.SetDestination(player.transform.position);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && hitCooldown <= 0) {
            hitCooldown = 1f;
            playerHP.playerDamage(damageAmt);
        }
        if (other.tag == "Sword") {
            enemyHP.takeDamage(1);
        }
    }
}
