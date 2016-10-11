using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
public class PointClickMovement : MonoBehaviour {

    [SerializeField]
    [Range(1, 20)]
    private float speed = 10;

    private Vector3 targetPosition;
    private bool isMoving;

    const int LEFT_MOUSE_BUTTON = 0;

	void Start () {

        targetPosition = transform.position;
        isMoving = false;
	
	}
	
	void Update () {

        if (Input.GetMouseButtonDown(LEFT_MOUSE_BUTTON)) {
            SetTargetPosition();
        }

        if(isMoving){
            MovePlayer();
        }
	
	}
    void SetTargetPosition() {

        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0f;

        if (plane.Raycast(ray, out point))
            targetPosition = ray.GetPoint(point);

        isMoving = true;
    }

    void MovePlayer() {
        transform.LookAt(targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if(transform.position == targetPosition) {
            isMoving = false;
        }

        Debug.DrawLine(transform.position, targetPosition, Color.red);
    }
}
