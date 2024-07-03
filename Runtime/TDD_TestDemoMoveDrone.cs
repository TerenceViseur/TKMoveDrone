using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDD_TestDemoMoveDrone : MonoBehaviour
{

    public Transform m_toTestAxis;

    public float m_rotateLeftRight;

    public float m_moveUpDown;

    public float m_moveLeftRight;

    public float m_moveForwardBackward;





    public void SetRotateLeftRight(float rotateLeftRight) => m_rotateLeftRight = rotateLeftRight;

    public void SetMoveUpDown(float moveUpDown) => m_moveUpDown = moveUpDown;

    public void SetMoveLeftRight(float moveLeftRight) => m_moveLeftRight = moveLeftRight;

    public void SetMoveForwardBackward(float moveForwardBackward) => m_moveForwardBackward = moveForwardBackward;

    void Update()
    {
        m_toTestAxis.transform.position += new Vector3(m_moveLeftRight, m_moveUpDown, m_moveForwardBackward) * Time.deltaTime;
        m_toTestAxis.transform.rotation *= Quaternion.Euler(0, m_rotateLeftRight, 0);
    }
}
