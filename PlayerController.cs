using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float MSpeed = 10f, JForce=5f;

    private Rigidbody rb;

    private Vector2 moveInput;

    private bool isGronded;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movimiento = new Vector3(moveInput.x, 0, moveInput.y) * MSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movimiento);
        isGronded = Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }
    public void Move(InputAction.CallbackContext callbackContext)
    {
        moveInput=callbackContext.ReadValue<Vector2>();
    }
    public void Jump(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.performed && isGronded)
        {
            rb.AddForce(Vector3.up * JForce, ForceMode.Impulse);
        }
    }
}
