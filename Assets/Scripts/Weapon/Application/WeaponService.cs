using ExtenjectMultiSceneSample.Weapon.Domain;
using Zenject;

namespace ExtenjectMultiSceneSample.Weapon.Application
{
    public class WeaponService
    {
        [Inject] private IWeaponTypeManager _weaponManager = null;
        [Inject] private IWeaponScriptable _weaponScriptable = null;

        public WeaponType SelectedWeaponType => _weaponManager.SelectedWeaponType;

        public WeaponProperty SelectedWeaponProperty => _weaponScriptable.FindPropertyByType(SelectedWeaponType);

        public void SelectWeaponType(WeaponType type)
        {
            _weaponManager.SelectWeaponType(type);
        }
    }
}