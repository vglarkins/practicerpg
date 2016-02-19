using UnityEngine;
using System.Collections;

public class BaseWeaponScript : BaseStatitem {  //BaseWeapon <- BaseStatitem <- BaseItem


	public enum WeaponTypes{
		SWORD,
		STAFF,
		DAGGER,
		BOW,
		SHEILD,
		POLEARM
	}
	private WeaponTypes weaponType;
	private int spellEffectID;

	public WeaponTypes WeaponType {
		get{ return weaponType;}
		set{ weaponType = value;}
	}
	public int SpellEffectID {
		get{ return spellEffectID;}
		set{ spellEffectID = value;}
	}
}
