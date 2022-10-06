using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCode : MonoBehaviour
{
    public NavMeshAgent agent;
    Camera mainCam;
    
    public bool triggered = false;
    //HealthBar Vars
    public float health = 100;
    public float maxHealth = 100;
    public HP healthBar;
    int hp_hit_count = 0;

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
    }

    private void OnTriggerEnter(Collider other)
    {
        switch(other.tag)
        {
            case "TestEnemy":
                hp_hit_count += 1;
                print(hp_hit_count);
                print("hit");
                health -= 25;
                healthBar.UpdateHealthBar();

                if (hp_hit_count == 4)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
                break;
            default:
                break;
        }
    }
}
