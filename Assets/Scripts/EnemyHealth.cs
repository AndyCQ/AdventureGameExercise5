using UnityEngine;

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
            print(player.GetComponent<PlayerCode>().health);
            player.GetComponent<PlayerCode>().health += 1;
            print(player.GetComponent<PlayerCode>().health);
            Destroy(gameObject);
        }
    }
}
