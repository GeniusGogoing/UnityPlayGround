using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Player))]
public class InspectorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Player player = (Player)target;
        player.exp = EditorGUILayout.IntField("Exp", player.exp);
        EditorGUILayout.LabelField("level", player.Level.ToString());
        EditorGUILayout.HelpBox("this is a help box", MessageType.None);
        if (GUILayout.Button("Add 1000 exp !"))
        {
            player.AddExp(1000);
        }
    }
}
