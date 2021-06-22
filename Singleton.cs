using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<SingletonClass> : MonoBehaviour where SingletonClass: Component
{
    private static SingletonClass _instance;
    public static SingletonClass Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<SingletonClass>();
                if(_instance == null)
                {
                    GameObject GO = new GameObject();
                    _instance = GO.AddComponent<SingletonClass>();
                }
            }
            return _instance;
        }
    }

 protected virtual void Awake()
    {
        _instance = this as SingletonClass;
    }
}
