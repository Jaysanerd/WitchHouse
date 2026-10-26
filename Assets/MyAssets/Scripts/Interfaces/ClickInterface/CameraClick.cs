using UnityEngine;
using UnityEngine.InputSystem;

public class CameraClick : MonoBehaviour
{
    void OnAttack()
    {
        print("gewoon iets.");
        Camera cam = Camera.main;
        RaycastHit hit;

        //ScreenPointToRay transformeerd een 2d screenspace positie naar een worldspace 3D position.
        //vertrekkende vanuit de camera zijn positie.
        Vector2 mousePosition = Mouse.current.position.value;
        Ray ray = cam.ScreenPointToRay(mousePosition);
        Debug.DrawRay(ray.origin, ray.direction, Color.red, 4f);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.GetComponent<IClick>() == null) return;

            hit.transform.gameObject.GetComponent<IClick>().OnClick();
        }
    }
}
