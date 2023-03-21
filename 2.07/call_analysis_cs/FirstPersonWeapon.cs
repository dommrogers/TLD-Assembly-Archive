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
		[CallerCount(Count = 6)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void ResetFX()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponShoulderVisible")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponRightHandVisible")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetEquippedWeaponLeftHandVisible")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CalledBy(Type = typeof(MatchesItem), Member = "OnIgniteCompleteCallback")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "ResetFX")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	public void EnableRenderable(bool enabled)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	public void SpawnReloadBulletPrefab(Transform parent)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TryGetFXObject")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TryGetFXObject")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TryGetFXObject")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	public bool TryGetFXObject(string name, out GameObject fxGameObject)
	{
		fxGameObject = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	public void UpdateBulletsForReload(int numToShow)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CallsUnknownMethods(Count = 3)]
	public void ShowNextLoadedBullet()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	public void EnableReloadBulletInstance(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FirstPersonWeapon()
	{
	}
}
