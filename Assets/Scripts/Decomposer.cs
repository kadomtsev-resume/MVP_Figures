using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decomposer : MonoBehaviour
{
    // ### Decomposer ### // This script decompose our figures, like in "Transformers" movie :D
    private float x, y, z;
    private int i = 0;

    public void Decompose(GameObject decobj)    //decomposing the figure
    {
        if (decobj.transform.childCount != 0)
        {
            //Debug.Log(decobj.transform.childCount);

            foreach (Transform child in transform)
            {
                //Debug.Log(child.position);

                x = child.transform.position.x; //получаем координаты дочернего объекта
                y = child.transform.position.y;
                z = child.transform.position.z;

                child.transform.position = new Vector3(x * 1.5f, y * 1.5f, z * 1.5f); // умножаем координаты дочернего объекта на коэффициенты, объект сдвигается по своему вектору
                i += 1; // счетчик сколько раз мы сделали декомпозицию
            }
        }
        else
            Debug.Log("Nothing to decompose");
    }

    public void ComposeBack(GameObject decobj) // Compose figure back
    {
        if (i > 0)
        {
            //Debug.Log(decobj.transform.childCount);

            foreach (Transform child in transform)
            {
                //Debug.Log(child.position);

                x = child.transform.position.x;
                y = child.transform.position.y;
                z = child.transform.position.z;

                child.transform.position = new Vector3(x / 1.5f, y / 1.5f, z / 1.5f); // делим координаты, объект сдвиагется обратно к центру
                i -= 1;
            }
        }
        else
            Debug.Log("Nothing to compose");
    }

    public void ResetCompose(GameObject decobj)     //resetting the decompose of figure
    {
        for (int p=i; p>0; p--)
        {
            ComposeBack(decobj);
        }
    }

    // ### END OF DECOMPOSER ### 
}
