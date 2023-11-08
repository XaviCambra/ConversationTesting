using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController m_Instance;


    private void Awake()
    {
        if (m_Instance != null && m_Instance != this)
            Destroy(gameObject);
        else
            m_Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}