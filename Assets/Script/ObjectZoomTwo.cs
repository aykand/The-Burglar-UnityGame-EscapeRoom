using UnityEngine;
using System.Collections;

public class ObjectZoomTwo : MonoBehaviour, IZoomableTwo
{

    public float ZoomRatio = .5f;

    public void ZoomTwo(DisplayImageTwo currentDisplay)
    {
        Camera.main.orthographicSize *= ZoomRatio;
        Camera.main.transform.position = new Vector3(this.transform.position.x, this.transform.position.y,
            Camera.main.transform.position.z);

        gameObject.layer = 2;
        currentDisplay.CurrentState = DisplayImageTwo.State.zoom;


    }


}
