using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveTarget : MonoBehaviour
{
    private void Awake()
    {
        RayCaster.OnRayCast += OnCastHandler;
    }

    private void OnDestroy()
    {
        RayCaster.OnRayCast -= OnCastHandler;
    }

    private void OnCastHandler(Vector3 position)
    {
        transform.position = position;
    }
}
