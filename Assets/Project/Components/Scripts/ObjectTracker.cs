using UnityEngine;

namespace Project.Components.Scripts
{
    
    public class ObjectTracker : MonoBehaviour
    {
        [SerializeField] private GameObject _gameObject;
        [SerializeField] private float _xOffset;

        private void Update()
        {
            transform.position = new Vector3(_gameObject.transform.position.x + _xOffset, transform.position.y,
                transform.position.z);
        }
    }
}