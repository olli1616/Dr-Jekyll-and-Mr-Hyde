using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaHydeBody : MonoBehaviour
{
    [SerializeField] GameObject bloodFoundText, bloodNotFoundText, poisonFoundText;
    private void OnEnable()
    {
        if (AlphaClueManager.caneBlood == true)
        {
            bloodFoundText.SetActive(true);
            poisonFoundText.SetActive(false);
            bloodNotFoundText.SetActive(false);
        }
        else
        {
            bloodFoundText.SetActive(false);
            poisonFoundText.SetActive(false);
            bloodNotFoundText.SetActive(true);
        }
    }
}
