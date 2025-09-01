using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolTest : PoolMgr<pooooooooooo>
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            pooooooooooo po1 = PoolMgr<pooooooooooo>.GetInstance().Get();
            po1.transform.position = new Vector3(Random.Range(0,5), Random.Range(0, 5),0);
            LeanTween.delayedCall(2, () => { PoolMgr<pooooooooooo>.GetInstance().Release(po1); });
        }
    }

}
