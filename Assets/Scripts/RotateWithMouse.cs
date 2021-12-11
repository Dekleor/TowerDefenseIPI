using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private float _turnSpeed = 3f;
    // Update is called once per frame
    private void Update()
    {
        var horizontal = Input.GetAxis("Mouse X");
        transform.Rotate(horizontal * _turnSpeed * Vector3.up, Space.World);
    }
}
