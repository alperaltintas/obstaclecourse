using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    MeshRenderer renderer;
    Rigidbody rigidbody;

    private void Start()
    {
        Visible(false);
        Gravity(false);
    }

    void Update()
    {
        DropCube();
    }

    private void DropCube()
    {
        if (Time.time>=timeToWait)
        {
            Gravity(true);
            Visible(true);

        }
    }

    public void Visible(bool sense)
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = sense;
    }

    public void Gravity(bool sense)
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = sense;

    }

}
