using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;

namespace idduMM.Mods
{
    internal class GhostMonke
    {
        public static void GhostMonkeM() 
        {
            if (ControllerInputPoller.instance.leftControllerSecondaryButton || Mouse.current.rightButton.isPressed)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }

            else 
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
    }
}
