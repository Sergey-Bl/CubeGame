using System;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(CubeController))]
    public class PlayerInput : MonoBehaviour
    {
        private CubeController _cubeController;
        private void Start()
        {
            _cubeController = GetComponent<CubeController>();
        }

        private void Update()
        {
            ProcessInput();
        }

        private void ProcessInput()
        {
            if (Input.GetKey(KeyCode.W))
            {
                _cubeController.Move(Vector3.left);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                _cubeController.Move(Vector3.right);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                _cubeController.Move(Vector3.forward);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                _cubeController.Move(Vector3.back);
            }
            // else if (Input.GetKey(KeyCode.Space))
            // {
            //     _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //     // Move(Vector3.up);
        }
    }
}