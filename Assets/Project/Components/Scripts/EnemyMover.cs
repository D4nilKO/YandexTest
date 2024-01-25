using System.Collections.Generic;
using NTC.Global.Pool;
using UnityEngine;
using Random = System.Random;

namespace Project.Components.Scripts
{
    public class EnemyMover : MonoBehaviour, IPoolItem
    {
        [SerializeField] private int _minSpotDistance = 1;
        [SerializeField] private int _maxSpotDistance = 3;
        [SerializeField] private float _speed;

        private Random _random;

        public List<Vector3> _moveSpots = new();
        private int _spotNumber;

        private int _minDirectionValue = 0;
        private int _maxDirectionValue = 1;

        private void Update()
        {
            Move();
        }

        private void OnBecameInvisible()
        {
            if (gameObject.activeInHierarchy)
            {
                NightPool.Despawn(gameObject);
            }
        }

        public void OnSpawn()
        {
            _random ??= new Random();

            GetNewSpots();
        }

        public void OnDespawn()
        {
            _moveSpots.Clear();
        }

        private void GetNewSpots()
        {
            _moveSpots.Add(transform.position);
            _moveSpots.Add(_moveSpots[0] + (GetNewDistance() * GetNewDirection()));
        }

        private Vector3 GetNewDirection()
        {
            int randomValue = _random.Next(_minDirectionValue, _maxDirectionValue + 1);
            Vector3 direction = randomValue == 1 ? Vector2.up : Vector2.down;

            return direction;
        }

        private int GetNewDistance()
        {
            int distance = _random.Next(_minSpotDistance, _maxSpotDistance);

            return distance;
        }

        private void Move()
        {
            transform.position =
                Vector3.MoveTowards(transform.position, _moveSpots[_spotNumber], _speed * Time.deltaTime);

            if (transform.position == _moveSpots[_spotNumber])
            {
                _spotNumber = (_spotNumber + 1) % _moveSpots.Count;
            }
        }
    }
}