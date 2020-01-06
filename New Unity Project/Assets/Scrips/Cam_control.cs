using UnityEngine;

public class Cam_control : MonoBehaviour
{
    public Transform cam, target;
    public float speed;
    public float r_speed = 100;
    
    private void Update()
    {
        Vector3 Pos = Vector3.Lerp(cam.position, target.position, 0.5f * speed * Time.deltaTime);
        cam.position = Pos;
        float h = Input.GetAxis("Horizontal");
        cam.Rotate(0, r_speed * h * Time.deltaTime, 0) ;
    }
}
