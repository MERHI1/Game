using System.Collections;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public GameObject block;
    private GameObject blockInst;
    private Vector3 blockPos;
    private float speed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        blockPos = new Vector3(Random.Range(0.8f, 1.7f), Random.Range(-4f, 2f), 0f);
        blockInst = Instantiate(block,new Vector3 (5f, -6f, 0f), Quaternion.identity) as GameObject;
        blockInst.transform.localScale = new Vector3(Random.Range(1.5f, 2f), blockInst.transform.localScale.y, blockInst.transform.localScale.z);
    }

    void Update ()
    {
        if (blockInst.transform.position != blockPos)
            blockInst.transform.position = Vector3.MoveTowards(blockInst.transform.position, blockPos, Time.deltaTime * speed);
    }
}
