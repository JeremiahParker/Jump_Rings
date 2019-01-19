using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    #region Variables
    //Mention to a rigidbody; is SerializeFeild
    [SerializeField]
    [Header("Rigidbody mention")]
    [Tooltip("Name(RB) access(private serializeFeild) Type(Rigidbody)")]
    private Rigidbody RB;
    //Force applyed to the bottom of the player when the space bar is pressed
    [SerializeField]
    [Header("Vertical speed")]
    [Tooltip("Force applyed to the negitive x axis when space bar is pressed")]
    [Range(0f, 10000f)]
    public float Vertical_Movment;
    //Force applyed to the right of the player when the space bar is pressed
    [SerializeField]
    [Header("Horizontal speed")]
    [Tooltip("Force applyed to the positive y axis when space bar is pressed")]
    [Range(0f, 10000f)]
    public float Horizontal_Movment;
    //Force applyed to the left of the player
    [SerializeField]
    [Header("-Horizontal speed")]
    [Tooltip("Force applyed to the - of Horizontal_Movment")]
    [Range(0f, 10000f)]
    public float iHorizontal_Movment;
    //Checks if the player is pressing space
    [Header("Is pressing space bar?")]
    [Tooltip("Will return true if the player presses space")]
    public bool Space_Check;
        

    #endregion
    #region FixedUpdateMethod

    //Code within will run every fixed frame
     void FixedUpdate(){
        RB.AddForce(0, 0, iHorizontal_Movment * Time.deltaTime);
        //Randomly rotates player
        transform.rotation = Random.rotation;
        //Checks if the player presses space, if this is so the code within will run
        if (Input.GetKey("space")){

            Space_Check = true;
            RB.AddForce(0, Vertical_Movment * Time.deltaTime, -Horizontal_Movment * Time.deltaTime);
        }
        else
        {

            RB.AddForce(0, -4000 * Time.deltaTime, 0);
            Space_Check = false;
        }

        }
        
    }
    #endregion
    

