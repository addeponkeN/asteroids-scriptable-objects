using System;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Ship Config", menuName = "ScriptableObjects/ShipConfig", order = 0)]
    public class ShipConfig : ScriptableObject
    {
        [SerializeField] private float _throttle;
        [SerializeField] private float _rotation;

        public float ThrottlePower => _throttle;
        public float RotationPower => _rotation;
    }
    
}
