using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetCinematicProperties : ActionTask
{
	public enum CinematicPropertyType
	{
		Invulnerable,
		LockPlayer,
		PreventRadialUse,
		PassesTime,
		HidesHUD,
		HidesGameplayUIEffects,
		StowItems,
		DisableDiscoveryText,
		ForceWildlifeToFlee,
		SuspendPlayerConditionUpdate,
		DisableAllSystemSpeech,
		BoostAurora
	}

	public enum LockPlayerType
	{
		All,
		MovementOnly,
		Unlocked
	}

	[Serializable]
	public class Properties
	{
		public bool invulnerable;

		public bool lockPlayer;

		public LockPlayerType lockingType;

		public bool preventRadialUse;

		public bool passesTime;

		public int timePassedHours;

		public bool hidesHUD;

		public bool hidesGameplayUIEffects;

		public bool stowItems;

		public bool disableDiscoveryText;

		public bool forceWildlifeToFlee;

		public bool suspendPlayerConditionUpdate;

		public bool disableAllSystemSpeech;

		public bool boostAurora;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public Properties()
		{
		}
	}

	public bool setState;

	public Properties properties;

	private static Rest.PassTimeHelper s_PassTimeHelper;

	protected override string info
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
	[Calls(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_cinematicproperty")]
	[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "OnExecute")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	public static void SetProperty(CinematicPropertyType type, bool isSet, int argValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryGetPanel<T>(out T panel) where T : Panel_Base
	{
		panel = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetCinematicProperties()
	{
	}
}
