using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace Project.Components.Scripts
{
    public class Enemy : MonoBehaviour
    {
        private Random _random;

        private int _minDirectionValue = 0;
        private int _maxDirectionValue = 1;

        public List<Vector3> _moveSpots = new();

        private int _spotNumber = 0;

        [SerializeField] private int _minDistance;
        [SerializeField] private int _maxDistance;

        [SerializeField] private float _speed;

        private void Start()
        {
            _random = new Random();

            _moveSpots.Add(gameObject.transform.position);
            _moveSpots.Add(_moveSpots[0] + (GetDistance() * GetDirection()));
        }

        private void Update()
        {
            Move();
        }

        private Vector3 GetDirection()
        {
            int randomValue = _random.Next(_minDirectionValue, _maxDirectionValue + 1);

            Vector3 direction = randomValue == 1 ? Vector2.up : Vector2.down;

            return direction;
        }

        private int GetDistance()
        {
            int distance = _random.Next(_minDistance, _maxDistance);
            
            return distance;
        }

        private void Move()
        {
            transform.position =
                Vector3.MoveTowards(transform.position, _moveSpots[_spotNumber], _speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, _moveSpots[_spotNumber]) < 0.2f)
            {
                _spotNumber = (_spotNumber == 1) ? 0 : 1;
            }
        }
    }
}