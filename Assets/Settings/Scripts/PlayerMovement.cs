using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    InputAction moveAction;
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

   
    void Update()
    {

        // (x, y)
        // (0.2, 0.5)

        Vector2 moveVector;
        moveVector = moveAction.ReadValue<Vector2>();
        print(moveVector);
        Debug.Log(moveVector);
    }
}
