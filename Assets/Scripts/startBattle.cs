using UnityEngine;
using UnityEngine.SceneManagement;

public class startBattle : MonoBehaviour
{
    public GameObject slime_king;
    public AudioClip newTrack;
    public MusicManager theMusic;


    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            slime_king.GetComponent<MobDrop>().startBattle();
            gameObject.GetComponent<BoxCollider>().enabled = false;
            if(newTrack != null){
                theMusic.ChangeBGM(newTrack);
            }
        }
    }
}
