using UnityEngine;

namespace Project.Components.Scripts
{
    [RequireComponent(typeof(Player))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private Vector3 _startPosition;
        [SerializeField] private float _speed = 5f;
        [SerializeField] private float _verticalForce = 1.5f;

        private Rigidbody2D _rigidbody;

        private void Start()
        {
            transform.position = _startPosition;

            _rigidbody = GetComponent<Rigidbody2D>();
            _rigidbody.velocity = Vector2.zero;
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _rigidbody.AddForce(Vector2.up * _verticalForce, ForceMode2D.Force);
                _rigidbody.velocity = new Vector2(_speed, _rigidbody.velocity.y);
            }
        }
    }
}