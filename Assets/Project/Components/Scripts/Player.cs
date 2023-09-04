using System;
using UnityEngine;

namespace Project.Components.Scripts
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D _rigidbody;

        [SerializeField] private float horizontalVelocity = 3f;
        [SerializeField] private float verticalVelocity = 3f;

        [SerializeField] private float divider = 0.001f;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                var velocity = _rigidbody.velocity;
                
                velocity += Vector2.up * (verticalVelocity * divider);
                velocity.x = horizontalVelocity;
                
                _rigidbody.velocity = velocity;
            }
        }
    }
}