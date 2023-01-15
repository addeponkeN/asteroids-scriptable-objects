using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
[Serializable]
public class GameManager : MonoBehaviour
{
    [SerializeField] private ShipConfig _shipConfig;
}