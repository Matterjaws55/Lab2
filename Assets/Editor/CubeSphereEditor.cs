using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(CubeSphere))]
public class CubeSphereEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        CubeSphere cubeSphere = (CubeSphere)target;
        if(GUILayout.Button("Hide Cube"))
        {
            cubeSphere.HideCube();
        }
    }
}
