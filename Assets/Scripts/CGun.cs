using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGun : MonoBehaviour {

    public GameObject Bullet;
    public Transform Cow;
    public AudioClip fart;
    public AudioSource speaker;
    public float speed;
    public float time;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        var bullet = (GameObject)Instantiate(
            Bullet,
            Cow.position,
            Cow.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * -speed;

        speaker.PlayOneShot(fart, 0.1F);

        Destroy(bullet, time);
    }
}
