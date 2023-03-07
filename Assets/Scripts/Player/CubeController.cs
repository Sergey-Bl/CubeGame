using System.Collections;
using UnityEngine;


public class CubeController : MonoBehaviour
{
    [SerializeField] private float _rollSpeed = 5f;
    private Vector3 _pivotPoint;
    private Vector3 _axis;
    private bool _isMoving;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()

    {
        if (_isMoving) return;

        if (Input.GetKey(KeyCode.W))
        {
            Move(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.back);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Move(Vector3.up);
        }
    }


    private void Move(Vector3 direction)
    {
        _pivotPoint = (direction / 2f) + (Vector3.down / 2) + transform.position;
        _axis = Vector3.Cross(Vector3.up, direction);

        StartCoroutine(Roll(_pivotPoint, _axis));
    }

    private IEnumerator Roll(Vector3 pivot, Vector3 axis)
    {
        _isMoving = true;
        _rigidbody.isKinematic = true;
        for (int i = 0; i < 90 / _rollSpeed; i++)
        {
            transform.RotateAround(pivot, axis, _rollSpeed);
            yield return new WaitForSeconds(0.01f);
        }


        _rigidbody.isKinematic = false;
        _isMoving = false;
    }
}