﻿/*
 * @author Valentin Simonov / http://va.lent.in/
 */

using TouchScript.Gestures;
using UnityEditor;
using UnityEngine;

namespace TouchScript.Editor.Gestures.Simple
{
    [CustomEditor(typeof(ReleaseGesture), true)]
    internal sealed class ReleaseGestureEditor : GestureEditor
    {

        private static readonly GUIContent IGNORE_CHILDREN = new GUIContent("Ignore Children", "If selected this gesture ignores touch points from children.");
        
        private SerializedProperty ignoreChildren;
        
        protected override void OnEnable()
        {
            base.OnEnable();
            
            ignoreChildren = serializedObject.FindProperty("ignoreChildren");
        }
        
        public override void OnInspectorGUI()
        {
            serializedObject.UpdateIfDirtyOrScript();
            
            EditorGUILayout.PropertyField(ignoreChildren, IGNORE_CHILDREN);
            
            serializedObject.ApplyModifiedProperties();
            base.OnInspectorGUI();
        }

    }
}