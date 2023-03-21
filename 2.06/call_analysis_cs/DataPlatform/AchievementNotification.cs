using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace DataPlatform;

public class AchievementNotification : IEnumerable<string>, IEnumerable
{
	private sealed class _003CGetEnumerator_003Ed__9 : IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		public AchievementNotification _003C_003E4__this;

		private int _003Clen_003E5__2;

		private int _003Ci_003E5__3;

		private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[DebuggerHidden]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CGetEnumerator_003Ed__9(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(AchievementUnlockedEventArgs), Member = "get_InAppRewardValue")]
		[Calls(Type = typeof(AchievementUnlockedEventArgs), Member = "get_InAppRewardValue")]
		[CallsUnknownMethods(Count = 3)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private AchievementUnlockedEventArgs m_Data;

	public int UserId
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(int);
		}
	}

	public string AchievementId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public int Length
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AchievementUnlockedEventArgs), Member = "get_InAppRewardValue")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public string Item
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(AchievementUnlockedEventArgs), Member = "get_InAppRewardValue")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__9))]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public IEnumerator<string> GetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 265)]
	public AchievementNotification(AchievementUnlockedEventArgs args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
