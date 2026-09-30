using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    InputAction moveAction;
    Rigidbody2D myRigidbody2D;
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
       myRigidbody2D =  GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {

        // (x, y)
        // (0.2, 0.5)

        Vector2 moveVector;
        moveVector = moveAction.ReadValue<Vector2>();
        if (moveVector.x < 0)

        myRigidbody2D.AddTorque(torqueAmount);

        if (moveVector.x > 0)

            myRigidbody2D.AddTorque(-torqueAmount);
    }
}
