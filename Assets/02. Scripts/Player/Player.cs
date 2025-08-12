using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector2 _inputVec;          //입력 방향
    [SerializeField] private int _speed;                 //속도
    [SerializeField] private Rigidbody2D _rigid;         //리지드 바디

    [SerializeField] private ObjectDetector _objectDetector;

    private void Awake()
    {
        _objectDetector = GetComponentInChildren<ObjectDetector>();
    }

    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 nextVec = _inputVec * _speed * Time.fixedDeltaTime;
        _rigid.MovePosition(_rigid.position + nextVec);
    }

    void OnMove(InputValue value)
    {
        _inputVec = value.Get<Vector2>();
    }

    void OnInteract()
    {
        if(_objectDetector.Nearest != null) _objectDetector.Nearest.Interact();
    }
}
