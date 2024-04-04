using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float Rotation_Speed;
    public float Rotation_Friction; //The smaller the value, the more Friction there is. [Keep this at 1 unless you know what you are doing].
    public float Rotation_Smoothness; //Believe it or not, adjusting this before anything else is the best way to go.

    private float Resulting_Value_from_Input;
    private Quaternion Quaternion_Rotate_From;
    private Quaternion Quaternion_Rotate_To;

    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffset;

    public float fireRate = 1f;
    private float nextFire;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Resulting_Value_from_Input += Input.GetAxis("Horizontal") * Rotation_Speed * Rotation_Friction; //You can also use "Mouse X"
        Quaternion_Rotate_From = transform.rotation;
        Quaternion_Rotate_To = Quaternion.Euler(0, 0, Resulting_Value_from_Input);

        transform.rotation = Quaternion.Lerp(Quaternion_Rotate_From, Quaternion_Rotate_To, Time.deltaTime * Rotation_Smoothness);

        //

        if(Input.GetKey(KeyCode.Space))
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;

                Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
            }
        }
    }
}