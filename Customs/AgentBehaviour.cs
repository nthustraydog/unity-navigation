using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class AgentBehaviour : MonoBehaviour {

    private NavMeshAgent m_agent;
    private Animator m_animator;

	// Use this for initialization
    void Awake()
    {
        m_agent = gameObject.GetComponent<NavMeshAgent>();
        m_animator = gameObject.GetComponent<Animator>(); 
    }	
	
	// Update is called once per frame
	void Update () {
        // Change "Speed" of Animator with velocity of agent        
	}
}
