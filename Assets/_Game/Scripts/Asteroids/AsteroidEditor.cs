using UnityEditor.UIElements;
using UnityEngine.UIElements;

#if UNITY_EDITOR
using UnityEditor;

namespace Asteroids
{
    /// <summary>
    /// Ended up not using this...
    /// </summary>
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

#endif