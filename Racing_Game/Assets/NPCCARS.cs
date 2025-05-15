using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCARS : MonoBehaviour
{
    public Vector3 moveDirection;
    public float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
