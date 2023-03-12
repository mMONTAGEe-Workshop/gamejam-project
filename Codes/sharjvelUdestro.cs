
using UnityEngine;

public class Basics : MonoBehaviour
{

    public GameObject[] objects = new GameObject[3];
    public Transform target;
    public Light _light;
    public Transform[] transforms = new Transform[3];
    public float speed = 5.0f, RotateSpeed = 10.0f;
    private void Start()


    {
        //obj.SetActive(false);
        //obj.GetComponent<Transform>().position = new Vector3(5, 0, 9);
        //_light.intensity = 0.5f;
        //for(int i = 0; i <objects.Length; i++)
        //    objects[i].SetActive(false);
    }


    private void Update()
    {
        // cikl@ sksec 
        for (int i = 0; i < transforms.Length; i++)
        {     // asum enq vor inchvor obeqt transforms masivi mej chi gtnum
              //kod@ chi kangnum
            if (transforms[i] == null)
                continue;
            //vector 3i mej x y z kordinatnernen bazmapatkac speed-ov 
            //u bazmapatkac Time.deltaTime vornel nenca anum vor sharjumner@ plavni linen
            //Translate n patasxanuma inxhvor uxutyunov sharjveku hamar
            //isk Rotate n inchvor kom pttvelu hamar
            transforms[i].Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            transforms[i].Rotate(new Vector3(1, 0, 0) * RotateSpeed * Time.deltaTime);
            //vercnum enq taa peremenni voric heto obeqt@ jnjveluya 
            float posX = transforms[i].position.x;
            // nenc enq anum vo -10 kordinatic heto gameObject@ vori anun@ cuba
            //(dra tex@ kara luboy ban lini uxaki anun@ petqa hamapatasxani)
            //destroyv jnjvuma 
            if (posX < -10.0f && transforms[i].gameObject.name == "Cube")
                Destroy(transforms[i].gameObject);


        }

    }

}

;-----