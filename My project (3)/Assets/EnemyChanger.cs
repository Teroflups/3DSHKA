using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnemyChanger : MonoBehaviour
{
    public List<Enemy> enenmis = new List<Enemy>();
    [SerializeField] TMP_InputField inputField;
    [SerializeField] private Button healthButton;
    [SerializeField] private Button lvlButton;
    [SerializeField] private Button enemyButton;
    [SerializeField] private Button reset;
    [SerializeField] private Button toBoss;

    private void Start()
    {

    }

    public void HPFilter()
    {
        float maxHP;
        if (float.TryParse(inputField.text, out maxHP))
        {
            foreach (Enemy enemy in enenmis)
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
            foreach(Enemy enemy in enenmis)
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
        foreach(Enemy enemy in enenmis)
        {
            enemy.gameObject.SetActive(true);
        }
    }

    public void ToBoss()
    {
        string nameFind = inputField.text;
        foreach(Enemy enemy in enenmis)
        {
            if(enemy.name == nameFind)
            {
                enemy.ToBossKFC();
            }
        }
    }
}
