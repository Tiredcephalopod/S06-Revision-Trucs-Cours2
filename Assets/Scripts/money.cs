using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour

{   
    [SerializeField] GameObject _prefabOriginal;
  
    [SerializeField] Vector3 _skibidy;

    void Start()
    {
        Quaternion _rotation = Quaternion.Euler(0f, 50f, 0f);
        Instantiate(_prefabOriginal, _skibidy, _rotation);
        
    }
    // Start is called before the first frame update
    
        
    }

  

