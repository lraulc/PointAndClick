using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Player : MonoBehaviour
{
    Camera mainCamera;
    Transform cameraTransform;
    [SerializeField] private float rayDistance;

    private void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    private void Update()
    {
        // if left click
        // cast a ray
        // Debug position that was selected
        // create object at floor position (x,,y,z)
        cameraTransform = mainCamera.gameObject.transform;
        RaycastFromCamera();
    }

    private void OnMouseDown()
    {

    }

    private void RaycastFromCamera()
    {
        RaycastHit hit;

        if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit, rayDistance))
        {
            Debug.DrawLine(cameraTransform.position, (cameraTransform.forward * rayDistance) + cameraTransform.position, Color.red, 0.01f);
        }
    }

    private void OnDrawGizmos()
    {
        RaycastHit hit;
        if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit, rayDistance))
        {
            Gizmos.DrawSphere(hit.point, 1.0f);
        }
    }
}
