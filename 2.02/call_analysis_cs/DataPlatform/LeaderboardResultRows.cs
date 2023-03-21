using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class LeaderboardResultRows : IEnumerable<LeaderboardResultRow>, IEnumerable
{
	private sealed class _003CGetEnumerator_003Ed__1 : IEnumerator<LeaderboardResultRow>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private LeaderboardResultRow _003C_003E2__current;

		public LeaderboardResultRows _003C_003E4__this;

		private int _003Ci_003E5__2;

		private LeaderboardResultRow System_002ECollections_002EGeneric_002EIEnumerator_003CDataPlatform_002ELeaderboardResultRow_003E_002ECurrent
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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__1(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(LeaderboardResultPlugin), Member = "LeaderboardResult_GetRow")]
		[Calls(Type = typeof(LeaderboardResultRow), Member = ".ctor")]
		[CallsUnknownMethods(Count = 20)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public uint Length;

	private LeaderboardResultRow[] m_Rows;

	private IntPtr m_Self;

	public LeaderboardResultRow Item
	{
		[Calls(Type = typeof(LeaderboardResultRow), Member = ".ctor")]
		[Calls(Type = typeof(LeaderboardResultPlugin), Member = "LeaderboardResult_GetRow")]
		[CallsUnknownMethods(Count = 18)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LeaderboardResultRows), Member = "System.Collections.IEnumerable.GetEnumerator")]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator<LeaderboardResultRow> GetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardResultRows), Member = "GetEnumerator")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LeaderboardResultRows(uint numRows, IntPtr self)
	{
	}
}
