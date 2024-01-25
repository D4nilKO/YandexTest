using UnityEngine;

namespace Project.Components.Scripts
{
    public class ObjectTracker : MonoBehaviour
    {
        [SerializeField] private Transform _target;

        [SerializeField] private float _xOffset;
        [SerializeField] private float _yOffset;

        [SerializeField] private bool _isTrackX;
        [SerializeField] private bool _isTrackY;

        private void Update()
        {
            ChangePosition();
        }

        private void ChangePosition()
        {
            transform.position = GetNewPosition();
        }

        private Vector3 GetNewPosition()
        {
            Vector3 currentPosition = transform.position;

            Vector3 newPosition = new(currentPosition.x, currentPosition.y, currentPosition.z);

            if (_isTrackX)
            {
                newPosition = new Vector3(_target.position.x + _xOffset, newPosition.y, newPosition.z);
            }

            if (_isTrackY)
            {
                newPosition = new Vector3(newPosition.x, _target.position.y + _yOffset, newPosition.z);
            }
            
            return newPosition;
        }
    }
}