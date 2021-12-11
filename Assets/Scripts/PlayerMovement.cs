using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float _jumpSpeed = 0.5f;
    [SerializeField] private float _gravity = 2f;

    CharacterController _characterController;
    Vector3 _moveDirection;


/*  
*   Awake est appelé soit lorsqu'un GameObject actif qui contient le script est initialisé lors du chargement 
*   d'une scène, soit lorsqu'un GameObject précédemment inactif est défini sur actif, ou après l'initialisation 
*   d'un GameObject créé avec Object.Instantiate .
*   Utilisez Awake pour initialiser des variables ou des états avant le démarrage de l'application.
*/
    void Awake() =>_characterController = GetComponent<CharacterController>();
    
/*
*   MonoBehaviour.FixedUpdate has the frequency of the physics system; it is called every fixed frame-rate frame.
*   Compute Physics system calculations after FixedUpdate. 0.02 seconds (50 calls per second) is the default time between calls.
*   The FixedUpdate frequency is more or less than Update. If the application runs at 25 frames per second (fps), Unity calls it approximately twice per frame.
*   Use FixedUpdate when using Rigidbody. Set a force to a Rigidbody and it applies each fixed frame. 
*   FixedUpdate occurs at a measured time step that typically does not coincide with MonoBehaviour.Update.
*/  
    void FixedUpdate()
    {
        //Input.GetAxis("") Renvoie la valeur de l'axe virtuel identifié par axisName. La valeur sera comprise entre -1 et 1 pour les périphériques d'entrée clavier et joystick.
        // Pour configurer votre entrée ou afficher les options de axisName, accédez à Edit > Project Settings > Input Manager.
        // Toutes les entrée sont en double. Le premier est utiliser pour clavier-souris et le seconds pour manette
        float horizontal  = Input.GetAxis("Horizontal");
        float vertical  = Input.GetAxis("Vertical");

        Vector3 inputDirection = new Vector3(horizontal, 0, vertical);
        Vector3 transformDirection = transform.TransformDirection(inputDirection);

        // Calcul du déplacement ( vitesse * temps en seconde depuis la derniere frame * direction )
        Vector3 flatMovement = _moveSpeed * Time.deltaTime * transformDirection;

        _moveDirection = new Vector3(flatMovement.x, _moveDirection.y, flatMovement.z);
        if (PlayerJumped())
            _moveDirection.y  =_jumpSpeed;
        else if (_characterController.isGrounded)
            _moveDirection.y = 0f;
        else
            _moveDirection.y -= _gravity*Time.deltaTime;
        _characterController.Move(_moveDirection);
    }
    private bool PlayerJumped(){
        bool jumpKeyDown;
        if (Input.GetAxis("Jump") != 0){
            jumpKeyDown =true;
        }else{
            jumpKeyDown=false;
        }
        return _characterController.isGrounded && jumpKeyDown;
    } 
}
