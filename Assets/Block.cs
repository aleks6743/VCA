using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Camera cam; // Камера 

    public GameObject movedObj; // объект который нужно двигать 

    public float speed;

    float widthCam; // ширина камеры   
    float lengthCam; // высота камеры
    Vector2 centrCam; // центр камеры (это ее пивот) 
    float minX, maxX;
    float minY, maxY;

    SpriteRenderer sR;
    Vector3 width;
    Vector3 length;

    private void Awake()
    {
        sR = movedObj.GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        widthCam = cam.orthographicSize * cam.aspect;
        lengthCam = cam.orthographicSize;
        centrCam = cam.transform.position;

        minX = centrCam.x - widthCam;
        maxX = centrCam.x + widthCam;

        minY = (centrCam.y - lengthCam)/2;
        maxY = (centrCam.y + lengthCam)/2;

        width = sR.bounds.extents; // получаем размеры объекта (вернее половины ширины, высоты, глубины) 
        length = sR.bounds.extents;
    }


    void Update()
    {
        float dir = Input.GetAxis("Horizontal");
        float dir1 = Input.GetAxis("Vertical");

        if (Mathf.Abs(dir) > 0)
        {
            float x = Mathf.Clamp(movedObj.transform.position.x + (dir * speed), minX + width.x, maxX - width.x);

            movedObj.transform.position = new Vector3(x, movedObj.transform.position.y, movedObj.transform.position.z);
        }

        if (Mathf.Abs(dir1) > 0)
        {
            float y = Mathf.Clamp(movedObj.transform.position.x + (dir1 * speed), minY - length.y, maxY + length.y);

            movedObj.transform.position = new Vector3(y, movedObj.transform.position.y, movedObj.transform.position.z);
        }
    }


}