using ExtenjectMultiSceneSample.Weapon.Application;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using Zenject;

namespace ExtenjectMultiSceneSample.Weapon.Presentation
{
    public class WeaponShooter : MonoBehaviour
    {
        [Inject] private WeaponService _weaponService = null;
        [Inject] private DiContainer _diContainer = null;

        private void Start()
        {
            this.UpdateAsObservable()
                .Where(_ => Input.GetMouseButtonDown(0))
                .Subscribe(_ =>
                {
                    Shoot();
                });
        }

        private void Shoot()
        {
            GameObject bulletObj = _diContainer.InstantiatePrefab(
                _weaponService.SelectedWeaponProperty.Prefab,
                transform);

            IWeaponBullet bulletController = bulletObj.GetComponent<IWeaponBullet>();
            bulletController.Fire(_weaponService.SelectedWeaponProperty.Power);
        }
    }
}