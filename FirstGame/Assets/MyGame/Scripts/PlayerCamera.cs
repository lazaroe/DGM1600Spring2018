using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	public float zoomSpeed = 4f;
	public float minZoom = 5f;
	public float maxZoom = 15f;

	public float yawSpeed = 100f;
	private float currentZoom = 10f;
	private float currentYaw = 0;

    void Start ()
    {
        offset = transform.position - player.transform.position;
    }
    
    void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
		currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

		currentYaw -= Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
    }
}