using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    [SerializeField] Animator animator;
    [SerializeField] private Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] private float lateralSmoothSpeed = 10f; // yumuþak geçiþ hýzý
    float[] xPosition = { -0.6936f, -0.34f, 0f };
    //baþlangýç pozisyonu
    private int currentXpositionIndex = 1;
    Vector3 targetPosition;

    void Start()
    {
        targetPosition = transform.position; // baþlangýç hedefi belirleniyor
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && currentXpositionIndex> 0)
        {
            currentXpositionIndex--;
            updateLateralMove();
        }
        else if(Input.GetKeyDown(KeyCode.D) && currentXpositionIndex < 2)
        {
            currentXpositionIndex++;
            updateLateralMove();
        }

        }
    private void FixedUpdate()
    {   //ileri yönde hareket kodu
        Vector3 forwardMove = Vector3.forward * speed * Time.deltaTime;
        //yumuþk geçiþ
        Vector3 currentPosition = rb.position;
        Vector3 lateralMove = Vector3.Lerp(currentPosition, targetPosition,  Time.fixedDeltaTime *lateralSmoothSpeed);


        //ileri ve yanal hareket
        Vector3 combineMove = new Vector3(lateralMove.x, transform.position.y, rb.position.z) + forwardMove;
        rb.MovePosition(combineMove);
    }
    void updateLateralMove()
    {
        targetPosition = new Vector3(xPosition[currentXpositionIndex], transform.position.y, transform.position.z);
    }
}

