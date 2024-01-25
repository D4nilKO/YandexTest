using NTC.Global.Pool;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _speed;
        private Vector2 _direction;

        public void SetDirection(Vector2 direction)
        {
            _direction = direction;
        }

        private void Update()
        {
            Move();
        }
        
        private void Move()
        {
            transform.Translate(_direction * (_speed * Time.deltaTime));
        }

        private void OnBecameInvisible()
        {
            NightPool.Despawn(gameObject);
        }
    }
}