using UnityEngine;

public class F2F_BinocularController : MonoBehaviour
{


    public GameObject Binocular_Parent;

    public bool B_Active = true;

    public Camera cam;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Tab))
        {


            B_Active = !B_Active;

            if (B_Active)
            {

                Binocular_Parent.SetActive(false);
                cam.fieldOfView = 60f;

            }
            else
            {
                Binocular_Parent.SetActive(true);

            }


        }

        


    }
}
