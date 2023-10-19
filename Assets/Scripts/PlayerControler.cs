using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] Transform _transform;
    private Vector2 input;
    public float playerSpeed = 8.0f;
    private void OnMovement(InputValue value)
    {
        input = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        _transform.position += new Vector3(input.x / 100 * playerSpeed, input.y / 100 * playerSpeed);
    }

}
