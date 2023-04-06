using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Missions;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class MissionInfo : MonoBehaviour
{
	private sealed class _003CGetObjectives_003Ed__13 : IEnumerable<ObjectiveInfo>, IEnumerable, IEnumerator<ObjectiveInfo>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ObjectiveInfo _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public MissionInfo _003C_003E4__this;

		private IEnumerator _003C_003E7__wrap1;

		private ObjectiveInfo System_002ECollections_002EGeneric_002EIEnumerator_003CObjectiveInfo_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public _003CGetObjectives_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[CalledBy(Type = typeof(_003CGetObjectives_003Ed__13), Member = "MoveNext")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
		[Calls(Type = typeof(_003CGetObjectives_003Ed__13), Member = "<>m__Finally1")]
		[Calls(Type = typeof(_003CGetObjectives_003Ed__13), Member = "System.IDisposable.Dispose")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 17)]
		private bool MoveNext()
		{
			return false;
		}

		[CalledBy(Type = typeof(_003CGetObjectives_003Ed__13), Member = "MoveNext")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private IEnumerator<ObjectiveInfo> System_002ECollections_002EGeneric_002EIEnumerable_003CObjectiveInfo_003E_002EGetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	public const string Label = "MissionInfo";

	public bool m_IsSideMission;

	public LocalizedString m_MissionName;

	public LocalizedString m_MissionDescription;

	public LocalizedString m_MissionChapter;

	public string m_MissionID;

	public string m_TextureName;

	public string m_TimerID;

	public string m_NPC_ID;

	public float m_TrustDecayGracePeriodHours;

	public bool m_ShowWhenCompleted;

	public string m_Icon;

	private static AsyncOperationHandle<IList<GameObject>> s_handles;

	[IteratorStateMachine(typeof(_003CGetObjectives_003Ed__13))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerable<ObjectiveInfo> GetObjectives()
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "LoadMissionDataFromResources")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetsAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public static IList<MissionInfo> GetAllMissionInfos()
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "LoadMissionDataFromResources")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	public static void ReleaseAllMissionInfos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MissionInfo()
	{
	}
}
