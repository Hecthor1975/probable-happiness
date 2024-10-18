using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{
    public LayerMask layer;


    public float radio;

    [SerializeField]private float force;

    [SerializeField] private float Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           Timer -= Time.deltaTime;
        if (Timer <= 0)
        {


            Collider[] colliders = Physics.OverlapSphere(transform.position, radio, layer);
            foreach (Collider collider in colliders)
            {

              Vector3 direction = (collider.transform.position - transform.position).normalized * force;
              collider.GetComponent<Rigidbody>().AddForce(direction); 



            }
            
            
            
        }
    }

    private void OnDrawGizmos()
    { 
        Gizmos.color = Color.red;

        

        Gizmos.DrawWireSphere(transform.position, radio);
    }

}
