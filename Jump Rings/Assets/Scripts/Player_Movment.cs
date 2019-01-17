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
    //Force applyed to the right of the player when the space bar is pressed
    [Header("Vertical speed")]
    [Tooltip("Force applyed to the negitive x axis when space bar is pressed")]
    [Range(0f, 1000f)]
    public float Vertical_Movment;
    //Force applyed to the bottom of the player when the space bar is pressed
    [Header("Horizontal speed")]
    [Tooltip("Force applyed to the positive y axis when space bar is pressed")]
    [Range(0f, 1000f)]
    public float Horizontal_Movment;
    #endregion
    #region UpdateMethod

    //Code within will run every fixed frame
     void FixedUpdate(){

        if (Input.GetKey("space")){

            RB.AddForce(-Horizontal_Movment * Time.deltaTime, Vertical_Movment * Time.deltaTime, 0);

        }

    }
    #endregion
}
