using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private float sensitivity = 3f;
    [SerializeField] private GameObject player;
    [SerializeField] private float MinY = -90f;
    [SerializeField] private float MaxY =90f;
    public Vector2 mouseDirection;

    // Update is called once per frame
    private void Update()
    {

        Vector2 mouseControl = new Vector2(
            Input.GetAxisRaw("Mouse X")*sensitivity,
            Input.GetAxisRaw("Mouse Y")*sensitivity
            );

    if (this.transform.rotation.eulerAngles.x<42f || this.transform.rotation.eulerAngles.x>350f){
        mouseDirection+=mouseControl;
    }
    else
    {
        //enlever sensivity ?
        mouseDirection.y-= mouseControl.y * sensitivity ;

        Quaternion quaternion = this.transform.localRotation= Quaternion.AngleAxis(mouseDirection.x, Vector3.up);

        transform.localRotation =quaternion*Quaternion.AngleAxis(-mouseDirection.y,Vector3.right);
        
    
    }
        

    }
    

        /*var horizontal = Input.GetAxis("Mouse X");
        var vertical = Input.GetAxis("Mouse Y");
        

        //transform.Rotate(horizontal * sensitivity * Vector3.up, Space.World);
        //transform.Rotate(vertical * sensitivity * Vector3.right, Space.World);
        transform.Rotate(-transform.up * horizontal * sensitivity);
        transform.Rotate(transform.right, -vertical * sensitivity); // again, use transform.Rotate(transform.right * rotateVertical * sensitivity) if you don't want the camera to rotate around the player
   */
   
    
}
    