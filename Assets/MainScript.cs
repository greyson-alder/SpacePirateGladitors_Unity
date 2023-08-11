using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public float bulletSpeed = 1;
    public float bulletDamage = 10;
    public Element bulletElement = Element.Flame;

}

public enum Element
{
    Neutral,
    Flame,
    Shock,
    Freeze,
    Wind,
    Organic
}

public static class Extensions {
    public static Color getElementColour(this Element element) {
        switch (element) {
            case Element.Flame:
                return new Color(255 / 255.0f, 30 / 255.0f, 0 / 255.0f);
            case Element.Shock:
                return new Color(235 / 255.0f, 231 / 255.0f, 30 / 255.0f);
            case Element.Freeze:
                return new Color(30 / 255.0f, 180 / 255.0f, 235 / 255.0f);
            case Element.Wind:
                return new Color(255 / 255.0f, 255 / 255.0f, 255 / 255.0f);
            case Element.Organic:
                return new Color(27 / 255.0f, 207 / 255.0f, 33 / 255.0f);
            default:
                return new Color(120 / 255.0f, 120 / 255.0f, 120 / 255.0f);
        }
    }
}