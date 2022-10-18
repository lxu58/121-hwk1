using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationalCamera : MonoBehaviour
{
    public GameObject targetObj;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(targetObj.transform.position, Vector3.up, 5 * Time.deltaTime);
    }
}
