using UnityEngine;

public class test : MonoBehaviour
{
    public Rigidbody rb;
    public float _brtel = 800f;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.name == "Prepiatstvie")
        {
            rb.AddForce(new Vector3(0, 1, 0) * _brtel );
        }
    
    }
    private void OnCollisionStay(Collision other) 
    {
        Debug.Log("kpav polin");   
    } 
    private void OnTriggerStay(Collider other) 
    {
        if (other.gameObject.name == "Merar") 
        {
            if (gameObject.name == "Player")
            {
                Destroy(gameObject);
            }
        }
    }
}
