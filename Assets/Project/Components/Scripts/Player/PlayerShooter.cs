using NTC.Global.Pool;
using Project.Components.Scripts.Enemy;
using UnityEngine;

namespace Project.Components.Scripts.Player
{
    public class PlayerShooter : MonoBehaviour
    {
        [SerializeField] private Bullet _bullet;
        [SerializeField] private KeyCode _key = KeyCode.A;

        public KeyCode GetKey => _key;

        private void Update()
        {
            TryShoot();
        }

        private void TryShoot()
        {
            if (Input.GetKeyDown(_key))
            {
                NightPool.Spawn(_bullet, transform.position, gameObject.transform.rotation);
            }
        }
    }
}