using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform player;
    public float speed;
    public float maxBound,
        minBound;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform>();
        nextFire = Time.time;
    }

    void FixedUpdate()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            if (touchDeltaPosition.x > 0)
                player.position += Vector3.right * speed;
            else
                player.position -= Vector3.right * speed;
        }
        else
        {
            float h = Input.GetAxis("Horizontal");

            if (player.position.x < minBound && h < 0)
            {
                h = 0;
            }
            else
            {
                if (player.position.x > maxBound && h > 0)
                    h = 0;
            }

            player.position += Vector3.right * h * speed;
        }
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
}
