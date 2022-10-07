using UnityEngine;

public class MoreBombs : MonoBehaviour
{
    public PlayerCode player;
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && player.bombs < 3) {
            player.bombs += 1;
            Destroy(gameObject);
        }
    }
}
