using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellPlane : MonoBehaviour
{
    GameObject shell;
    public int repeat = 5;
    public float distance=0.01f;
    // Start is called before the first frame update
    void Start()
    {
        shell = gameObject;
        for (int i = 0; i < repeat; i++)
        {
           GameObject creation= Instantiate(shell, new Vector3(transform.position.x, transform.position.y + (distance * i), transform.position.z), transform.rotation,transform.parent);
            creation.GetComponent<ShellPlane>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
