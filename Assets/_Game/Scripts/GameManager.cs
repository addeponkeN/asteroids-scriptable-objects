using Asteroids;
using UnityEngine;
using UnityEngine.UIElements;

namespace DefaultNamespace
{
    [RequireComponent(typeof(UIDocument))]
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private AsteroidConfig _asteroidConfig;
        [SerializeField] private ShipConfig _shipConfig;
    }
}