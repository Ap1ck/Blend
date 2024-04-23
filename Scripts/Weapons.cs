using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    [SerializeField] private GameObject[] _weapons;
    private int currentWeaponIndex = 0;

    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll > 0f)
        {
            SelectPreviousWeapon();
        }
        else if (scroll < 0f)
        {
            SelectNextWeapon();
        }
    }

    void SelectPreviousWeapon()
    {
        currentWeaponIndex = (currentWeaponIndex - 1 + _weapons.Length) % _weapons.Length;
        SelectWeapon(currentWeaponIndex);
    }

    void SelectNextWeapon()
    {
        currentWeaponIndex = (currentWeaponIndex + 1) % _weapons.Length;
        SelectWeapon(currentWeaponIndex);
    }

    void SelectWeapon(int weaponIndex)
    {
        for (int i = 0; i < _weapons.Length; i++)
        {
            _weapons[i].SetActive(i == weaponIndex);
        }
    }
}
