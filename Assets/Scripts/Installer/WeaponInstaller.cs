using ExtenjectMultiSceneSample.Weapon.Application;
using ExtenjectMultiSceneSample.Weapon.Domain;
using ExtenjectMultiSceneSample.Weapon.Infrastructure;
using ExtenjectMultiSceneSample.Weapon.Scriptable;
using UnityEngine;
using Zenject;

namespace ExtenjectMultiSceneSample.Weapon.Installer
{
    public class WeaponInstaller : MonoInstaller
    {
        [SerializeField] private WeaponScriptable _weaponScriptable = null;

        public override void InstallBindings()
        {
            Container
                .Bind<IWeaponScriptable>()
                .FromInstance(_weaponScriptable);

            Container
                .Bind<IWeaponTypeManager>()
                .To<WeaponTypeManager>()
                .AsCached();

            Container
                .Bind<WeaponService>()
                .AsCached();
        }
    }
}