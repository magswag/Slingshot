using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketUI : MonoBehaviour
{
    public Text timeWarpLevel;

    public Rocket rocket;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeWarpLevel.text = string.Format("{0}x", rocket.warpLevel);
    }
}
