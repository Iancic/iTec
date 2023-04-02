using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrigger : MonoBehaviour
{
    public static SnowTrigger instance;
    public GameObject snow;
    // Start is called before the first frame update

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SnowsStart()
    {
        snow.SetActive(true);
        PlayerController.instance.moveSpeed = PlayerController.instance.moveSpeed / 2;
        PlayerController2.instance.moveSpeed = PlayerController2.instance.moveSpeed / 2;
    }
}
