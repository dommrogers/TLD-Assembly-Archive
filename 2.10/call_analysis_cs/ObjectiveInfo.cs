using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Missions;
using UnityEngine;

public class ObjectiveInfo : MonoBehaviour
{
	private sealed class _003CGetSubObjectives_003Ed__13 : IEnumerable<ObjectiveInfo>, IEnumerable, IEnumerator<ObjectiveInfo>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ObjectiveInfo _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ObjectiveInfo _003C_003E4__this;

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
		public _003CGetSubObjectives_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[CalledBy(Type = typeof(_003CGetSubObjectives_003Ed__13), Member = "MoveNext")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
		[Calls(Type = typeof(_003CGetSubObjectives_003Ed__13), Member = "<>m__Finally1")]
		[Calls(Type = typeof(_003CGetSubObjectives_003Ed__13), Member = "System.IDisposable.Dispose")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 17)]
		private bool MoveNext()
		{
			return false;
		}

		[CalledBy(Type = typeof(_003CGetSubObjectives_003Ed__13), Member = "MoveNext")]
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

	public string m_ObjectiveID;

	public LocalizedString m_ObjectiveDescription;

	public LocalizedString m_ObjectiveDescriptionUnits;

	public LocalizedString m_ObjectiveHudDescription;

	public string m_TimerID;

	public string m_CountCurrentBBName;

	public string m_CountRequiredBBName;

	public MissionObjectiveCountType m_UnitType;

	public bool m_ShowWhenCompleted;

	public bool m_ShowSubobjectivesInSummary;

	public bool m_ShowSmallKicker;

	public bool m_IgnoreInProgressionCalculation;

	public bool m_UseAsFraction;

	[IteratorStateMachine(typeof(_003CGetSubObjectives_003Ed__13))]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "LoadMissionDataFromResources")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerable<ObjectiveInfo> GetSubObjectives()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public ObjectiveInfo()
	{
	}
}
