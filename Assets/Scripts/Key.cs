using UnityEngine;

public class Key : MonoBehaviour
{
<<<<<<< Updated upstream
    public Door count;
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
           Destroy(gameObject);
           count.keyCount += 1;
=======
    public Door count = null;
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
           Destroy(gameObject);
           if(count != null){
            count.keyCount += 1;
           }
>>>>>>> Stashed changes
        }
    }
}
