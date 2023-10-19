using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 _direction;
    [SerializeField ] private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        Input.Initialize(this);
        Input.SetPlayerControls();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)(_speed * Time.deltaTime * _direction);
    }

    public void SetMoveDirection(Vector3 directionInput)
    {
        _direction = directionInput;
    }
    public void resetPlayerControls()
    {
        Input.Initialize(this);
    }
}
