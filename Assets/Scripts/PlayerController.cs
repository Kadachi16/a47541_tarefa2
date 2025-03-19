using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0.0f;
        if (Keyboard.current.leftArrowKey.isPressed)
        {

            horizontal = -1.0f;

        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {

            horizontal = 1.0f;

        }

        Debug.Log(horizontal);

        Vector2 position = transform.position;
        pposition.x = position.x + 0.1f * horizontal;
        transform.position = position;

    }
}
