using ExtenjectMultiSceneSample.Weapon.Domain;

namespace ExtenjectMultiSceneSample.Weapon.Infrastructure
{
    public class WeaponTypeManager : IWeaponTypeManager
    {
        public WeaponType SelectedWeaponType { get; private set; } = WeaponType.Sphere;

        public void SelectWeaponType(WeaponType weaponType)
        {
            SelectedWeaponType = weaponType;
        }
    }
}