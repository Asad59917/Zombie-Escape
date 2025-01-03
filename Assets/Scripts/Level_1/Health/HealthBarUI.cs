using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarUI : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image HealthBarForegroundImage;
    public void HealthBarUpdate(HealthController healthController)
    {
        HealthBarForegroundImage.fillAmount = healthController.ReamainingHealthPercentage;
    }
}
