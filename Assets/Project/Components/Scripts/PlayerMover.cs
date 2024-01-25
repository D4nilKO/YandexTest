using UnityEngine;

namespace Project.Components.Scripts
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float _speed = 10f;
        [SerializeField] private float _verticalForce = 0.3f;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _minRotationZ;
        [SerializeField] private float _maxRotationZ;

        [SerializeField] private KeyCode _moveKey = KeyCode.Space;

        private Vector3 _startPosition;
        private Rigidbody2D _rigidbody;
        private Quaternion _minRotation;
        private Quaternion _maxRotation;

        public KeyCode GetKey => _moveKey;

        private void Awake()
        {
            _startPosition = transform.position;
            _rigidbody = GetComponent<Rigidbody2D>();

            _minRotation = Quaternion.Euler(0, 0, _minRotationZ);
            _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            if (Input.GetKey(_moveKey))
            {
                _rigidbody.AddForce(Vector2.up * (_verticalForce * Time.deltaTime), ForceMode2D.Impulse);
                _rigidbody.velocity = new Vector2(_speed, _rigidbody.velocity.y);

                transform.rotation = _maxRotation;
            }

            transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, _rotationSpeed * Time.deltaTime);
        }
    }
}