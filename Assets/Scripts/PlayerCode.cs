using UnityEngine;
using UnityEngine.AI;

public class PlayerCode : MonoBehaviour
{
    public GameObject sword;
    public NavMeshAgent agent;
    public float swordSpeed = 100;
    Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;
    }
    void Update() 
    {
        if(Input.GetMouseButton(1)){   
            RaycastHit hit;
            if(Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200)) {
                //casts a ray of 200 units starting from mouse (relative to camera), returns if it hits something
                agent.SetDestination(hit.point);
            }
        }
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            if(Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200)) {
                transform.LookAt(hit.point);
                GameObject newSword = Instantiate(sword,transform.position,transform.rotation);
                newSword.GetComponent<Rigidbody>().AddForce(transform.forward * swordSpeed);
            }
        }
    }
}
