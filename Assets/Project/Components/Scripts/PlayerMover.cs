using UnityEngine;
using UnityEngine.Events;

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
        
        public event UnityAction GameStarted; 

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            Time.timeScale = 0;
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            if (Input.GetKey(KeyCode.Space) || (Input.GetMouseButton(0)))
            {
                if (Time.timeScale == 0)
                {
                    Time.timeScale = 1;
                    GameStarted?.Invoke();
                }
                
                _rigidbody.AddForce(Vector2.up * _verticalForce, ForceMode2D.Force);
                _rigidbody.velocity = new Vector2(_speed, _rigidbody.velocity.y);
            }
        }

        public void Reset()
        {
            transform.position = _startPosition;
            _rigidbody.velocity = Vector2.zero;
        }
    }
}