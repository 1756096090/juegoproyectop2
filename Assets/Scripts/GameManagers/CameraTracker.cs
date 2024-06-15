using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Esta clase se encarga de contener todos los m�todos relacionados con el seguimiento de la c�mara y su movimiento.
/// </summary>
public class CameraTracker 
{

    /// <summary>
    /// Retorna el centro de la posici�n actual de la c�mara.
    /// </summary>
    /// <returns>Un Vector2 con la posici�n central de la c�mara.</returns>
    static public Vector2 GetCameraCenter()
    {
        Camera camera = Camera.main;
        return new Vector2(camera.transform.position.x / 2, camera.transform.position.y / 2);
    }
}
