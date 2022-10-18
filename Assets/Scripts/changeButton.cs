using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class changeButton : MonoBehaviour
{

    public List<Camera> Cameras;
    public GameObject player;
    private VisualElement frame;
    private Button button;


    private void OnEnable()
    {
        var uiDoc = GetComponent<UIDocument>();
        var rootVisualElement = uiDoc.rootVisualElement;
        frame = rootVisualElement.Q<VisualElement>("Frame");

        button = frame.Q<Button>("Button");
        button.RegisterCallback<ClickEvent>(ev => ChangeCamera());

    }
    int click = 0;
    void ChangeCamera()
    {
        click++;

        if(click == 1)
        {
            //hide player when trigger first player mode
            player.transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            //unhide player
            player.transform.localScale = new Vector3(20, 20, 20);
        }
        EnableCamera(click);


        if(click > 2)
        {
            click = -1;
        }
    }

    void EnableCamera(int n)
    {
        Cameras.ForEach(cam => cam.enabled = false);
        Cameras[n].enabled = true;
    }
}
