using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI.Generics;
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
		[CallerCount(Count = 6)]
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

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private PanelReference<Panel_HUD> m_HUD;

	private ConstrainedLimits m_StartingConstainedLimits;

	public ConstrainedLimits m_WaitForClickConstainedLimits;

	public ConstrainedLimits m_StruggleConstainedLimits;

	private State m_State;

	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterWaitForFirstClick")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_HUD), Member = "SetStruggleBarFillAmount")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "MaybeFindProp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateWaitForFirstClick")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void UpdateIntro()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterWaitForFirstClick")]
	private void OnIntroComplete()
	{
	}

	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnIntroComplete")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnExecute")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void EnterWaitForFirstClick()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnUpdate")]
	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterPrepareStruggle")]
	[Calls(Type = typeof(InputManager), Member = "GetInteractPressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void UpdateWaitForFirstClick()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateWaitForFirstClick")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void EnterPrepareStruggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void UpdatePrepareStruggle()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnPrepareStruggleComplete()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[CallsUnknownMethods(Count = 3)]
	private void EnterStruggle()
	{
	}

	[Calls(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterOutro")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnUpdate")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetStruggleBarFillAmount")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetStruggleTapPressed")]
	private void UpdateStruggle()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void EnterOutro()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void UpdateOutro()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void OnOutroComplete()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeFindProp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void MaybeDestroyProp()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public Action_ScrapMetalStruggle()
	{
	}
}
