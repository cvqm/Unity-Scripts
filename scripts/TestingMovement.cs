using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Movement : MonoBehaviour
{
    private Vector3 velocity;
    private CharacterController controller;

    public float walkSpeed = 5.0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        if (controller != true)
            controller.AddComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movement.Normalize();

        Vector3 velocity = (transform.forward * movement.y + transform.right * movement.x) * walkSpeed;
        velocity = movement * walkSpeed;

        controller.Move(velocity * Time.deltaTime);
    }
}


//Simple times calls for simple movement!
