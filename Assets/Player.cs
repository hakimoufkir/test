using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    PhotonView pView;

    // Start is called before the first frame update
    void Start()
    {
        pView = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pView.IsMine) 
        {
            Inputs();
        }
      


    }

    void Inputs() 
    {
        float xInputs = Input.GetAxisRaw("Horizontal");
        float yInputs = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(xInputs, yInputs) * speed * Time.deltaTime;
    }
}
