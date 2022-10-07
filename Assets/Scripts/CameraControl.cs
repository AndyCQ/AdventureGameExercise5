using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    Transform playerCharacter;
    Vector3 offSet;
    // Start is called before the first frame update
    void Start()
    {
        if(PublicVars.checkpoint == 0){
            gameObject.transform.position = new Vector3(-20.64f,9.07f,44.4f);
        }
        if(PublicVars.checkpoint == 1){
            gameObject.transform.position = new Vector3(-20.64f,9.07f,-63.3f);
        }
        if(PublicVars.checkpoint == 2){
            gameObject.transform.position = new Vector3(-20.64f,9.07f,-118.9f);
        }

        playerCharacter = player.transform;
        offSet = transform.position - playerCharacter.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerCharacter.position + offSet;
    }
    
}
