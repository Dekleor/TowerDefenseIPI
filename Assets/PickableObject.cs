using UnityEngine;
using System.Collections;

public class PickableObject : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;
    public float throwForce = 10;

    private bool hasPlayer = false;
    private bool beingCarried = false;
    private bool touched = false;

    void Update()
    {
        // check distance entre objet et joueur
        float dist = Vector3.Distance(gameObject.transform.position, player.position);

        // si - ou = 1.9 unitÃ©s de distance = on peut ramasser
        if (dist <= 50f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }

        // si on peut ramasser et qu'on appuie sur E = on porte l'objet
        if (hasPlayer && Input.GetMouseButtonDown(0))
        {
            GetComponent< Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }

        // Si on porte l'objet
        if (beingCarried)
        {
            // si l'objet touche un mur / objet avec collider
            if (touched)
            {
                GetComponent< Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }

            
            // clique droit on pose l'objet
            else if (Input.GetMouseButtonDown(1))
            {
                GetComponent< Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
        }
    }
}