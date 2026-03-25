using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform startPos;

    public int maxShots = 3;   // máximo de disparos
    private int currentShots = 0; // contador actual

    public void Shoot(InputAction.CallbackContext context){
        if(context.started && currentShots < maxShots){
            GameObject bulletClone = Instantiate(bullet, startPos.position, startPos.rotation);
            Destroy(bulletClone, 1);

            currentShots++; // sumamos disparo
        }
    }
}