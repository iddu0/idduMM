using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace idduMM.Mods
{
    internal class NoClip
    {
        public static void NoClipM() 
        {
            bool disableColliders = ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f;
            MeshCollider[] colliders = Resources.FindObjectsOfTypeAll<MeshCollider>();

            foreach (MeshCollider collider in colliders)
            {
                collider.enabled = !disableColliders;
            }
        }
    }
}
