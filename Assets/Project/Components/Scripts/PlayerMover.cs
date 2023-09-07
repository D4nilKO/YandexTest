using System;
using UnityEngine;
using UnityEngine.Events;

namespace Project.Components.Scripts
{
    [RequireComponent(typeof(Player))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private Vector3 _startPosition;
        [SerializeField] private float _speed = 10f;
        [SerializeField] private float _verticalForce = 50;

        private bool _gameIsStarted;

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
            if (_gameIsStarted == false && (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)))
            {
                Time.timeScale = 1;
                _gameIsStarted = true;
                GameStarted?.Invoke();
            }
            
            Move();
        }

        

        private void Move()
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
            {
                _rigidbody.AddForce(Vector2.up * _verticalForce);
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