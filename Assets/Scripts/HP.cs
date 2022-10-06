using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Image healthBarImage;
    public PlayerCode player;

    public void UpdateHealthBar()
    {
        healthBarImage.fillAmount = Mathf.Clamp(player.health / player.maxHealth, 0, 1f);
    }
}
