using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float _mouseSensitivity = 3.0f;
    private float _rotationY;
    private float _rotationX;
    public float mouseX;
    public float mouseY;
    private Vector2 _rotationXMinMax = new Vector2(-40, 40);
    public Transform _target;
    private float _distanceFromTarget = 10.0f;
    private Vector3 _currentRotation;
    private Vector3 _smoothVelocity = Vector3.zero;
    private float _smoothTime = 0.2f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
            mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity;
            _rotationY += mouseX;
            _rotationX += mouseY;
            _rotationX = Mathf.Clamp(_rotationX, _rotationXMinMax.x, _rotationXMinMax.y);
            Vector3 nextRotation = new Vector3(_rotationX, _rotationY);
            transform.position = _target.position - transform.forward * _distanceFromTarget;
            _currentRotation = Vector3.SmoothDamp(_currentRotation, nextRotation, ref _smoothVelocity, _smoothTime);
            transform.localEulerAngles = _currentRotation;
        } 
    }
}
