using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform cam, Target;

    public float speed = 3;

    private void Update()
    {
        Vector3 pos = Vector3.Lerp(cam.position, Target.position, 0.5f * Time.deltaTime * speed);

        cam.position = pos;
    }
}
