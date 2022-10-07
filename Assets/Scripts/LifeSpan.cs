using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour
{
    public float lifeTime = 0.2f;

    void Start()
    {
        Destroy(gameObject,lifeTime);
    }
}
