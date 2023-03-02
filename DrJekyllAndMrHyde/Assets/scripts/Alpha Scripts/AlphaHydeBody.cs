using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaHydeBody : MonoBehaviour
{
    [SerializeField] GameObject bloodFoundText, bloodNotFoundText;
    private void OnEnable()
    {
        if (AlphaClueManager.caneBlood == true)
        {
            bloodFoundText.SetActive(true);
            bloodNotFoundText.SetActive(false);
        }
        else
        {
            bloodFoundText.SetActive(false);
            bloodNotFoundText.SetActive(true);
        }
    }
}
