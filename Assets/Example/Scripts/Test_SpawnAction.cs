using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_SpawnAction : MonoBehaviour {

    public GameObject m_GameObj;
    public int m_SpawnNum;
    public float m_WaitTime = 1;

    [ContextMenu("Test-Spawn")]
    public void Spawn()
    {
        for (int i = 0; i < m_SpawnNum; i++)
        {
            Instantiate<GameObject>(m_GameObj);
        }
    }

    public void SpawnDuration()
    {
        StartCoroutine(SpawnDurationtor());
    }

    private IEnumerator SpawnDurationtor()
    {
        for (int i = 0; i < m_SpawnNum; i++)
        {
            Instantiate<GameObject>(m_GameObj);
            yield return new WaitForSeconds(m_WaitTime);
        }
        
    }


}
