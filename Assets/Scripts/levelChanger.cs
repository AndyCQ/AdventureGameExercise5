using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChanger : MonoBehaviour
{
    public string name = "EndScreen";
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            SceneManager.LoadScene(name);
        }
    }
}
