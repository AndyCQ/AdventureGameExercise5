using UnityEngine;

public class Aggro : MonoBehaviour
{
    public void Show() {
        gameObject.SetActive(true);
        Invoke("Hide", 1f);
    }

    void Hide() {
        Destroy(gameObject);
    }
}
