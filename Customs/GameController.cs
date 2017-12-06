using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class GameController : MonoBehaviour {

    public GameObject destination;
	public GameObject npc;
	public GameObject dynamicWall;

	private NavMeshAgent m_naviAgent;

	// Use this for initialization
	void Start () {
		m_naviAgent = npc.GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1))
        {
            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(r, out hit))
            {
                if (hit.collider.gameObject.tag == "Ground")
                {
                    destination.transform.position = hit.point;
                }

                // Set destination for agent
				m_naviAgent.SetDestination(hit.point);
            }
        }
		if (Input.GetKeyDown ("z")) {
			dynamicWall.SetActive (!dynamicWall.activeSelf);
		}

       
	}
}
