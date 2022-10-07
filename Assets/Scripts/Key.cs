using UnityEngine;

public class Key : MonoBehaviour
{

    public Door count;
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
           Destroy(gameObject);
           count.keyCount += 1;

        }
    }
}
