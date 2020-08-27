using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rocket : MonoBehaviour
{

    private InputMaster inputMaster;

    private Gravity gravity;

    public float thrustForce = 100;

    [SerializeField]
    private float rotateSpeed = 100;

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
    }

    private void FixedUpdate()
    {
        float rotateInput = inputMaster.Rocket.Rotate.ReadValue<float>();
        float thrustInput = inputMaster.Rocket.Thrust.ReadValue<float>();

        transform.eulerAngles += new Vector3(0, 0, rotateInput * rotateSpeed) * Time.fixedDeltaTime;


        if(thrustInput > 0)
        {
            
            Vector2 dir = transform.up;

            print(transform.forward);

            gravity.velocity += ((thrustForce * dir) / gravity.mass) * Time.fixedDeltaTime;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
