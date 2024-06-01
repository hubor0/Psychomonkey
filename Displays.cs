using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using UnityEngine;
using static Il2CppAssets.Scripts.Simulation.SMath.Vector3;
using MelonLoader.Utils;
using psychomonkey;
using BTD_Mod_Helper.Extensions;

namespace Displays;

public class Displays
{
    public class tower
    {
        public class basedisplay : ModCustomDisplay
        {
            public override string AssetBundleName => "psycho222"; 
            public override string PrefabName => "psycho00023"; 

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 72;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(67 / 255f, 37 / 255f, 42 / 255f));
                }
            }
        }
        public class display100 : ModCustomDisplay
        {
            public override string AssetBundleName => "psychot2";
            public override string PrefabName => "ps100";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 72;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(67 / 255f, 37 / 255f, 42 / 255f));
                }
            }
        }
        public class display200 : ModCustomDisplay
        {
            public override string AssetBundleName => "psychot2";
            public override string PrefabName => "ps200";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 72;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(67 / 255f, 37 / 255f, 42 / 255f));
                }
            }
        }
        public class display010 : ModCustomDisplay
        {
            public override string AssetBundleName => "psychot2";
            public override string PrefabName => "ps010";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 72;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(67 / 255f, 37 / 255f, 42 / 255f));
                }
            }
        }
        public class display020 : ModCustomDisplay
        {
            public override string AssetBundleName => "psychot2";
            public override string PrefabName => "ps020";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 72;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(67 / 255f, 37 / 255f, 42 / 255f));
                }
            }
        }
        public class display001 : ModCustomDisplay
        {
            public override string AssetBundleName => "psychot2";
            public override string PrefabName => "ps001";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 72;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(67 / 255f, 37 / 255f, 42 / 255f));
                }
            }
        }
        public class display002 : ModCustomDisplay
        {
            public override string AssetBundleName => "psychot2";
            public override string PrefabName => "ps002";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 72;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(67 / 255f, 37 / 255f, 42 / 255f));
                }
            }
        }

        public class display300 : ModCustomDisplay
        {
            public override string AssetBundleName => "psycho222"; 
            public override string PrefabName => "300"; 

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 70;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(67 / 255f, 37 / 255f, 42 / 255f));
                }
            }
        }
        public class display400 : ModCustomDisplay
        {
            public override string AssetBundleName => "psycho222";
            public override string PrefabName => "ps400";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 70;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(48 / 255f, 21 / 255f, 66 / 255f));
                }
            }
        }
        public class display500 : ModCustomDisplay
        {
            public override string AssetBundleName => "psycho222";
            public override string PrefabName => "ps500";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 69;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(48 / 255f, 21 / 255f, 66 / 255f));
                }
            }
        }
        public class display030 : ModCustomDisplay
        {
            public override string AssetBundleName => "psycho222";
            public override string PrefabName => "ps030"; 

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 72;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(73 / 255f, 36 / 255f, 14 / 255f));
                }
            }
        }
        public class display040 : ModCustomDisplay
        {
            public override string AssetBundleName => "psycho222"; 
            public override string PrefabName => "ps040"; 

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 72;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(73 / 255f, 36 / 255f, 14 / 255f));
                }
            }
        }
        public class display050 : ModCustomDisplay
        {
            public override string AssetBundleName => "psycho222";
            public override string PrefabName => "ps050";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 74;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(73 / 255f, 36 / 255f, 14 / 255f));
                }
            }
        }
        public class display003 : ModCustomDisplay
        {
            public override string AssetBundleName => "psychobotpath";
            public override string PrefabName => "ps003";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 73;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(73 / 255f, 36 / 255f, 14 / 255f));
                }
            }
        }
        public class display004 : ModCustomDisplay
        {
            public override string AssetBundleName => "psychobotpath";
            public override string PrefabName => "ps004";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 78;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(73 / 255f, 36 / 255f, 14 / 255f));
                }
            }
        }
        public class display005 : ModCustomDisplay
        {
            public override string AssetBundleName => "psychobotpath";
            public override string PrefabName => "ps005";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 80;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(73 / 255f, 36 / 255f, 14 / 255f));
                }
            }
        }
        public class display005g : ModCustomDisplay
        {
            public override string AssetBundleName => "psychobotpath";
            public override string PrefabName => "golem";

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.GetChild(0).transform.localScale *= 166;
                foreach (var meshRenderer in node.GetMeshRenderers())
                {
                    meshRenderer.ApplyOutlineShader();

                    meshRenderer.SetOutlineColor(new Color(39 / 255f, 33 / 255f, 30 / 255f));
                }
            }
        }







    }
}