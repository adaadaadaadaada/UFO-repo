using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public float Rotation_Speed = 0.5f;
    public float Rotation_Friction = 2.0f; //The smaller the value, the more Friction there is. [Keep this at 1 unless you know what you are doing].
    public float Rotation_Smoothness = 3.0f; //Believe it or not, adjusting this before anything else is the best way to go.

    private float Resulting_Value_from_Input;
    private Quaternion Quaternion_Rotate_From;
    private Quaternion Quaternion_Rotate_To;

    public ProjectileBehavior ProjectilePrefab;

    public Transform middleLaunchOffset;
    public Transform right1LaunchOffset;
    public Transform right2LaunchOffset;
    public Transform left1LaunchOffset;
    public Transform left2LaunchOffset;

    [SerializeField] private GameObject bullet1;
    [SerializeField] private GameObject bullet2;
    [SerializeField] private GameObject bullet3;
    [SerializeField] private GameObject bullet4;
    [SerializeField] private GameObject bullet5;

    private GameObject bulletInst1;
    private GameObject bulletInst2;
    private GameObject bulletInst3;
    private GameObject bulletInst4;
    private GameObject bulletInst5;

    public float fireRate = 10f;
    private float nextFire;

    public int healthpoints = 5;

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

        HandleShooting();
    }

    private void HandleShooting()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;

                bulletInst1 = Instantiate(bullet1, middleLaunchOffset.position, middleLaunchOffset.rotation);
                bulletInst2 = Instantiate(bullet2, right1LaunchOffset.position, right1LaunchOffset.rotation);
                bulletInst3 = Instantiate(bullet3, right2LaunchOffset.position, right2LaunchOffset.rotation);
                bulletInst4 = Instantiate(bullet4, left1LaunchOffset.position, left1LaunchOffset.rotation);
                bulletInst5 = Instantiate(bullet5, left2LaunchOffset.position, left2LaunchOffset.rotation);
            }
        }
    }
}