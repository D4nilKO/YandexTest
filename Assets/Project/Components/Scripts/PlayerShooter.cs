using NTC.Global.Pool;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class PlayerShooter : MonoBehaviour
    {
        [SerializeField] private Bullet _bullet;
        [SerializeField] private KeyCode _key = KeyCode.A;

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