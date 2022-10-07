using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 3f;
    public float currentHealth;
    public GameObject player;
    
    

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void takeDamage(float damage){
        currentHealth -= damage;
    }
    
    void FixedUpdate()
    {
        if (currentHealth <= 0f) {
            Debug.Log("Dies from cringe");
            if(gameObject.tag == "Special"){
                gameObject.GetComponent<MobDrop>().specialDrop();
            }
            if(gameObject.tag == "Boss"){
                gameObject.GetComponent<MobDrop>().bossDrop();
            }
            player.GetComponent<PlayerCode>().health += 1;
            player.GetComponent<PlayerCode>().healthBar.UpdateHealthBar();
            Destroy(gameObject);
        }
    }
}
