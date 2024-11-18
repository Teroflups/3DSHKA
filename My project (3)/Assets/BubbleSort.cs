using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    [SerializeField] Transform[] cubes;
    void Start()
    {
        Sort(cubes);
    }
    private void Sort(Transform[] cubes)
    {
        Transform temp;
        for (int i = 0; i < cubes.Length; i++)
        {
            for (int j = i + 1; j < cubes.Length; j++)
            {
                if(cubes[i].localScale.magnitude < cubes[j].localScale.magnitude)
                {
                    temp = cubes[i];
                    cubes[i] = cubes[j];
                    cubes[j] = temp;
                }
            }
        }
        for(int i = 0;i < cubes.Length; i++)
        {
            cubes[i].transform.position = new Vector3(i * 2, 0, 0);
        }
    }
}
