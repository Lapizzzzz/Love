using UnityEngine;

public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private Transform _playerTransform;

    private bool _isChasing = false;

    private void Update()
    {
        if (_isChasing)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                _playerTransform.position,
                _speed * Time.deltaTime
            );
        }
    }

    public void StartChasing()
    {
        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }
}
