using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private IPlayer _player;
    
    [SerializeField]
    private HealthBar healthBar;
    
    private void Awake()
    {
        IPlayer player = new Player();
        healthBar.Initialize(player);
    }
}
