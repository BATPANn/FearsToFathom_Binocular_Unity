using UnityEngine;

public class F2F_Binocular : MonoBehaviour
{


    public float minFOV = 20f;
    public float maxFOV = 60f;
    public float ZoomSpeed = 2f;
    public float SmoothSpeed = 8f;

    public Camera cam;
    private float targetFOV;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetFOV = cam.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if(scroll != 0)
        {

            targetFOV -= scroll * ZoomSpeed * 10f;
            targetFOV = Mathf.Clamp(targetFOV, minFOV, maxFOV);

        }

        // smooth
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, targetFOV, SmoothSpeed * Time.deltaTime);


    }

}
