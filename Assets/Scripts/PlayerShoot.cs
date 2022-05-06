using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private KeyCode shootKey = KeyCode.Space;
    [SerializeField] private float cooldownTime = 0.5f;
    [SerializeField] private bool canShoot = true;
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform aim;

    void Update()
    {
        
        if (Input.GetKeyDown(shootKey) && canShoot)
        {
            StartCoroutine(ShootCor());
        }
    }

    public IEnumerator ShootCor()
    {
        canShoot = false;
        Audiomanager.PlaySound("Lanzar");
        Instantiate(projectile, aim.position, aim.rotation);
        yield return new WaitForSeconds(cooldownTime);
        canShoot = true;
       // Audiomanager.PlaySound("Lanzar");
    }
}
