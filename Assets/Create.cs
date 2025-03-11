using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    [SerializeField] GameObject _prefabOriginal;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        Instantiate(_prefabOriginal, position, rotation);
    }


}
