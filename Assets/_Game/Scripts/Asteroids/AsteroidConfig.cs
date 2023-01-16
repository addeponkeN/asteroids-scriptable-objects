using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "Asteroid Config", menuName = "ScriptableObjects/AsteroidConfig", order = 0)]
    public class AsteroidConfig : ScriptableObject
    {
        [SerializeField] private float _minSpawnTime = 5f;
        [SerializeField] private float _maxSpawnTime = 3f;
        [SerializeField] private float _minAmount = 2;
        [SerializeField] private float _maxAmount = 4;

        public float MinSpawnTime => _minSpawnTime;
        public float MaxSpawnTIme => _maxSpawnTime;
        public float MinAmount => _minAmount;
        public float MaxAmount => _maxAmount;
    }
}
