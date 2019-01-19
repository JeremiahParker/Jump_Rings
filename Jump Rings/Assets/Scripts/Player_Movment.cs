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
    //Checks if player is pressing m
    [SerializeField]
    [Header("Is pressing m?")]
    [Tooltip("If player is pressing m then the bool will return true")]
    public bool m_check;   
    #endregion
    #region FixedUpdateMethod

    //Code within will run every fixed frame
     void FixedUpdate(){
        RB.AddForce(0, 0, iHorizontal_Movment * Time.deltaTime);
        //Randomly rotates player
        transform.rotation = Random.rotation;
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
        }//If player is pressing m then the code withing will run
        if (Input.GetKey("m")){
            m_check = true;
            RB.AddForce(0, 0, iHorizontal_Movment * Time.deltaTime * 7);
            
            

            }//If it is not true that the player is pressing m the the code within will run
            else{

            m_check = false;

            }
        }
        
    }
    #endregion
    

