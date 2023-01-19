using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Asteroids
{
    public class AsteroidEditor : Editor
    {
        public VisualTreeAsset UXML;

        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();
            
            UXML.CloneTree(root);
            
            InspectorElement.FillDefaultInspector(root, serializedObject, this);
            
            return root;
        }
    }
}