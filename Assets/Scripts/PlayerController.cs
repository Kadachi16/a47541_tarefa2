using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        MoveAction.Enable();
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()

    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * 0.1f;
        transform.position = position;
    }
}
