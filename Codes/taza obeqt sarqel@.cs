using UnityEngine;

public class CreateObjects : MonoBehaviour
{

    public GameObject[] obj;

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            //GameObject newObject = Instantiate(obj, new Vector3(0, 5, 0), Quaternion.Euler(12f, -15, 40f)) as GameObject;
            //newObject.GetComponent<Transform>.position = new Vector3(5, 5, 0);
            //obeqtner sarqel@ srqeluc ogtagorcvuma  Instantiate metod@ unenuma 3 parametr
            //henc in! obeqt@ es depqum obj n vor@ vor masiva 
            //posician votrex vor lineluya u tequtyun@ te inch ankyan taka haytnvelu
            Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), -15, 40f));
        }
    }
        //kanchum enq taza funkcia vor@ vor talisa randomni tiv vor amen angam taza sarqac obeqt@ taza tex haytnvi
    private int RandomNumber()
    {
        return Random.Range(0, 10);
    }

}





