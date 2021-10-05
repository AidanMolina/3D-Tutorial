using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] RuntimeData _runtimeData;

    [SerializeField] float _mouseSensitivity = 10f;

    [SerializeField] Camera _cam;

    float _currentTilt = 0f;

    [SerializeField] float _moveSpeed = 3f;

    public static int _health;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _health = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(_runtimeData.CurrentGameplayState == GameplayState.FreeWalk){
            Movement();
            Aim();
        }
    }

    void Aim(){
        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up, MouseX * _mouseSensitivity);
        
        _currentTilt -= MouseY * _mouseSensitivity;
        _currentTilt = Mathf.Clamp(_currentTilt, -90, 90);

        _cam.transform.localEulerAngles = new Vector3(_currentTilt, 0, 0);
    }

    void Movement(){
        Vector3 sidewaysMovementVector = transform.right * Input.GetAxis("Horizontal");
        Vector3 forwardBackwardMovementVector = transform.forward * Input.GetAxis("Vertical");
        Vector3 movementVector = sidewaysMovementVector + forwardBackwardMovementVector;

        GetComponent<CharacterController>().Move(movementVector * _moveSpeed * Time.deltaTime);
    }

    
}
