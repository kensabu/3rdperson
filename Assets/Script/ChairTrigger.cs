using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairTrigger : MonoBehaviour
{
    [SerializeField]
    bool _seated;
    [SerializeField]
    Vector3 _offsetPos,_offsetRot,_offsetExitPos;
    public bool _get_set_seated { get { return _seated; } set { _seated = value; } }
    public Vector3 _get_set_offsetPos { get { return _offsetPos; } set { _offsetPos = value; } }
    public Vector3 _get_set_offsetRot { get { return _offsetRot; } set { _offsetRot = value; } }
    public Vector3 _get_set__offsetExitPos { get { return _offsetExitPos; } set { _offsetExitPos = value; } }

  
}
