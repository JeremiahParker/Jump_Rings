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
    //Checks if player is pressing a
    [SerializeField]
    [Header("Is pressing k?")]
    [Tooltip("If player is pressing k then the bool will return true")]
    public bool k_check;
    //Check if player is pressing h
    [SerializeField]
    [Header("Is pressing j?")]
    [Tooltip("If player is pressing j then the bool will return true")]
    public bool j_Check;
    //Checks if the player is pressing h
    [SerializeField]
    [Header("Is pressing h?")]
    [Tooltip("If player is pressing h then the bool will return true")]
    public bool h_check; 
    #endregion
    #region FixedUpdateMethod

    //Code within will run every fixed frame
     void FixedUpdate(){
        RB.AddForce(0, 0, iHorizontal_Movment * Time.deltaTime);
        //Randomly rotates player
        transform.rotation = Random.rotation;
        #region if Space logic
        //Checks if the player presses space, if this is so the code within will run
        if (Input.GetKey("space")){
            //Adds force to player based on the argument. Space_Check = true
            Space_Check = true;
            RB.AddForce(0, Vertical_Movment * Time.deltaTime, -Horizontal_Movment * Time.deltaTime);
        }
        else{
            //Adds force to player based on the argument. m_Check = true
            RB.AddForce(0, -4000 * Time.deltaTime, 0);
            Space_Check = false;
        }
        #endregion
        #region if k logic
        //If player is pressing k then the code withing will run
        if (Input.GetKey("k")){
            k_check = true;
            RB.AddForce(0, 0, iHorizontal_Movment * Time.deltaTime * 7);
            
            

            }//If it is not true that the player is pressing k the the code within will run
            else{

            k_check = false;

            }
        #endregion
        #region if j logic
        // If the player presses j the code within will run
        if (Input.GetKey("j")){

            RB.AddForce(0, Vertical_Movment * Time.deltaTime * .5f, 0);
            j_Check = true;

        }
        else{
            //if it is not true that the player is pressing j j_check will return false
            j_Check = false;

        }
        #region if h logic
        if (Input.GetKey("h")){
            h_check = true;
            RB.AddForce(0, 0, -Horizontal_Movment * Time.deltaTime * 3);

        }
        else{

            h_check = false;

        }

        #endregion
        #endregion
    }
    #endregion
}



