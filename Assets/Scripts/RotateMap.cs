using UnityEngine;

public class RotateMap : MonoBehaviour
{
    public Rigidbody sphereRigidbody;

    //Define the turning speed.
    public float velocity = 1.0f;
    public float force = 4.0f;

    private float horizontal;
    private float vertical;
    private bool isReseting = false;


    // Update is called once per frame
    void Update()
    {
        Rotate();
        ResetRotation();
        AddForceToSphere();
    }

    void Rotate()
    {
        horizontal = (horizontal + velocity * Input.GetAxisRaw("Horizontal")) % 360f;
        vertical = (vertical + velocity * Input.GetAxisRaw("Vertical")) % 360f;
        transform.rotation = Quaternion.Euler(vertical, horizontal, 0);
    }

    void ResetRotation()
    {
        if (Input.GetKeyDown("space"))
            isReseting = true;

        if (isReseting)
        {
            BecomeZero(ref horizontal);
            BecomeZero(ref vertical);
        }

        if (horizontal == 0 && vertical == 0)
            isReseting = false;
    }

    void BecomeZero(ref float number)
    {
        if (number < 1 && number > -1)
            number = 0;
        else if (number < 0)
            number += 1f;
        else if (number > 0)
            number -= 1f;
    }

    void AddForceToSphere()
    {
        sphereRigidbody.AddForce(-Input.GetAxisRaw("Horizontal") * force, -Input.GetAxisRaw("Vertical") * force, 0, ForceMode.Impulse);
    }
}
