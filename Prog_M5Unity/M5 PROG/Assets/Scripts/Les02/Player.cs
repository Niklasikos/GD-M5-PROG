using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    private InputSystem_Actions inputActions;
    private Vector2 moveDirection;
    [SerializeField] private float speed = 5f;

    void Awake()
    {
        inputActions = new InputSystem_Actions();
    }

    void OnEnable()
    {
        inputActions.Les02.Enable();
    }

    void OnDisable()
    {
        inputActions.Les02.Disable();
    }
    void Update()
    {
        moveDirection = inputActions.Les02.Cube.ReadValue<Vector2>();
        Vector3 move = new Vector3(moveDirection.x, 0, moveDirection.y);
        transform.Translate(move * (Time.deltaTime * speed));
    }
}
