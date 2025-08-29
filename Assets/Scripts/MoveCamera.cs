using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    [Header("Camera Settings")]
    [SerializeField] float cameraSpeed = 10f; // Base movement speed (units per second)

    [Header("Mouse Look")]
    [SerializeField] Vector2 turn; // Accumulated yaw (x) and pitch (y) from mouse input
    [SerializeField] float sensitivity = .5f; // Mouse sensitivity multiplier


    // Start is called before the first frame update
    void Start()
    {
        // Lock the cursor to the game window
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Camera movement
        Vector3 go = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            go += transform.forward; // forward
        }
        if (Input.GetKey(KeyCode.S))
        {
            go -= transform.forward; // back
        }
        if (Input.GetKey(KeyCode.A))
        {
            go -= transform.right; // left
        }
        if (Input.GetKey(KeyCode.D))
        {
            go += transform.right; // right
        }

        if (go.sqrMagnitude > 0f)
        {
            transform.position += go.normalized * cameraSpeed * Time.deltaTime;
        }


        // Accumulate mouse movement into yaw/pitch
        turn.x += Input.GetAxis("Mouse X") * sensitivity; // horizontal (turn.x = yaw)
        turn.y += Input.GetAxis("Mouse Y") * sensitivity; // vertical (turn.y = pitch)
        // Apply local rotation from pitch (negative) and yaw
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        // If press Esc -> unlock cursor and make it visible again
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
