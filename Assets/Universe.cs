using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universe : MonoBehaviour
{
    [Tooltip("Gravitational constant.")]
    [SerializeField]
    private float G = 1;

    private Gravity[] celestialBodies;

    // Start is called before the first frame update
    void Start()
    {
        celestialBodies = FindObjectsOfType<Gravity>();
    }

    private void FixedUpdate()
    {
        foreach(Gravity body in celestialBodies)
        {
            if(!body.isStatic)
            {
                foreach(Gravity otherBody in celestialBodies)
                {
                    if(body != otherBody)
                    {
                        Vector2[] debugPoints;

                        float distanceSquared = Mathf.Pow(Vector3.Distance(otherBody.transform.position, body.transform.position), 2);
                        //float distanceSquared = Mathf.Pow(Vector3.Distance(otherBody.rigidbody.worldCenterOfMass, body.rigidbody.worldCenterOfMass), 2);
                        float force = G * ((body.mass * otherBody.mass) / distanceSquared);

                        Vector3 direction = Vector3.Normalize(otherBody.transform.position - body.transform.position);
                        //Vector3 direction = Vector3.Normalize(otherBody.rigidbody.worldCenterOfMass - body.rigidbody.worldCenterOfMass);
                        Vector2 acceleration = (force * direction) / body.mass;

                        body.velocity += acceleration * Time.fixedDeltaTime;

                        //body.rigidbody.MovePosition(body.transform.position + new Vector3(body.velocity.x, body.velocity.y, 0) * Time.fixedDeltaTime);
                        body.rigidbody.AddForce(force * direction);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
