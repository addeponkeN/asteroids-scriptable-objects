using UnityEngine.UIElements;

#if UNITY_EDITOR
using UnityEditor;

namespace DefaultNamespace
{
    /// <summary>
    /// Ended up not using this...
    /// </summary>
    public class GameManagerEditor : Editor
    {
        public VisualTreeAsset UXML;

        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();
            UXML.CloneTree(root);
            return root;
        }
    }
}

#endif