using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    [SerializeField] private float speed;

    public GameObject Bomba;

    public Transform aim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CrearBomba();
        }


    }

    public void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x,0,y) * speed * Time.deltaTime;
    }

    public void CrearBomba()
    {
        Instantiate(Bomba, aim.position, Quaternion.identity);
    }

}
