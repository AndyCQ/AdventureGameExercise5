using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource BGM;

    private void Awake() {
        if(FindObjectsOfType<MusicManager>().Length > 1){
            Destroy(gameObject);
        }
        else{
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ChangeBGM(AudioClip music){
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }


}
