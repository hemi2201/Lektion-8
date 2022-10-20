using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallWithCharacterController : MonoBehaviour
{
    private CharacterController cc;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float gravityConstant;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        direction.y = direction.y * gravityConstant * Time.deltaTime;
        
        cc.Move(direction * speed * Time.deltaTime);
    }
}
