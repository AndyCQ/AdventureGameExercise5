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
        playerCharacter = player.transform;
        offSet = transform.position - playerCharacter.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerCharacter.position + offSet;
    }
    
}
