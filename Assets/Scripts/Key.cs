using UnityEngine;
using TMPro;

public class Key : MonoBehaviour
{
    public Door count = None;
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
           Destroy(gameObject);

           if(count != None){
            count.keyCount += 1;
           }
        }
    }
}
