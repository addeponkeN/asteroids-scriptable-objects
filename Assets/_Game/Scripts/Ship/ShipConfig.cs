using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Ship Config", menuName = "ScriptableObjects/ShipConfig", order = 0)]
    public class ShipConfig : ScriptableObject
    {
        [SerializeField] [Range(5, 100)] private float _throttle;
        [SerializeField] [Range(1, 20)] private float _rotation;

        public float ThrottlePower => _throttle;
        public float RotationPower => _rotation;
    }
}