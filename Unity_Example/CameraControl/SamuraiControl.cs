using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CharacterController))]
public class SamuraiControl : MonoBehaviour {

    private Animator animator;
    private CharacterController characterController;

    [SerializeField]
    float moveSpeed = 4f;
    [SerializeField]
    float rotateSpeed = 100.0f;
    [SerializeField]
    float verticalSpeed = 0f;
    private Vector3 moveDirection = Vector3.zero;
    private CollisionFlags collisionflags;
    private float gravity = 9.8f;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
	}
	
	// 캐릭터의 동작 처리
	void Update () {

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        if (characterController.isGrounded)
        {
            bool bAttack = false;
            if (Input.GetMouseButtonDown(0))
            {
                bAttack = true;
                animator.SetBool("Attack", true);
            }
            else if (Input.GetMouseButtonUp(0))
            {                
                animator.SetBool("Attack", false);
            }

            if (Input.GetMouseButtonDown(1))
            {
                bAttack = true;
                animator.SetBool("Skill", true);
            }
            else if (Input.GetMouseButtonUp(1))
            {
                animator.SetBool("Skill", false);
            }

            if (!bAttack)
            {
                if (Input.GetKey(KeyCode.LeftShift)) {
                    animator.SetBool("Run", true);
                    moveSpeed = 10f;
                }
                else
                {
                    animator.SetBool("Run", false);
                    moveSpeed = 4f;
                }                    

                animator.SetFloat("Forward", v);
                animator.SetFloat("Turn", h);
                Move(v, h);
            }
        }
        
        BodyDirection();
        ApplyGravity();
	}

    void Move(float vertical, float horizontal)
    {
        // 카메라의 위치
        Transform camTransform = Camera.main.transform;

        // 캐릭터의 앞 방향
        Vector3 forward = camTransform.TransformDirection(Vector3.forward);
        forward = forward.normalized;
        // 캐릭터의 우측 방향
        Vector3 right = new Vector3(forward.z, 0f, -forward.x);

        // 이동 방향 벡터
        Vector3 targetVector = vertical * forward + horizontal * right;
        targetVector = targetVector.normalized;

        // 이동 방향 계산
        moveDirection = Vector3.RotateTowards(moveDirection, targetVector, rotateSpeed * Mathf.Deg2Rad * Time.deltaTime, 500f);
        moveDirection = moveDirection.normalized;

        // 이동 양 계산
        Vector3 grav = new Vector3(0f, verticalSpeed, 0f);
        Vector3 movementAmount = (moveDirection * moveSpeed * Time.deltaTime) + grav;

        // 캐릭터를 이동시킨다. 캐릭터가 다른 오브젝트와 마지막으로 충돌된 부분이 어딘지 알 수 있다.
        // 캐릭터가 공중에 있는지 땅에 있는지 알 수 있다
        collisionflags = characterController.Move(movementAmount);  
        
    }

    void BodyDirection()
    {
        // 수평 속도
        Vector3 horizontalVelocity = characterController.velocity;
        horizontalVelocity.y = 0.0f;

        if (horizontalVelocity.magnitude > 0.0f)
        {
            Vector3 tr = horizontalVelocity.normalized;
            Vector3 targetVector = Vector3.Lerp(transform.forward, tr, 0.5f);
            if (targetVector != Vector3.zero)
            {
                transform.forward = targetVector;
            }
        }
    }

    void ApplyGravity()
    {
        // 캐릭터 컨트롤러의 바닥 체크 기능을 활용한다.
        if (characterController.isGrounded == true) // 땅에 있으면 수직 속도 0
        {
            verticalSpeed = 0f;
        }
        else // 땅에 닿아 있지 않으면 바닥으로 중력만큼 이동 시킴
        {
            verticalSpeed -= gravity * Time.deltaTime;
        }
    }
}
