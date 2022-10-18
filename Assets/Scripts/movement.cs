using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public CharacterController controller;
    public float speed;
    float Angle;
    float smoothAngle;
    public float accessableAngle;
    float turnSmooth_time = 0.1f;
    float turnSmooth_velocity;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            Angle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + 90;
            smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, Angle, ref turnSmooth_velocity, turnSmooth_time);
            transform.rotation = Quaternion.Euler(0f, smoothAngle, 0f);
            accessableAngle = smoothAngle - 90;

          //  Vector3 moveDir = Quaternion.Euler(0f, Angle, 0f) * Vector3.forward;
            controller.Move(direction * speed * Time.deltaTime);
        }


    }
}
