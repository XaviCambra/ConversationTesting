using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SO_Conversation))]
public class SO_ConversationEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        var myScript = target as SO_Conversation;

        myScript.m_HasOptions = GUILayout.Toggle(myScript.m_HasOptions, "Has Options?");

        if (!myScript.m_HasOptions)
            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_NextConversation"), true);
        else
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_PosibleOptions"), true);
            serializedObject.ApplyModifiedProperties();
        }
    }
}
