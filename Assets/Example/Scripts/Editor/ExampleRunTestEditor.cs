using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ExampleRunTest),true)]
public class ExampleRunTestEditor : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorGUILayout.Space();
        ExampleRunTest runTest = target as ExampleRunTest;
        EditorGUILayout.BeginHorizontal();
        if (runTest != null)
        {
            if (GUILayout.Button("Play"))
            {
                runTest.Play();
            }
            if (GUILayout.Button("RePlay"))
            {
                runTest.RePlay();
            }
            if (GUILayout.Button("Revert"))
            {
                runTest.Revert();
            }
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        if (runTest != null)
        {
            if (GUILayout.Button("Pause"))
            {
                runTest.Pause();
            }
            if (GUILayout.Button("Resume"))
            {
                runTest.Resume();
            }
            if (GUILayout.Button("Reset"))
            {
                runTest.Reset();
            }
            if (GUILayout.Button("Kill"))
            {
                runTest.Kill();
            }
        }
        EditorGUILayout.EndHorizontal();
    }
}
