using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class TimelineRef
{
	private enum LoadState
	{
		NotLoaded,
		Loading,
		Loaded
	}

	public enum LoadOptions
	{
		None,
		UseManifest
	}

	private sealed class _003CLoad_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TLD_TimelineDirector director;

		public TimelineRef _003C_003E4__this;

		public Action onTimeLineLoadFailed;

		public LoadOptions options;

		public Action onTimeLineLoadDone;

		private string _003CtimelineFilenameNoExt_003E5__2;

		private string _003CassetBundleFilename_003E5__3;

		private AssetBundleRefRequest _003Crequest_003E5__4;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[DebuggerHidden]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CLoad_003Ed__17(int _003C_003E1__state)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[CallsUnknownMethods(Count = 28)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
		[Calls(Type = typeof(TimelineRef), Member = "LoadComplete")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(TimelineManifest), Member = "TryGetEntry")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private AssetBundleRef m_AssetBundle;

	private TimelineAsset m_LoadedTimeline;

	public string m_AssetPath;

	private LoadState m_LoadState;

	private string m_LoadedAssetBundleFileName;

	private string m_LoadedAssetPath;

	private TLD_TimelineDirector m_Director;

	public static readonly List<TLD_TimelineDirector.BindingInfo> NO_BINDING_OVERRIDE;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_PlayTimeline), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(TimelineRef), Member = "PlayTimelineForPlayer")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Update")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnTimelineLoaded")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	public void PlayTimeline(Action onTimelineStop, List<TLD_TimelineDirector.BindingInfo> bindingOverrides, bool isPlayerTimeline, DirectorWrapMode wrapMode = DirectorWrapMode.None)
	{
	}

	[Calls(Type = typeof(TimelineRef), Member = "PlayTimeline")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PlayTimelineForPlayer()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Interrupt")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StopTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Cleanup")]
	[CallsUnknownMethods(Count = 3)]
	public void StopTimeline()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimelineRef), Member = "IsLoaded")]
	[CallsUnknownMethods(Count = 1)]
	public double GetDuration()
	{
		return default(double);
	}

	[CalledBy(Type = typeof(_003CLoad_003Ed__17), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void LoadComplete(TimelineAsset timelineAsset, Action onTimeLineLoadDone, string assetBundleFilename, string timelineFilenameNoExt)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void LoadFailed(Action onTimeLineLoadFailed)
	{
	}

	[CallerCount(Count = 0)]
	public string GetLoadedAssetBundleName()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "LoadTimeline")]
	[CalledBy(Type = typeof(TimelineRef), Member = "LoadForPlayerDirector")]
	[CalledBy(Type = typeof(LoadTimelineTrigger), Member = "OnTriggerEnter")]
	public IEnumerator Load(TLD_TimelineDirector director, Action onTimeLineLoadDone, Action onTimeLineLoadFailed, LoadOptions options)
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_LoadTimeline), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_timeline")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_PlayTimeline), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyPlayTimeline")]
	[Calls(Type = typeof(TimelineRef), Member = "Load")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	public IEnumerator LoadForPlayerDirector(Action onTimeLineLoadDone, Action onTimeLineLoadFailed, LoadOptions options)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
	public TimelineAsset GetLoadedTimeline()
	{
		return null;
	}

	[CalledBy(Type = typeof(TimelineRef), Member = "GetDuration")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "LoadTimeline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool IsLoaded()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	[CalledBy(Type = typeof(Action_PlayTimeline), Member = "OnLoadFailed")]
	[CalledBy(Type = typeof(Action_PlayTimeline), Member = "OnTimelineStopped")]
	[CalledBy(Type = typeof(Action_PlayTimeline), Member = "OnActionComplete")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Cleanup")]
	[CalledBy(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	[CalledBy(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	[CalledBy(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	[CalledBy(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	[CalledBy(Type = typeof(Action_UnloadTimeline), Member = "OnExecute")]
	[CalledBy(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(Elevator), Member = "UnloadTimeline")]
	[CalledBy(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	public void Unload()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void AbortLoad()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public TimelineRef()
	{
	}
}
