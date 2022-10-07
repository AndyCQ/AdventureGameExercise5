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
        //link.GetComponent<MeshRenderer>().enabled = true;
        //link.GetComponent<NavMeshObstacle>().enabled = true;
        //gameObject.GetComponent<Navmesh
    }

    public void bossDrop() {
        GameObject newCrown = Instantiate(crown,gameObject.transform.position,gameObject.transform.rotation);
        startBattle();
    }
}
