using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class LeaderboardResultColumns : IEnumerable<LeaderboardResultColumn>, IEnumerable
{
	private sealed class _003CGetEnumerator_003Ed__1 : IEnumerator<LeaderboardResultColumn>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private LeaderboardResultColumn _003C_003E2__current;

		public LeaderboardResultColumns _003C_003E4__this;

		private int _003Ci_003E5__2;

		private LeaderboardResultColumn System_002ECollections_002EGeneric_002EIEnumerator_003CDataPlatform_002ELeaderboardResultColumn_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
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
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LeaderboardResultPlugin), Member = "LeaderboardResult_GetColumn")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 20)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public uint Length;

	private LeaderboardResultColumn[] m_Columns;

	private IntPtr m_Self;

	public LeaderboardResultColumn Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LeaderboardResultPlugin), Member = "LeaderboardResult_GetColumn")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 18)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(LeaderboardResultColumns), Member = "System.Collections.IEnumerable.GetEnumerator")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator<LeaderboardResultColumn> GetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardResultColumns), Member = "GetEnumerator")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LeaderboardResultColumns(uint numColumns, IntPtr self)
	{
	}
}
