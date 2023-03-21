using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace DataPlatform;

public class LeaderboardResultRow : IEnumerable<string>, IEnumerable
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public LeaderboardResultRow _003C_003E4__this;

		public int i;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LeaderboardResultPlugin), Member = "LeaderboardResult_LeaderboardRow_Value")]
		internal IntPtr _003Cget_Item_003Eb__0()
		{
			return default(IntPtr);
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public int i;

		public LeaderboardResultRow _003C_003E4__this;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LeaderboardResultPlugin), Member = "LeaderboardResult_LeaderboardRow_Value")]
		[CallsUnknownMethods(Count = 1)]
		internal IntPtr _003CGetEnumerator_003Eb__0()
		{
			return default(IntPtr);
		}
	}

	private sealed class _003CGetEnumerator_003Ed__7 : IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		public LeaderboardResultRow _003C_003E4__this;

		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

		private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
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

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CGetEnumerator_003Ed__7(int _003C_003E1__state)
		{
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 24)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
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

	private IntPtr m_Self;

	private string m_Gamertag;

	private string m_Xuid;

	private string[] m_Values;

	public string Gamertag
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string Xuid
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 18)]
		get
		{
			return null;
		}
	}

	public uint Rank
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public double Percentile
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(double);
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(LeaderboardResultRow), Member = "System.Collections.IEnumerable.GetEnumerator")]
	[CallerCount(Count = 1)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	public IEnumerator<string> GetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardResultRow), Member = "GetEnumerator")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CalledBy(Type = typeof(LeaderboardResultRows._003CGetEnumerator_003Ed__1), Member = "MoveNext")]
	[CalledBy(Type = typeof(LeaderboardResultRows), Member = "get_Item")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public LeaderboardResultRow(IntPtr self)
	{
	}
}
