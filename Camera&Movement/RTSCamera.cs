using System.Collections;
using UnityEngine;

public class RTSCamera : MonoBehaviour {

    public float scrollZone = 30;
    public float scrollSpeed = 5;

    private Vector3 desiredPosition;

    private void Start() {

        desiredPosition = transform.position;

    }

	private void Update () {

        float x = 0, y = 0, z = 0;
        float speed = scrollZone * Time.deltaTime;

        var mouseWheel = Input.GetAxis("Mouse ScrollWheel");

        if (Input.mousePosition.x < scrollZone) {
            x -= speed;
        }
        else if (Input.mousePosition.x > Screen.width - scrollZone) {
            x += speed;
        }
        if (Input.mousePosition.y < scrollZone) {
            z -= speed;
        }
        else if (Input.mousePosition.y > Screen.height - scrollZone) {
            z += speed;
        }
        if (mouseWheel > 0f) {
            y--;
        }
        else if (mouseWheel < 0f) {
            y++;
        }

        Vector3 move = new Vector3(x, y, z) + transform.position;
        desiredPosition = move;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, 0.5f);

    }
}