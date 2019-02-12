using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    private Transform m_Transform;

    private float x = 0;
    private float y = 0;
    private float z = 0;

    private float speed = 0.05f;
	void Awake () {
        m_Transform = gameObject.GetComponent<Transform>();
	}
	

	void Update () {
        MovePlayer();
	}

    private void MovePlayer()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            m_Transform.position =Vector3.Lerp(m_Transform.position, m_Transform.position+new Vector3(0,1,0), speed);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_Transform.position = Vector3.Lerp(m_Transform.position, m_Transform.position + new Vector3(-1, 0, 0), speed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Transform.position = Vector3.Lerp(m_Transform.position, m_Transform.position + new Vector3(0, -1, 0), speed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Transform.position = Vector3.Lerp(m_Transform.position, m_Transform.position + new Vector3(1, 0, 0), speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Wall")
        {
            Debug.Log("peng!");
        }
    }
}