using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule_movement : MonoBehaviour
{
    public float movementSpeed = 1.0f; // ��������� �������� ��������
    public float rotationSpeed = 0.5f; // ��������� �������� ��������

    private float mouseX = 0f;
    private float mouseY = 0f;
    private Rigidbody rb;
    private GameObject mainCamera;
    private float fixedY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = GetComponent<GameObject>();
        Cursor.lockState = CursorLockMode.Locked;
        fixedY = mainCamera.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        // �������� ���� �� ����
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY += Input.GetAxis("Mouse Y") * rotationSpeed;

        // ������������ ���� ������
        mouseY = Mathf.Clamp(mouseY, -90f, 90f);

        // ������� ������
        mainCamera.transform.eulerAngles = new Vector3(-mouseY, mouseX, 0f);

        // �������� ���� �� ����������
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            verticalInput = -1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f;
        }

        // ������� ������ ��� ��������� ������
        Vector3 movement = transform.forward * verticalInput * movementSpeed + transform.right * horizontalInput * movementSpeed;
        mainCamera.transform.position = new Vector3(mainCamera.transform.position.x + movement.x, fixedY, mainCamera.transform.position.z + movement.z);
    }
}
