using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

public class Randomiser : EditorWindow
{
    bool randomX, randomY, randomZ;

    [MenuItem("MyTools/Randomiser")]
    //show window
    static void Init()
    {
        Randomiser window = (Randomiser)GetWindow(typeof(Randomiser));
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("Randomise the rotation of selection objects", EditorStyles.boldLabel);

        randomX = EditorGUILayout.Toggle("Randomise X", randomX);
        randomY = EditorGUILayout.Toggle("Randomise Y", randomY);
        randomZ = EditorGUILayout.Toggle("Randomise Z", randomZ);

        if(GUILayout.Button("Start Randomise"))
        {
            foreach(GameObject go in Selection.gameObjects)
            {
                go.transform.rotation = Quaternion.Euler(getRandom(go.transform.rotation.eulerAngles));
            }
        }

    }

    Vector3 getRandom(Vector3 inputRotation)
    {
        float x = randomX ? Random.Range(0f, 360f) : inputRotation.x;
        float y = randomY ? Random.Range(0f, 360f) : inputRotation.y;
        float z = randomZ ? Random.Range(0f, 360f) : inputRotation.z;

        return new Vector3(x, y, z);
    }



}
