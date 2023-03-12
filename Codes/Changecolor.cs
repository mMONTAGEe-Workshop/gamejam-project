using UnityEngine;

public class Changecolor : MonoBehaviour

{
    public Transform[] transforms = new Transform[1];

    public float speed = 10.0f;

    private MeshRenderer _mesh;


    private void Awake() 
    {
        _mesh = GetComponent<MeshRenderer>();
    }
    private void Update()
    {  
        for(int i = 0; i < transforms.Length; i++) 
        {
            if(Input.GetKeyUp(KeyCode.W))
                transforms[i].Translate(new Vector3(-10, 0, 0) * speed * Time.deltaTime );

        }


    }

}
