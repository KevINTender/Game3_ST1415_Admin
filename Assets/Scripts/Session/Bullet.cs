using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Bullet : MonoBehaviour
{
    [SerializeField] private BulletInfo info;
    private Rigidbody rb;
    private PhotonView pv;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        pv = GetComponent<PhotonView>();
        info.render = gameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!pv.IsMine) return;

        if (other.TryGetComponent(out PlayerSettings ps))
        {
            ps.TakeDamage(info.damage);
            PhotonNetwork.Destroy(gameObject);
        }
    }
    public void StartMove(Vector3 dir)
    {
        rb.velocity = dir * info.speed;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}