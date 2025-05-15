using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Movment : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Vector3 moveDirection;
    public TMP_Text scoreText;
    public bool busMovingSideways = false;
    public bool OnRight = false;

    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && busMovingSideways == false && OnRight == false)
        {
            moveDirection = new Vector3(100f, 0f, 100f);
            busMovingSideways = true;
            OnRight = true;
        }
        
        else if (Input.GetKeyDown(KeyCode.Space) && busMovingSideways == true)
        {
            moveDirection = new Vector3(0f, 0f, 100f);
            busMovingSideways = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && busMovingSideways == false && OnRight == true)
        {
            moveDirection = new Vector3(-100f, 0f, 100f);
            busMovingSideways = true;
            OnRight = false;
        }
        }
    }

