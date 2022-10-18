using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCamera : MonoBehaviour
{
    public List<Camera> Cameras;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //enable default camera
        EnableCamera(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EnableCamera(0);
            player.transform.localScale = new Vector3(20, 20, 20);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EnableCamera(1);
            player.transform.localScale = new Vector3(0, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EnableCamera(2);
            player.transform.localScale = new Vector3(20, 20, 20);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            EnableCamera(3);
            player.transform.localScale = new Vector3(20, 20, 20);
        }

    }

    void EnableCamera(int n)
    {
        Cameras.ForEach(cam => cam.enabled = false);
        Cameras[n].enabled = true;
    }
}
