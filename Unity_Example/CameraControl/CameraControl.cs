using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Camera))]
public class CameraControl : MonoBehaviour {

    [SerializeField]
    float distance = 10f;
    [SerializeField]
    float height = 5f;
    [SerializeField]
    float heightDamping = 2f;
    [SerializeField]
    float rotationDamping = 0f;

    public GameObject targetCharacter;

    void LateUpdate()
    {
        if (targetCharacter == null)
        {
            targetCharacter = GameObject.FindWithTag("Player");
        }
        else
        {
            // 최종 카메라의 회전 각도
            // 최종 카메라의 높이
            float targetRotationAngle = targetCharacter.transform.eulerAngles.y;
            float targetHeight = targetCharacter.transform.position.y + height;

            // 현재 카메라의 회전 각도
            // 현재 카메라의 높이            
            float currentRotationAngle = transform.eulerAngles.y;
            float currentHeight = transform.position.y;

            // 현재 카메라 각 계산
            currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, targetRotationAngle, rotationDamping * Time.deltaTime);
            currentHeight = Mathf.Lerp(currentHeight, targetHeight, heightDamping * Time.deltaTime);

            // 현재 회전 걍 계산
            Quaternion currentRotation = Quaternion.Euler(0f, currentRotationAngle, 0f);

            // 플레이어의 위치
            transform.position = targetCharacter.transform.position;
            // 플레이어의 위치로 이동
            transform.position -= currentRotation * Vector3.forward * distance;
            
            // 카메라의 최종 위치
            transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
            // 최종 카메라의 방향
            transform.LookAt(targetCharacter.transform);
        }

    }	
}
