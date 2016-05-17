using UnityEngine;

public class TickleClick : MonoBehaviour {
	


	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            // Construct a ray from the current mouse coordinates
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag != "Ticklish")
                    return;
                Animator anim = hit.collider.gameObject.GetComponent<Animator>();
                anim.StartPlayback();
                //Check which object was hit and do something
            }
        }
    }
}
