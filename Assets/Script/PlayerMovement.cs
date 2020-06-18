using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{

    private Inputs inputs;

    private void OnEnable()
    {
        inputs = new Inputs();
        inputs.Enable();
        inputs.Player.Move.performed += OnMovePerformed;
    }

    private void OnMovePerformed(InputAction.CallbackContext obj)
    {
        Debug.Log("coucou");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
