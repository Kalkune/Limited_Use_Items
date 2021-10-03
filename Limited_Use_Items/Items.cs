using RoR2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Limited_Use_Items
{
    class Items : Limited_Use_Items
    {
        public static void Init()
        {
            Counter = ScriptableObject.CreateInstance<BuffDef>();
            Counter.name = "COUNTER";
            for (int i = 0; i < masterlisttimeditems2.Length; i++)
            {
                masterlisttimeditems2[i] = ScriptableObject.CreateInstance<ItemDef>();
                masterlisttimeditems2[i].name = masterlisttimedstring2[i];
                masterlisttimeditems2[i].nameToken = masterlisttimedstring2[i];
                masterlisttimeditems2[i].pickupToken = masterlisttimedstring2[i];
                masterlisttimeditems2[i].descriptionToken = masterlisttimedstring2[i];
                masterlisttimeditems2[i].loreToken = masterlisttimedstring2[i];
                masterlisttimeditems2[i].tier = ItemTier.NoTier;
                masterlisttimeditems2[i].hidden = true;
            }
            for (int i = 0; i < masterlistlimiteditems2.Length; i++)
            {
                masterlistlimiteditems2[i] = ScriptableObject.CreateInstance<ItemDef>();
                masterlistlimiteditems2[i].name = masterlistlimitedstring2[i];
                masterlistlimiteditems2[i].nameToken = masterlistlimitedstring2[i];
                masterlistlimiteditems2[i].pickupToken = masterlistlimitedstring2[i];
                masterlistlimiteditems2[i].descriptionToken = masterlistlimitedstring2[i];
                masterlistlimiteditems2[i].loreToken = masterlistlimitedstring2[i];
                masterlistlimiteditems2[i].tier = ItemTier.NoTier;
                masterlistlimiteditems2[i].hidden = true;
            }
        }
    }
}
