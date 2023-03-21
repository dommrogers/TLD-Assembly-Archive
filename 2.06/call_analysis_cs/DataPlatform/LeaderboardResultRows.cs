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
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CGetEnumerator_003Ed__1(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LeaderboardResultPlugin), Member = "LeaderboardResult_GetRow")]
		[Calls(Type = typeof(LeaderboardResultRow), Member = ".ctor")]
		[CallsUnknownMethods(Count = 11)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public uint Length;

	private LeaderboardResultRow[] m_Rows;

	private IntPtr m_Self;

	public LeaderboardResultRow Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LeaderboardResultPlugin), Member = "LeaderboardResult_GetRow")]
		[Calls(Type = typeof(LeaderboardResultRow), Member = ".ctor")]
		[CallsUnknownMethods(Count = 11)]
		get
		{
			return null;
		}
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__1))]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public IEnumerator<LeaderboardResultRow> GetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public LeaderboardResultRows(uint numRows, IntPtr self)
	{
	}
}
