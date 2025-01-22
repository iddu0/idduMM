using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Viveport;

namespace idduMM.Mods
{
    internal class RightGripFly
    {
        public static void RightGripFlyM()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.Player.Instance.transform.position += (GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
}
