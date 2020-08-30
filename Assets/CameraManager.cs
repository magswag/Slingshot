using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public Rocket target;

    private Rigidbody2D rb;

    public float cameraSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = target.GetComponent<Rigidbody2D>();
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10);
        Vector2 a = (target.closestCelestialBody.transform.position - target.transform.position).normalized;
        float dir = Mathf.Atan2(a.y, a.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, dir + 90);
    }
}
