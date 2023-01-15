using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Variables
{
    [CreateAssetMenu(fileName = "new FloatVariable", menuName = "ScriptableObjects/Variables/FloatVariable")]
    public class FloatVariable : ScriptableObject
    {
        public static implicit operator float(FloatVariable var) => var._value;
        
        [Range(0f, 10f)]
        [SerializeField] private float _value;

        public float Value => _value;
    }
}
