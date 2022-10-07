using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobDrop : MonoBehaviour
{
    // Start is called before the first frame update
    public Door link;
    public GameObject key;
    public GameObject crown;
    
    public void specialDrop() {
        GameObject newKey = Instantiate(key,gameObject.transform.position,gameObject.transform.rotation);
        newKey.GetComponent<Key>().count = link;
    }

    public void startBattle() {
        link.GetComponent<MeshRenderer>().enabled = true;
        link.GetComponent<UnityEngine.AI.NavMeshObstacle>().enabled = true;
    }

    public void bossDrop() {
        GameObject newCrown = Instantiate(crown,gameObject.transform.position,gameObject.transform.rotation);
        newCrown.transform.position = new Vector3(newCrown.transform.position.x, newCrown.transform.position.y-1.5f, newCrown.transform.position.z);
    }
}
