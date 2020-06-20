using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float Speed;
    [SerializeField] private float MaxSpeed;

    private Inputs inputs;
    private Vector2 direction;
    public Rigidbody2D MyRigidbody;

    public Camera cam;
    public Vector2 mousePos;

    private void OnEnable()
    {
        inputs = new Inputs();
        inputs.Enable();
        inputs.Player.Move.performed += OnMovePerformed;
        inputs.Player.Move.canceled += OnMoveCanceled;
    }

    private void OnMovePerformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
       
    }

    private void OnMoveCanceled(InputAction.CallbackContext obj)
    {
        direction = Vector2.zero;
        MyRigidbody.velocity = Vector2.zero;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MyRigidbody = GetComponent<Rigidbody2D>();
        //MyRigidbody.MovePosition(direction);
        //MyRigidbody.velocity = direction;

        if (MyRigidbody.velocity.sqrMagnitude < MaxSpeed)
        {
            MyRigidbody.AddForce(direction * Speed);
        }


        Vector2 lookDir = mousePos - MyRigidbody.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        MyRigidbody.rotation = angle;
    }
}
