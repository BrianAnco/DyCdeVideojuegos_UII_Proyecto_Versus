using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class RedesDeJugador : MonoBehaviour
{
    //Array de códigos generados, para no controlarlos.
    public MonoBehaviour[] ignoreCodes;

    //Component de PhotonView.
    private PhotonView photonView;

    // Start is called before the first frame update
    void Start()
    {
        //Le damos los atributos de PhotonView del personaje.
        photonView = GetComponent<PhotonView>();
        
        
		if (!photonView.IsMine)
		{
            foreach(var codigo in ignoreCodes)
			{
                codigo.enabled = false;
			}
		}

    }

    // Update is called once per frame
    void Update()
    {
    }
}
