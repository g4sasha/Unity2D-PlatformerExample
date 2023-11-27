using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _cameraSpeed;

    void Update()
    {
        float x = transform.position.x + (_cameraSpeed * (_target.position.x - transform.position.x) / 100f);
        float y = transform.position.y + (_cameraSpeed * (_target.position.y - transform.position.y) / 100f);

        transform.position = new Vector2(x, y);
    }
}
