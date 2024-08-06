using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private CharacterController controller;

    public float walkSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movement.Normalize();

        Vector3 velocity = (transform.forward * movement.y + transform.right * movement.x) * walkSpeed;
        controller.Move(velocity * Time.deltaTime);
        rb.freezeRotation = true;
    }
}


//Simple times calls for simple movement!
