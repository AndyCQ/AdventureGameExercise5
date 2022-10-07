using UnityEngine;

// Explosion Source: GRENADE / BOMB in Unity (Tutorial) - Brackeys
// 2017, November 1st, https://www.youtube.com/watch?v=BYL6JtUdEY0

public class Bomb : MonoBehaviour
{
    public float countdown = 3f;
    public float blastRadius = 5f;
    public float force = 1000f;

    public GameObject explosionEffect;
    bool exploded = false;

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !exploded) 
        {
            Explode();
            exploded = true;
        }
    }

    void Explode()
    {
        //Show effect
        Instantiate(explosionEffect, transform.position, transform.rotation);
        //Find nearby object
        Collider[] colliders = Physics.OverlapSphere(transform.position, blastRadius);

        foreach (Collider nearby in colliders) {
            if (nearby.tag == "Breakable") {
                Destroy(nearby.gameObject);
            }
            if (nearby.tag == "Enemy") {
                //Add forces
                /*
                Rigidbody rb = nearby.GetComponent<Rigidbody>();
                if (rb != null) {
                    rb.AddExplosionForce(force, transform.position, blastRadius);
                }
                */
                //Damage
                EnemyHealth enemies = nearby.GetComponent<EnemyHealth>();
                enemies.takeDamage(3f);
            }
        }

        //Remove grenade
        Destroy(gameObject);
    }
}
