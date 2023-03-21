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

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
		[Calls(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
		[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
		[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 30)]
		protected override void OnExecute()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActionTask), Member = "EndAction")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		protected override void OnUpdate()
		{
		}

		[CallAnalysisFailed]
		[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_cinematicproperty")]
		[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "OnExecute")]
		[CallerCount(Count = 7)]
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
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(TimelineRef), Member = "LoadForPlayerDirector")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelineRef), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	private void OnActionComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public Action_PlayTimeline()
	{
	}
}
