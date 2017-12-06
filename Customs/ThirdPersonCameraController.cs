﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour {

    public float smooth = 30f;    
   
    private GameObject m_cameraAnchor;
    private float m_yaw = 45;
    private float m_pitch = 40;
    private float m_speedH = 2.0f;
    private float m_speedV = 2.0f;
    public GameObject target;

    private float m_dis = 20.0f;

    void Start()
    {
        // Default Camera Anchor is character's backward
        m_cameraAnchor = new GameObject();
        m_cameraAnchor.transform.rotation = target.transform.rotation;
        m_cameraAnchor.transform.position = target.transform.position + target.transform.up * 1.5f;
        m_cameraAnchor.transform.Translate(new Vector3(0.0f, 0.0f, -m_dis));
    }


    void FixedUpdate()	
    {
        // Update Camera Anchor
        if (Input.GetMouseButton(0))
        {
            m_yaw += m_speedH * Input.GetAxis("Mouse X");
            m_pitch -= m_speedV * Input.GetAxis("Mouse Y");            
        }
        m_cameraAnchor.transform.rotation = target.transform.rotation;
        m_cameraAnchor.transform.Rotate(new Vector3(m_pitch, m_yaw, 0.0f));
        m_cameraAnchor.transform.position = target.transform.position + target.transform.up * 1.5f;
        m_cameraAnchor.transform.Translate(new Vector3(0.0f, 0.0f, -m_dis));

        // Change camera's transform
        transform.position = Vector3.Lerp(transform.position, m_cameraAnchor.transform.position, Time.fixedDeltaTime * smooth);
        transform.forward = Vector3.Lerp(transform.forward, m_cameraAnchor.transform.forward, Time.fixedDeltaTime * smooth);                  
    }

    
}
