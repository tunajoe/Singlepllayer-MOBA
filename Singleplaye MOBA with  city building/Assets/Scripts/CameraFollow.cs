using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    private Vector3 cameraOffSet;

    [Range(0.01f, 1.0f)]
    public float Smoothnes= 0.05f;



    void Start()
    {
        cameraOffSet = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Player.position + cameraOffSet;
        transform.position = Vector3.Slerp(transform.position, newPos, Smoothnes);
    }
}
