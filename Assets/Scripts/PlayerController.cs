using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private GroundCheck _check;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private void Update()
    {
        _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * _speed, _rigidbody.velocity.y);
        if (Input.GetKey(KeyCode.Space) && _check.IsGrounded)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 0f);
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Respawn") SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}