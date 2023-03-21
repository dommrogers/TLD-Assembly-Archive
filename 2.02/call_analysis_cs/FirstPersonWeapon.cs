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
		[CallerCount(Count = 7)]
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

	[CalledBy(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ResetFX()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[CalledBy(Type = typeof(MatchesItem), Member = "OnIgniteCompleteCallback")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponLeftHandVisible")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponRightHandVisible")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponShoulderVisible")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "ResetFX")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void EnableRenderable(bool enabled)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	public void SpawnReloadBulletPrefab(Transform parent)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "TryGetFXObject")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool TryGetFXObject(string name, out GameObject fxGameObject)
	{
		fxGameObject = null;
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void UpdateBulletsForReload(int numToShow)
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void ShowNextLoadedBullet()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableReloadBulletInstance(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FirstPersonWeapon()
	{
	}
}
