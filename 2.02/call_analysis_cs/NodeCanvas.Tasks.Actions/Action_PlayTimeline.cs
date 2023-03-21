using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayTimeline : ActionTask
{
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

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
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
			[CallsDeduplicatedMethods(Count = 1)]
			get
			{
				return null;
			}
		}

		[CallsUnknownMethods(Count = 30)]
		[Calls(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
		[Calls(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
		[Calls(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
		[Calls(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
		[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
		[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
		[Calls(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
		[Calls(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
		protected override void OnExecute()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ActionTask), Member = "EndAction")]
		[CallsUnknownMethods(Count = 2)]
		protected override void OnUpdate()
		{
		}

		[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "OnExecute")]
		[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_cinematicproperty")]
		[CallerCount(Count = 7)]
		[CallAnalysisFailed]
		public static void SetProperty(CinematicPropertyType type, bool isSet, int argValue)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public Action_SetCinematicProperties()
		{
		}
	}

	public List<TLD_TimelineDirector.BindingInfo> bindingOverrides;

	public bool skipDisableCrouch;

	public bool forceQuitOtherScreens;

	public bool unloadAfterPlay;

	public TimelineRef timelineRef;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(TimelineRef), Member = "LoadForPlayerDirector")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 19)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(TimelineRef), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnLoadComplete()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTimelineStopped()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	private void OnLoadFailed()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnActionComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public Action_PlayTimeline()
	{
	}
}
