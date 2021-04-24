using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    #region Variables
    #endregion

    #region unity methods

    public float movingSpeed = 10f;

    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * movingSpeed;
    }
            #endregion
}
