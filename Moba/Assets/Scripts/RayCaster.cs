using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RayCaster : MonoBehaviour
{
    public static Action<Vector3> OnRayCast;

    [SerializeField] private LayerMask mask;
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray castPoint = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(castPoint, out RaycastHit hit, Mathf.Infinity, mask))
            {
                OnRayCast?.Invoke(hit.point);
            }
        }
    }
}
