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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	private void ResetFX()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponShoulderVisible")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponRightHandVisible")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponLeftHandVisible")]
	[CalledBy(Type = typeof(MatchesItem), Member = "OnIgniteCompleteCallback")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "ResetFX")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	public void EnableRenderable(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	public void SpawnReloadBulletPrefab(Transform parent)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "TryGetFXObject")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TryGetFXObject")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TryGetFXObject")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	public bool TryGetFXObject(string name, out GameObject fxGameObject)
	{
		fxGameObject = null;
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateBulletsForReload(int numToShow)
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 3)]
	public void ShowNextLoadedBullet()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CallsUnknownMethods(Count = 2)]
	public void EnableReloadBulletInstance(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FirstPersonWeapon()
	{
	}
}
