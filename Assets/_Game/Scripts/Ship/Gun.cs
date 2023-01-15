using System;
using UnityEngine;

namespace Ship
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Laser _bulletPrefab;
        [SerializeField] private KeyCode _keybind = KeyCode.Space;

        private void Update()
        {
            if (Input.GetKeyDown(_keybind))
                Shoot();
        }
        
        private void Shoot()
        {
            var trans = transform;
            Instantiate(_bulletPrefab, trans.position, trans.rotation);
        }
    }
}
