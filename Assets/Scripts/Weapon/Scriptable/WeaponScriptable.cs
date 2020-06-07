using ExtenjectMultiSceneSample.Weapon.Domain;
using System.Collections.Generic;
using UnityEngine;

namespace ExtenjectMultiSceneSample.Weapon.Scriptable
{
    [CreateAssetMenu(menuName = "ScriptableObject/WeaponScriptable")]
    public class WeaponScriptable : ScriptableObject, IWeaponScriptable
    {
        [SerializeField] private List<WeaponProperty> _weaponPropertyList = new List<WeaponProperty>();

        public List<WeaponProperty> WeaponPropertyList => _weaponPropertyList;

        public WeaponProperty FindPropertyByType(WeaponType type)
        {
            return _weaponPropertyList.Find(data => data.Type == type);
        }
    }
}