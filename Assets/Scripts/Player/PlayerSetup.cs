using UnityEngine;
using Mirror;

public class PlayerSetup : NetworkBehaviour
{
      [SerializeField]
    Behaviour[] componentsToDisable;

    Camera sceneCamera;
    private void Start()
    {
        //Verifie si l'object player est controler par un autre joueur 
        if (!isLocalPlayer)
        {
            // pour chaque composent dans componentsToDisable les désactive
            // cela permet de ne pas controler tout les joueur  et entendre tout les bruit ect
            for (int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
            }
        }
        else
        {
            sceneCamera = Camera.main;
            if(sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
            
        }

    }

    private void OnDisable()
    {
        if(sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }
    }
}
