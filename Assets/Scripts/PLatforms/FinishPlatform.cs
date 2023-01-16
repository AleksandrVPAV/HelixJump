using UnityEngine;

public class FinishPlatform : Platform
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Ball ball))
        {
            Debug.Log("Конец Игры");
        }
    }
}
