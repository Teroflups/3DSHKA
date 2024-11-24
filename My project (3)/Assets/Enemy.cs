using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public int lvl;
    public string enemyName;

    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI lvlText;
    [SerializeField] private TextMeshProUGUI enemyNameText;

    private void Start()
    {
        UpdateUI();
    }

    public void Initialize(string name, int healthValue, int levelValue)
    {
        health = healthValue;
        lvl = levelValue;
        enemyName = name;
    }

    public void SetName(string newName)
    {
        enemyName = newName;
        UpdateUI();
    }
   

    public void SetHealth(float newHealth)
    {
        health = newHealth;
        UpdateUI();
    }

    public void SetLevel(int newLvl)
    {
        lvl = newLvl;
        UpdateUI();
    }

    private void UpdateUI()
    {
        enemyNameText.text = enemyName;
        healthText.text = "health " + health;
        lvlText.text = "lvl " + lvl;
    }

    public void ToBossKFC()
    {
        enemyName = "BossKFC ";
        health *= 3;
        lvl += 1;
        UpdateUI();
    }
}
