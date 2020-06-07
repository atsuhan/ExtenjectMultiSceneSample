using System;
using System.Collections.Generic;
using UnityEngine;

namespace ExtenjectMultiSceneSample.Weapon.Domain
{
    public enum WeaponType
    {
        Sphere,
        Cube,
        Capsule
    }

    [Serializable]
    public struct WeaponProperty
    {
        public WeaponType Type;
        public GameObject Prefab;
        public float Power;
    }

    public interface IWeaponScriptable
    {
        List<WeaponProperty> WeaponPropertyList { get; }
        WeaponProperty FindPropertyByType(WeaponType type);
    }

    public interface IWeaponTypeManager
    {
        WeaponType SelectedWeaponType { get; }
        void SelectWeaponType(WeaponType weaponType);
    }
}