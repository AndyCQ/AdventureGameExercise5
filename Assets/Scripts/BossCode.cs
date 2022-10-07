using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class BossCode : MonoBehaviour
{
    public GameObject player;
    public PlayerCode playerHP;
    public EnemyHealth enemyHP;
    public NavMeshAgent agent;
    public Transform target;
    public float lookRadius = 5f;
    public float damageAmt = 1f;
    public float hitCooldown = 1f;
    public float distance = 500f;
    public int spawnNum = 0;
    public int spawnLimit = 2;
    public GameObject slime;
    public GameObject big_slime;
    public float timer = 5f;

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
    public IEnumerator Spawner() {
        while(true) {
            yield return new WaitForSeconds(timer);
            GameObject s1 = Instantiate(slime,transform.position,transform.rotation);
            GameObject s2 = Instantiate(slime,transform.position,transform.rotation);
            s1.GetComponent<EnemyCode>().player = player;
            s1.GetComponent<EnemyCode>().playerHP = playerHP;
            s1.GetComponent<EnemyCode>().target = target;
            s1.GetComponent<EnemyHealth>().player = player;
            s2.GetComponent<EnemyCode>().player = player;
            s2.GetComponent<EnemyCode>().playerHP = playerHP;
            s2.GetComponent<EnemyCode>().target = target;
            s2.GetComponent<EnemyHealth>().player = player;
            for (int i = 0; i < spawnNum; i++) {
                GameObject s3 = Instantiate(slime,transform.position,transform.rotation);
                GameObject s4 = Instantiate(big_slime,transform.position,transform.rotation);
                s3.GetComponent<EnemyCode>().player = player;
                s3.GetComponent<EnemyCode>().playerHP = playerHP;
                s3.GetComponent<EnemyCode>().target = target;
                s3.GetComponent<EnemyHealth>().player = player;
                s4.GetComponent<EnemyCode>().player = player;
                s4.GetComponent<EnemyCode>().playerHP = playerHP;
                s4.GetComponent<EnemyCode>().target = target;
                s4.GetComponent<EnemyHealth>().player = player;
            }
            print("spawn");
            spawnNum += 1;
            if (spawnNum >= spawnLimit){
                spawnNum = 0;
            } 
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
