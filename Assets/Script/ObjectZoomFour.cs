using UnityEngine;
using System.Collections;

public class ObjectZoomFour : MonoBehaviour, IZoomableFour
{
    public float ZoomRatio = .5f;

    public void ZoomFour(DisplayImageFour currentDisplay)
    {
        Camera.main.orthographicSize *= ZoomRatio;
        Camera.main.transform.position = new Vector3(this.transform.position.x, this.transform.position.y,
            Camera.main.transform.position.z);

        gameObject.layer = 2;
        currentDisplay.CurrentState = DisplayImageFour.State.zoom;
    }
}