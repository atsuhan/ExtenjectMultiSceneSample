using ExtenjectMultiSceneSample.Weapon.Scriptable;
using UnityEngine;
using Zenject;

namespace ExtenjectMultiSceneSample.Weapon.Installer
{
    [CreateAssetMenu(menuName = "Installers/WeaponScriptableInstaller")]
    public class WeaponScriptableInstaller : ScriptableObjectInstaller<WeaponScriptableInstaller>
    {
        public WeaponScriptable _weaponScriptable;

        public override void InstallBindings()
        {
            Container.BindInstance(_weaponScriptable);
        }
    }
}