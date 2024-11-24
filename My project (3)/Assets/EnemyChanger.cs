using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnemyChanger : MonoBehaviour
{
    public List<Enemy> enemies = new List<Enemy>();
    [SerializeField] TMP_InputField inputField;

    private void Start()
    {
        //enemies.Add(GameObject.FindAnyObjectByType<Enemy>());
        
    }
    private void Update()
    {

    }




    public void HPFilter()
    {
        float maxHP;
        if (float.TryParse(inputField.text, out maxHP))
        {
            foreach (Enemy enemy in enemies)
            {
                if(enemy.health > maxHP)
                {
                    enemy.gameObject.SetActive(true);
                }
                else
                {
                    enemy.gameObject.SetActive(false);
                }
            }
        }
    }

    public void LVLFilter()
    {
        int maxLVL;
        if (int.TryParse(inputField.text,out maxLVL))
        {
            foreach(Enemy enemy in enemies)
            {
                if(enemy.lvl >= maxLVL)
                {
                    enemy.gameObject.SetActive(true);
                }
                else
                {
                    enemy.gameObject.SetActive(false);
                }
            }
        }
    }

    public void ResetFilter()
    {
        foreach(Enemy enemy in enemies)
        {
            enemy.gameObject.SetActive(true);
        }
    }

    public void ToBoss()
    {
        string nameFind = inputField.text;
        foreach(Enemy enemy in enemies)
        {
            if(enemy.enemyName == nameFind)
            {
                enemy.ToBossKFC();
            }
        }
    }

    public void FindEnemy()
    {
        string objFind = inputField.text;
        foreach (Enemy enemy in enemies)
        {
            if (enemy.enemyName == objFind)
            {
                enemy.SetName(objFind);
            }
        }
    }

}
