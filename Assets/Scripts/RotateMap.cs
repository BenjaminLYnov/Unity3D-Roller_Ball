using UnityEngine;

public class RotateMap : MonoBehaviour
{
    //Define the turning speed.
    public float velocity = 1.0f;

    private float horizontal;
    private float vertical;
    private float lateral;


    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        horizontal = (horizontal + velocity * Input.GetAxisRaw("Horizontal")) % 360f;
        vertical = (vertical + velocity * Input.GetAxisRaw("Vertical")) % 360f;
        lateral = (lateral + velocity * Input.GetAxisRaw("Lateral")) % 360f;
        transform.rotation = Quaternion.Euler(vertical, horizontal, lateral);
    }
}
