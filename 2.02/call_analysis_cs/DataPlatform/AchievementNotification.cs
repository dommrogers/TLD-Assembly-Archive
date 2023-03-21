using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;

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
		public _003CGetEnumerator_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AchievementUnlockedEventArgs), Member = "get_InAppRewardValue")]
		[Calls(Type = typeof(AchievementNotification), Member = "get_Item")]
		[CallsUnknownMethods(Count = 1)]
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

	private AchievementUnlockedEventArgs m_Data;

	public int UserId
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
	}

	public string AchievementId
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AchievementUnlockedEventArgs), Member = "get_AchievementId")]
		[CallsUnknownMethods(Count = 1)]
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
			return 0;
		}
	}

	public string Item
	{
		[CalledBy(Type = typeof(_003CGetEnumerator_003Ed__9), Member = "MoveNext")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(AchievementUnlockedEventArgs), Member = "get_InAppRewardValue")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 11)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(AchievementNotification), Member = "System.Collections.IEnumerable.GetEnumerator")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator<string> GetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 103)]
	public AchievementNotification(AchievementUnlockedEventArgs args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementNotification), Member = "GetEnumerator")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
