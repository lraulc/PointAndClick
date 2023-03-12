using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Camera mainCamera;


    private void Awake()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    private void Update()
    {
        // if left click
        // cast a ray
        // Debug position that was selected
        // create object at floor position (x,,y,z)
    }

    private void OnMouseDown()
    {

    }

    private void RaycastToFloor()
    {

    }
}
