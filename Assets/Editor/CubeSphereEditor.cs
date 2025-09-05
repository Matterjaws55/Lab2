using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CubeSphere))]
public class CubeSphereEditor : Editor
{
    private bool cubeButtonPressed = false;
    private bool sphereButtonPressed = false;
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        CubeSphere cubeSphere = (CubeSphere)target;

        if(cubeSphere.size >= 1.999999999999f) 
            EditorGUILayout.HelpBox("Objects can not be larger than 1.999999999999", MessageType.Warning);

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Select all cubes"))
        {
            cubeSphere.SelectCubes();
        }
        if (GUILayout.Button("Select all spheres"))
        {
            cubeSphere.SelectSpheres();
        }
        GUILayout.EndHorizontal();

        if (GUILayout.Button("Clear selection"))
        {
            cubeSphere.ClearSelection();
        }

        GUILayout.BeginHorizontal();
        GUI.backgroundColor = cubeButtonPressed ? new Color(0.5f, 0f, 0.5f) : Color.blue;
        if (GUILayout.Button("Disable/Enable cubes"))
        {
            cubeButtonPressed = !cubeButtonPressed;
            cubeSphere.EnableDisableCubes();
        }

        GUI.backgroundColor = sphereButtonPressed ? new Color(0.5f, 0f, 0.5f) : Color.blue;
        if (GUILayout.Button("Disable/Enable spheres"))
        {
            sphereButtonPressed = !sphereButtonPressed;
            cubeSphere.EnableDisableSpheres();
        }
        GUILayout.EndHorizontal();
    }
}
