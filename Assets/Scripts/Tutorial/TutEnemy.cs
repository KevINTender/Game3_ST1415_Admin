using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TutEnemy : MonoBehaviour
{
    Sequence move;
    // Start is called before the first frame update
    void Start()
    {
        move?.Kill();
        move = DOTween.Sequence();
        move.Append(transform.DOMoveX(5, 1f));
        move.Append(transform.DOMoveX(0, 1f));
        move.AppendInterval(3f);
        move.AppendCallback(() => print("что дальше"));
        move.Append(transform.DOMoveX(5, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
