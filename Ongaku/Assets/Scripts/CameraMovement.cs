using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    private static GameObject sceneCam;
    public float strength = 0.5f;

    void Start()
    {
        sceneCam = GameObject.Find("Main Camera");
        if (!sceneCam)
        {
            Debug.Log("I am null!");
        }
    }


    public void moveCamPos(float x, float y, float z)
    {
        Debug.Log("Null not here");
        Vector3 cameraPosition = new Vector3(x, y, z);
        sceneCam.transform.position = Vector3.Lerp(transform.position, cameraPosition, strength);
    }

}
