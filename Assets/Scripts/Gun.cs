using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class Gun : MonoBehaviour
{
    private StarterAssetsInputs _input;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletPoint;
    [SerializeField] private float bulletSpeed = 600f;
    //private Rigidbody goli;
    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
        //goli = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.shoot)
        {
            Shoot();
            _input.shoot = false;
        }
        
    }
    void Shoot()
    {
        Debug.Log("Shoot");
         GameObject bullet = Instantiate(bulletPrefab , bulletPoint.transform.position , transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Destroy(bullet, 1);
    }
}
