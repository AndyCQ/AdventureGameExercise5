using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerCode : MonoBehaviour
{
    public GameObject sword;
    public GameObject bomb;
    public NavMeshAgent agent;
    public float swordSpeed = 100;
    public float bombSpeed = 100;
    public float bombs = 3;
    Camera mainCam;
    
    //HealthBar Vars
    public float health = 10;
    public float maxHealth = 10;
    public HP healthBar;
    public static Collider enemy;
    //float delay = 2f;
    //float time = 0f;

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
            
            //sword slash since regular sword system doesn't work
        }
        if(Input.GetKeyDown("space") & bombs > 0) {
            bombs -= 1;
            RaycastHit hit;
            if(Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200)) {
                transform.LookAt(hit.point);
                GameObject newBomb = Instantiate(bomb,transform.position,transform.rotation);
                newBomb.GetComponent<Rigidbody>().AddForce(transform.forward * bombSpeed);
            }
        }
    }

    public void playerDamage(float amount) {
        health -= amount;
        healthBar.UpdateHealthBar();
        Debug.Log("Hit");
    }
    /*
    void takeDamage(Collider enemy){
        if (enemy.CompareTag("Enemy")){
                print("hit");
                health -= 5;
                healthBar.UpdateHealthBar();
                if (health <= 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
                }
    }
    */
}
