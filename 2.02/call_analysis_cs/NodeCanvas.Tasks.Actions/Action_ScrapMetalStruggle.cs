using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_ScrapMetalStruggle : ActionTask
{
	[Serializable]
	public class ConstrainedLimits
	{
		public Vector2 m_PitchLimitDegrees;

		public Vector2 m_YawLimitDegrees;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ConstrainedLimits()
		{
		}
	}

	private enum State
	{
		Intro,
		WaitForFirstClick,
		PrepareStruggle,
		Struggle,
		Outro
	}

	private int m_AnimParameter_ScrapMetalStruggle_TriggerStruggle;

	private int m_AnimParameter_ScrapMetalStruggle_Stage;

	private int m_AnimParameter_ScrapMetalStruggle_TapValue;

	public string m_KnifeIdentifier;

	private GameObject m_SpawnedProp;

	public float m_ChargePerTap;

	public float m_DischargePerSecond;

	public int m_Stages;

	private float m_TapValue;

	private int m_Stage;

	private ConstrainedLimits m_StartingConstainedLimits;

	public ConstrainedLimits m_WaitForClickConstainedLimits;

	public ConstrainedLimits m_StruggleConstainedLimits;

	private State m_State;

	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterWaitForFirstClick")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetStruggleBarFillAmount")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "MaybeFindProp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateWaitForFirstClick")]
	protected override void OnUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void UpdateIntro()
	{
	}

	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterWaitForFirstClick")]
	[CallerCount(Count = 0)]
	private void OnIntroComplete()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnIntroComplete")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnExecute")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void EnterWaitForFirstClick()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnUpdate")]
	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterPrepareStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InputManager), Member = "GetInteractPressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void UpdateWaitForFirstClick()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateWaitForFirstClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void EnterPrepareStruggle()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeDisableDummyInteraction()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void UpdatePrepareStruggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[CallsUnknownMethods(Count = 6)]
	private void OnPrepareStruggleComplete()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	private void EnterStruggle()
	{
	}

	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnUpdate")]
	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterOutro")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_HUD), Member = "SetStruggleBarFillAmount")]
	[Calls(Type = typeof(InputManager), Member = "GetStruggleTapPressed")]
	[Calls(Type = typeof(ActionTask), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void UpdateStruggle()
	{
	}

	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void EnterOutro()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void UpdateOutro()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetHipAndShoulderOffsetLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void OnOutroComplete()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnExecute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	private void MaybeFindProp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void MaybeDestroyProp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	public Action_ScrapMetalStruggle()
	{
	}
}
