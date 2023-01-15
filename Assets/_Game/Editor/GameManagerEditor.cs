using UnityEngine.UIElements;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.UIElements;

namespace DefaultNamespace
{
    [CustomEditor(typeof(GameManager))]
    public class GameManagerEditor : Editor
    {
        public VisualTreeAsset uxml;

        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();
            
            uxml.CloneTree(root);
            
            InspectorElement.FillDefaultInspector(root, serializedObject, this);
            
            return root;
        }
    }
}

#endif