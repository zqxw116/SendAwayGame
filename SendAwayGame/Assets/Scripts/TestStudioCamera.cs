using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStudioCamera : MonoBehaviour
{
    public Camera testCamera;
    public GameObject objCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraInObject();
    }

    private void CameraInObject()
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(testCamera);
        var position = objCube.transform.position;
        Debug.Log($"##### start");
        foreach (var plane in planes)
        {
            Debug.Log($"plane : {plane}" );
            Debug.Log($"<color=green>GetDistancePoint : {plane.GetDistanceToPoint(position)}</color>");
            if (plane.GetDistanceToPoint(position) < 0)
            {
                Debug.Log($"<color=red> ## false</color>");
            }
        }

    }
}
