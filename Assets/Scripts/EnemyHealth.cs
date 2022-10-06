using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 3f;
    public float currentHealth;

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
            Destroy(gameObject);
        }
    }
}
