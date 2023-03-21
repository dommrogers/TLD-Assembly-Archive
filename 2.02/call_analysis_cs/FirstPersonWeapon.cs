using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirstPersonWeapon : MonoBehaviour
{
	[Serializable]
	public class FXInfo
	{
		public string m_Name;

		public GameObject m_GameObject;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public FXInfo()
		{
		}
	}

	public Animator m_Animator;

	public FirstPersonLightSource m_LightSource;

	public GameObject m_Renderable;

	public GameObject m_BulletEmissionPoint;

	public Transform m_FrontSight;

	public Transform m_RearSight;

	public GameObject m_ReloadBulletPrefab;

	public Renderer[] m_BulletsToReload;

	public List<FXInfo> m_FXInfos;

	private GameObject m_ReloadBulletInstance;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CallsUnknownMethods(Count = 4)]
	private void ResetFX()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponShoulderVisible")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponRightHandVisible")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponLeftHandVisible")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[CalledBy(Type = typeof(MatchesItem), Member = "OnIgniteCompleteCallback")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "ResetFX")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	public void EnableRenderable(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public void SpawnReloadBulletPrefab(Transform parent)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TryGetFXObject")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TryGetFXObject")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TryGetFXObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public bool TryGetFXObject(string name, out GameObject fxGameObject)
	{
		fxGameObject = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CallsUnknownMethods(Count = 7)]
	public void UpdateBulletsForReload(int numToShow)
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public void ShowNextLoadedBullet()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CallsUnknownMethods(Count = 2)]
	public void EnableReloadBulletInstance(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public FirstPersonWeapon()
	{
	}
}
