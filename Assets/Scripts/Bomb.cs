using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float countdown = 3f;
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
        //(OPTIONAL) Add forces
        //Damage

        //Remove grenade
        Destroy(gameObject);
    }
}
