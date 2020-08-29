using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rocket : MonoBehaviour
{

    private InputMaster inputMaster;
    private Gravity gravity;
    private ParticleSystem exhaustSystem;
    public float thrustForce = 100;
    private Camera camera;

    [SerializeField]
    private float rotateSpeed = 100;

    [SerializeField]
    private float cameraZoomSensitivity = 10f;

    public Gravity closest;

    public int warpLevel = 1;

    private void Awake()
    {
        inputMaster = new InputMaster();
    }

    private void OnEnable()
    {
        inputMaster.Enable();
    }

    private void OnDisable()
    {
        inputMaster.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        gravity = GetComponent<Gravity>();
        exhaustSystem = GetComponent<ParticleSystem>();
        camera = transform.GetChild(0).gameObject.GetComponent<Camera>();

        SetWarpLevel(warpLevel);
    }

    Gravity GetClosestCelestialBody()
    {
        List<Gravity> bodies = new List<Gravity>(FindObjectsOfType<Gravity>());
        bodies.Remove(gravity);
        bodies.Sort(delegate (Gravity a, Gravity b)
        {
            return Vector2.Distance(this.transform.position, a.transform.position)
            .CompareTo(
              Vector2.Distance(this.transform.position, b.transform.position));
        });

        return bodies[0];
    }

    private void FixedUpdate()
    {
        float rotateInput = inputMaster.Rocket.Rotate.ReadValue<float>();
        float thrustInput = inputMaster.Rocket.Thrust.ReadValue<float>();

        //gravity.rigidbody.MoveRotation( rotateInput * rotateSpeed * Time.fixedDeltaTime);
        //transform.eulerAngles += new Vector3(0, 0, rotateInput * rotateSpeed) * Time.fixedDeltaTime;

        if(rotateInput != 0)
        {
            gravity.rigidbody.AddTorque(rotateInput * rotateSpeed);
        }

        if(thrustInput > 0)
        {
            Vector2 dir = transform.up;

            //gravity.velocity += ((thrustForce * dir) / gravity.mass) * Time.fixedDeltaTime;
            gravity.rigidbody.AddForce((thrustForce * dir));
        }

        var em = exhaustSystem.emission;

        em.rateOverDistanceMultiplier = thrustInput;
    }

    private void LateUpdate()
    {
   
        
        //transform.position = Vector3.Lerp(transform.position, new Vector3(target.transform.position.x, target.transform.position.y, -10), cameraSpeed * Time.deltaTime);
        Vector2 a = (closest.transform.position - gravity.transform.position).normalized;
        float dir = Mathf.Atan2(a.y, a.x) * Mathf.Rad2Deg;
        camera.transform.eulerAngles = new Vector3(0, 0, dir + 90);
        //transform.rotation = target.transform.rotation;

        //camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, camera.orthographicSize - inputMaster.Camera.Zoom.ReadValue<float>() * cameraZoomSensitivity, 0.1f * Time.deltaTime);

        camera.orthographicSize = Mathf.Clamp(camera.orthographicSize - (camera.orthographicSize * cameraZoomSensitivity) * inputMaster.Camera.Zoom.ReadValue<float>() * Time.deltaTime, 5, 2500);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(gravity.rigidbody.velocity.sqrMagnitude);
        if (gravity.rigidbody.velocity.sqrMagnitude > 0.5f)
        {
            print("dead");
        }
    }

    // Update is called once per frame
    void Update()
    {
        closest = GetClosestCelestialBody();

        if(inputMaster.Global.IncreaseTimeWarp.triggered)
        {
            SetWarpLevel(warpLevel + 1);
        }
        if (inputMaster.Global.DecreaseTimeWarp.triggered)
        {
            SetWarpLevel(warpLevel - 1);
        }
    }

    void SetWarpLevel(int level)
    {
        warpLevel = Mathf.Clamp(level, 1, 8);
        Time.timeScale = warpLevel;
    }
}
