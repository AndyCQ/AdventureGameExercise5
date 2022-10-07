using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{   
    public GameObject[] keys;
    public int keyCount;

    void Start() {
        keyCount = 0;
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && keyCount == keys.Length) {
            Destroy(gameObject);
        }
    }
}
