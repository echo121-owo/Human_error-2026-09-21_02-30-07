using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Player_input player_input;
    private Player_input.Player_moveActions move;
    private CharacterController controller;

    public float speed = 5f;

    void Awake()
    {
        player_input = new Player_input();
        move = player_input.Player_move;

        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector2 input = move.move.ReadValue<Vector2>();

        Vector3 direction = new Vector3(input.x, 0, input.y);

        controller.Move(direction * speed * Time.deltaTime);
    }

    void OnEnable()
    {
        move.Enable();
    }

    void OnDisable()
    {
        move.Disable();
    }
}