using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject objectToDestroy;

    // вызывается при клике на кнопку
    public void DestroyObjectOnClick()
    {
        // уничтожаем объект
        Destroy(objectToDestroy);
    }
}