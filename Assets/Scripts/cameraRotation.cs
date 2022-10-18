using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    public GameObject player;
    movement player_movementScript;
    Quaternion angle;
    bool enableInvisible;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        player_movementScript = player.GetComponent<movement>();
        transform.rotation = Quaternion.Euler(0f, player_movementScript.accessableAngle, 0f);

       // player.transform.localScale = new Vector3(0, 0, 0);
       //transform.rotation = Quaternion.Euler(0f, angle, 0f);


    }
}
