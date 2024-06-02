using NTC.Global.Pool;
using UnityEngine;
using VavilichevGD.Utils.Timing;
using Random = System.Random;

namespace Project.Components.Scripts.Enemy
{
    public class Spawner : MonoBehaviour
    {
        [Header("Тип таймера")] [SerializeField]
        private TimerType _timerType;

        [Header("Объект для спауна")] [SerializeField]
        private GameObject _prefab;

        [SerializeField] private bool _isSpawnerRotation;

        [Header("Время спауна")] [SerializeField]
        private float _timerSeconds;

        [Header("Дистанция спавна по X")] [SerializeField]
        private int _minSpawnDistanceX;

        [SerializeField] private int _maxSpawnDistanceX;

        [Header("Дистанция спавна по Y")] [SerializeField]
        private int _minSpawnDistanceY;

        [SerializeField] private int _maxSpawnDistanceY;

        private float _startTimerSeconds = 0.1f;

        private SyncedTimer _spawnTimer;
        private Random _random;

        private void Awake()
        {
            _spawnTimer = new SyncedTimer(_timerType, _timerSeconds);
            _random = new Random();
        }

        private void Start()
        {
            _spawnTimer.Start(_startTimerSeconds);
        }

        private void OnEnable()
        {
            _spawnTimer.TimerFinished += OnTimerFinished;
        }

        private void OnDisable()
        {
            _spawnTimer.TimerFinished -= OnTimerFinished;
        }

        private Vector3 GetSpawnPoint()
        {
            int distanceX = _random.Next(_minSpawnDistanceX, _maxSpawnDistanceX);
            int distanceY = _random.Next(_minSpawnDistanceY, _maxSpawnDistanceY);

            var position = transform.position;

            var spawnPoint = new Vector3(position.x + distanceX, position.y + distanceY, 0);

            return spawnPoint;
        }

        private void OnTimerFinished()
        {
            Spawn(_prefab);

            _spawnTimer.Start(_timerSeconds);
        }


        private void Spawn(GameObject prefab)
        {
            NightPool.Spawn(prefab, GetSpawnPoint(),
                _isSpawnerRotation ? transform.rotation : prefab.transform.rotation);
        }
    }
}