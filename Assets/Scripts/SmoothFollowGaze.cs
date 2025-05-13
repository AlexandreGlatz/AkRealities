using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollowGaze : MonoBehaviour
{
    [SerializeField] Transform _cameraTransform;
    [SerializeField] float _cameraDistance = 1.0f;
    [SerializeField] float _smoothTime = 0.3f;
    bool _isCentered;
    Vector3 _velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        _isCentered = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = _cameraTransform.position + _cameraTransform.forward * _cameraDistance;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, _smoothTime * Time.deltaTime);

        transform.LookAt(transform.position + _cameraTransform.rotation * Vector3.forward, _cameraTransform.rotation * Vector3.up);

    }

}
