using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset; //permet de placer la caméra sur 3 axes pour l'éloigné un peut sinon elle se trouve pile sur la targets
    
    
    void FixedUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;// calcul vectoriel 
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); 
        /* Lerp est une Interpolation lineaire, il permet d'estimer la valeur prise par une fonction continue entre deux points déterminés.
        Elle consiste à utiliser pour cela la fonction affine (de la forme f(x) = m.x +b)*/
        
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }

}
