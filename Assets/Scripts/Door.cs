using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{   
    public GameObject[] keys;
    public int keyCount;

    public bool flag = false;
    public int point = 0;

    void Start() {
        keyCount = 0;
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && keyCount == keys.Length) {
            Destroy(gameObject);
            PublicVars.keysAvailable -=1;
        }
        if(flag){
            PublicVars.checkpoint = point;
        }
    }
}
