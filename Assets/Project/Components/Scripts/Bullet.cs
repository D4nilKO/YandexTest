using UnityEngine;

namespace Project.Components.Scripts
{
    [RequireComponent(typeof(Collider2D))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] [Min(0.1f)] private float _speed = 0.1f;
        
        private Vector2 _direction = Vector2.up;
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
            UserUtils.TryDespawn(gameObject);
        }
    }
}