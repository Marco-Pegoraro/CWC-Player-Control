using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityInformations : MonoBehaviour
{
    // Here is the rule of the thumb you can follow when working with the const, readonly, and static keywords. 
    // Use the CONST keyword when the value contained in a variable will never change during the lifetime of the application. 
    // Use the READONLY keyword when you are not sure whether the value of a variable of an object needs to change but you want to prevent 
    // other classes from changing the value. 
    // Use the STATIC keyword when you want the member of a class to belong to the type rather than to the instance of the type.

    // Use PROTECTED keyword if you want to allow access from subclasses or classes within the same package.


    // Const keyword is used to define a variable whose value will not change during the lifetime of the program. 
    // Hence it is imperative that you assign a value to a constant variable at the time of its declaration.
    private const float speed = 20;

    // The readonly keyword can be used to define a variable or an object as readable only. 
    // This means that the variable or object can be assigned a value at the class scope or in a constructor only. 
    // You cannot change the value or reassign a value to a readonly variable or object in any other method except the constructor.
    private readonly float turnSpeed = 35;

    // The static keyword can be used on a variable, a method, or an object.
    // Static variables are accessed with the name of the class, not the name of an instance.
    private static float breakForce = 10;

    // Protected type or member can be accessed only by code in the same class , or in a class that is derived from that class.
    private protected int gameTime = 10;

    // [SerializeField] is used to make the private variables accessible within the Unity editor without making them public.
    [SerializeField] Vector3 offset = new Vector3(0, 7, -9);


    // AWAKE
    // Awake is called after all objects are initialized so you can safely speak to other objects or query them using GameObject.FindWithTag.
    // Each GameObject's Awake is called in a random order between objects. Because of this, you should use Awake to set up references
    // between scripts, and use Start() to pass any information back and forth. 
    // Awake is always called before any Start functions. 
    // This allows you to order initialization of scripts. 
    // Awake can not act as a coroutine.

    void Awake()
    {

    }

    // START 
    // Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
    // Like the Awake function, Start is called exactly once in the lifetime of the script. However, Awake is called when the script
    // object is initialised, regardless of whether or not the script is enabled. 
    // Start may not be called on the same frame as Awake if the script is not enabled at initialisation time.

    void Start()
    {
        
    }

    
    // EVENT FUNCTIONS
    // These functions are known as event functions since they are activated by Unity in response to events that occur during gameplay. 
    // Unity uses a naming scheme to identify which function to call for a particular event.

    // UPDATE
    // Update is called before the frame is rendered and also before animations are calculated.

    // FIXEDUPDATE
    // FixedUpdate is called just before each physics update. Since the physics updates and frame updates do not occur with the 
    // same frequency, you will  get more accurate results from physics code if you place it in the FixedUpdate function rather than Update.

    // LATEUPDATE
    // LateUpdate is called afeter functions have been called for all objects in the scene and after all animations have been calculated.

    void Update()
    {
        
    }

    void FixedUpdate()
    {

    }

    void LateUpdate()
    {

    }
}
