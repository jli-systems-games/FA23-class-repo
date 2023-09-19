using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GunAnim : MonoBehaviour
{
    [SerializeField] public Animator m_Animator = null;

    void Start()
    {

    }

    void Update()
    {


        if (Input.GetKey(KeyCode.Mouse1))
        {
            m_Animator.Play("Armature|Fire");
        }

        if (Input.GetKey(KeyCode.R))
        {
            m_Animator.Play("Armature|PriorToReload");
            m_Animator.Play("Armature|ReloadOne");
            m_Animator.Play("Armature|Weild");
        }

        else
    {
                    m_Animator.Play("ShotgunIdle");
                }

    }
}
