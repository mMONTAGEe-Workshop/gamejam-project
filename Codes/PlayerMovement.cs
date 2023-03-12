using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f, jumpForce = 10f;   // скорость передвижения игрока
    public Rigidbody rb;               // компонент Rigidbody игрока
    public Transform groundCheck;      // точка проверки нахождения на земле
    public LayerMask groundMask;       // маска слоя земли
    public FirstPersonCamera cam;      // ссылка на компонент камеры от первого лица
    private float _mult = 1f;

    private float horizontalMove = 0f;         // направление движения по горизонтали
    private float verticalMove = 0f;           // направление движения по вертикали
   
    public bool isGrounded;

    void OnCollisionEnter(Collision other) 
    {
        isGrounded = true;
    }

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                isGrounded = false;
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 500, 0));      
            }
        _mult = Input.GetKey(KeyCode.LeftShift) ? 2f : 1f;

          
    }

    void FixedUpdate()
    {
        // перемещаем игрока
        Vector3 moveDirection = cam.transform.forward * verticalMove + cam.transform.right * horizontalMove;
        moveDirection.y = 0f;   // игнорируем вертикальную компоненту движения
        moveDirection = moveDirection.normalized * speed * _mult;
        rb.MovePosition(transform.position + moveDirection * Time.fixedDeltaTime);
    }
}