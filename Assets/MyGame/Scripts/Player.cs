using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private float damaged;
    public float fuel;
    private float capacity = 100f;
    void Start()
    {
        fuel = capacity;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            damaged += 5;
            Destroy(collision.gameObject);
            Debug.Log(damaged);
        }
        if (collision.gameObject.name == "BarrelRed")
        {
            fuel +=25;
            Destroy(collision.gameObject);
            if (fuel >= 100)
            {
                fuel = 100;
            }
            Debug.Log(fuel);
        }
        if (collision.gameObject.name == "BarrelBlue")
        {
            capacity += 5;
            Destroy(collision.gameObject);
            if (capacity >= 100)
            {
                capacity = 100;
            }
            Debug.Log(fuel);
        }
    }


}
