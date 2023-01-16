using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Transform _spawnPoint;

    private void Awake()
    {
        Instantiate(_ball, _spawnPoint.position, Quaternion.identity);
    }
}
