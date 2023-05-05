using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//! citing code from https://owlcation.com/stem/How-to-fade-out-a-GameObject-in-Unity
public static class FadeObject {
    public static IEnumerator FadeOutObject(GameObject component){
        while (component.GetComponentInChildren<Renderer>().material.color.a > 0) {
            Color objectColor = component.GetComponentInChildren<Renderer>().material.color;
            float fadeAmount = objectColor.a - (5 * Time.deltaTime);
            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            component.GetComponentInChildren<Renderer>().material.color = objectColor;
            yield return null;
        }
    }   
}
