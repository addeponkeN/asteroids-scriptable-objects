using UnityEngine.UIElements;

#if UNITY_EDITOR
using UnityEditor;

namespace DefaultNamespace
{
    public class GameManagerEditor : Editor
    {
        public VisualTreeAsset uxml;

        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();
            uxml.CloneTree(root);
            return root;
        }
    }
}

#endif