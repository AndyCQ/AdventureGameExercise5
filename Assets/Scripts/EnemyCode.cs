using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCode : MonoBehaviour
{
    public GameObject player;
    public PlayerCode playerHP;
    public EnemyHealth enemyHP;
    public NavMeshAgent agent;
    public float damageAmt = 1f;
    public float hitCooldown = 1f;

    void Start() {
        StartCoroutine(LookForPlayer());
    }

    void FixedUpdate() {
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
