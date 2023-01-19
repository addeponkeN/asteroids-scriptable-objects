using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "Asteroid Config", menuName = "ScriptableObjects/AsteroidConfig", order = 0)]
    public class AsteroidConfig : ScriptableObject
    {
        [SerializeField] [Range(0.5f, 10f)] private float _minSpawnTime = 5f;
        [SerializeField] [Range(0.5f, 10f)] private float _maxSpawnTime = 3f;
        [SerializeField] [Range(0, 20)] private float _minAmount = 2;
        [SerializeField] [Range(0, 20)] private float _maxAmount = 4;

        public float MinSpawnTime => _minSpawnTime;
        public float MaxSpawnTime => _maxSpawnTime;
        public float MinAmount => _minAmount;
        public float MaxAmount => _maxAmount;
    }
}