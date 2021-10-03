using RoR2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Limited_Use_Items
{
    class Artifact : Limited_Use_Items
    {
        public static void Init()
        {
            LUIArtifact = ScriptableObject.CreateInstance<ArtifactDef>();

            LUIArtifact.descriptionToken = "All items are either timed or have limited uses";
            LUIArtifact.nameToken = "Artifact of Limited Use Items";
            LUIArtifact.smallIconSelectedSprite = Resources.Load<Sprite>("Textures/MiscIcons/texMysteryIcon");
            LUIArtifact.smallIconDeselectedSprite = Resources.Load<Sprite>("Textures/MiscIcons/texMysteryIcon");
        }
    }
}
