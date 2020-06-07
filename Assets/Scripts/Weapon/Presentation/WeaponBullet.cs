using ExtenjectMultiSceneSample.Weapon.Application;
using UnityEngine;
using Zenject;

namespace ExtenjectMultiSceneSample.Weapon.Presentation
{
    public interface IWeaponBullet
    {
        void Fire(float power);
    }

    [RequireComponent(typeof(Rigidbody))]
    public class WeaponBullet : MonoBehaviour, IWeaponBullet
    {
        [Inject] private WeaponService _weaponService = null;
        private Rigidbody _rb = null;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        public void Fire(float power)
        {
            _rb = GetComponent<Rigidbody>();
            _rb.velocity = transform.forward.normalized * power;
        }
    }
}