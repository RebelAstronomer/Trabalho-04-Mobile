using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public string parentName;
    void Start()
    {
        parentName = transform.name;
    }

    void Update()
    {
        if (PlayerMove.playerObject.transform.position.z > gameObject.transform.position.z)
        {
            StartCoroutine(DestroyClone());
        }
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(5);
        if (parentName == "Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
