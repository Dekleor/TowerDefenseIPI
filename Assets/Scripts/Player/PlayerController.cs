using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Appel du script Player motor
    private PlayerMotor motor;

    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float mouseSensivity = 3f;
    [SerializeField] private float _jumpSpeed = 0.5f;
    [SerializeField] private float _gravity = 2f;

    CharacterController _characterController;
    Vector3 _moveDirection;    

// Start est appelé au lancement de l'application
 void Start()
{
        motor = GetComponent<PlayerMotor>();
}


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
    void Update()
    {
        //Input.GetAxis("") Renvoie la valeur de l'axe virtuel identifié par axisName. La valeur sera comprise entre -1 et 1 pour les périphériques d'entrée clavier et joystick.
        // Pour configurer votre entrée ou afficher les options de axisName, accédez à Edit > Project Settings > Input Manager.
        // Toutes les entrée sont en double. Le premier est utiliser pour clavier-souris et le seconds pour manette
        float xMov  = Input.GetAxis("Horizontal");
        float zMov  = Input.GetAxis("Vertical");


        Vector3 moveHorizontal = transform.right * xMov;
        Vector3 moveVertical = transform.forward * zMov;

        Vector3 velocity = ( moveVertical + moveHorizontal).normalized * _moveSpeed;

        motor.Move(velocity);
        float yRot = Input.GetAxis("Mouse X");

        Vector3 rotation = new Vector3( 0, yRot , 0)* mouseSensivity;

        motor.Rotate(rotation);

        float xRot = Input.GetAxis("Mouse Y");

        float cameraRotationX = xRot * mouseSensivity;

        motor.RotateCamera(cameraRotationX);

        /*
         Vector3 inputDirection = new Vector3(xMov, 0, zMov);
         Vector3 transformDirection = transform.TransformDirection(inputDirection);
        */
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
