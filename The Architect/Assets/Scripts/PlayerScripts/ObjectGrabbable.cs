using StarterAssets;
using UnityEngine;

public class ObjectGrabbable : MonoBehaviour
{
    public GameObject player;

    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;
    private float rotationSensitivity = 5f;
    private bool canDrop = true;
    private bool grabbed = false;

    //Reference to script which includes mouse movement of player (looking around)
    //we want to disable the player looking around when rotating the object
    //example below 
    StarterAssetsInputs mouseLook;

    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        mouseLook = player.GetComponent<StarterAssetsInputs>();
    }

    private void Update()
    {
        if (grabbed)
        {
            RotateObject();
            
        }
    }

    public void Grab(Transform objectGrabPointTransform)
    {
        this.objectGrabPointTransform = objectGrabPointTransform;
        objectRigidbody.useGravity = false;
        objectRigidbody.freezeRotation = true;
        grabbed = true;
    }

    public void Drop()
    {
        if (canDrop) 
        {
            this.objectGrabPointTransform = null;
            objectRigidbody.useGravity = true;
            objectRigidbody.freezeRotation = false;
            grabbed = false;
        }
    }

    public void RotateObject()
    {
        
        if (Input.GetKey(KeyCode.R))//hold R key to rotate, change this to whatever key you want
        {
            objectRigidbody.freezeRotation = false;
            canDrop = false; //make sure throwing can't occur during rotating

            //disable player being able to look around
            mouseLook.LookInput(Vector2.zero); //disable mouse look

            float XaxisRotation = Input.GetAxis("Mouse X") * rotationSensitivity * Time.deltaTime;
            float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSensitivity * Time.deltaTime;

            transform.Rotate(Vector3.down, XaxisRotation);
            transform.Rotate(Vector3.right, YaxisRotation);
        }
        else {
            objectRigidbody.freezeRotation = true;
            canDrop = true;
        }
    }

    private void FixedUpdate()
    {
        if (objectGrabPointTransform != null)
        {
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrabPointTransform.position, Time.deltaTime * lerpSpeed);
            objectRigidbody.MovePosition(newPosition);
        }
    }
}
