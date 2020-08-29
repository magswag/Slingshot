using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundStars : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position * speed;
    }
}
