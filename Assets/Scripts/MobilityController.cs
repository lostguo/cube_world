using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilityController : MonoBehaviour
{

    public float walkSpeed = 3.0f;

    public CharacterController MainCubeCharacterController = null;

    // Start is called before the first frame update
    void Start()
    {
        MainCubeCharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveDir = transform.right * h + transform.forward * v;
        MainCubeCharacterController.Move(moveDir * walkSpeed * Time.deltaTime);
    }

}
