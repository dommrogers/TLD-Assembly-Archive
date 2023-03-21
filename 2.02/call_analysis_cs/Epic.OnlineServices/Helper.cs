using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Epic.OnlineServices.Achievements;
using Epic.OnlineServices.Auth;
using Epic.OnlineServices.Connect;
using Epic.OnlineServices.Ecom;
using Epic.OnlineServices.Friends;
using Epic.OnlineServices.Leaderboards;
using Epic.OnlineServices.Lobby;
using Epic.OnlineServices.Logging;
using Epic.OnlineServices.Mods;
using Epic.OnlineServices.P2P;
using Epic.OnlineServices.Platform;
using Epic.OnlineServices.PlayerDataStorage;
using Epic.OnlineServices.Presence;
using Epic.OnlineServices.Sessions;
using Epic.OnlineServices.Stats;
using Epic.OnlineServices.TitleStorage;
using Epic.OnlineServices.UI;

namespace Epic.OnlineServices;

public static class Helper
{
	private class Allocation
	{
		private object _003CData_003Ek__BackingField;

		public object Data
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 52)]
			get
			{
				return null;
			}
			[CallerCount(Count = 101)]
			[DeduplicatedMethod]
			[CompilerGenerated]
			private set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		public Allocation(object data)
		{
		}
	}

	private class ArrayAllocation : Allocation
	{
		private bool _003CIsElementAllocated_003Ek__BackingField;

		public bool IsElementAllocated
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ArrayAllocation(object data, bool isElementAllocated)
			: base(null)
		{
		}
	}

	private class DelegateHolder
	{
		private Delegate _003CPublic_003Ek__BackingField;

		private Delegate _003CPrivate_003Ek__BackingField;

		private Delegate[] _003CStructDelegates_003Ek__BackingField;

		private ulong? _003CNotificationId_003Ek__BackingField;

		public Delegate Public
		{
			[CallerCount(Count = 52)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 101)]
			private set
			{
			}
		}

		public Delegate Private
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
			[CallerCount(Count = 71)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set
			{
			}
		}

		public Delegate[] StructDelegates
		{
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 41)]
			private set
			{
			}
		}

		public ulong? NotificationId
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		[CallerCount(Count = 34)]
		[DeduplicatedMethod]
		public DelegateHolder(Delegate publicDelegate, Delegate privateDelegate, Delegate[] structDelegates)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<byte, string> _003C_003E9__9_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		internal string _003CToHexString_003Eb__9_0(byte b)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public ulong notificationId;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass66_0()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal bool _003CTryRemoveCallbackByNotificationId_003Eb__0(KeyValuePair<IntPtr, DelegateHolder> pair)
		{
			return default(bool);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__95<TCallback> where TCallback : class
	{
		public static readonly _003C_003Ec__95<TCallback> _003C_003E9;

		public static Func<Delegate, bool> _003C_003E9__95_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__95()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal bool _003CTryGetStructCallback_003Eb__95_0(Delegate delegat)
		{
			return default(bool);
		}
	}

	private static Dictionary<IntPtr, Allocation> s_Allocations;

	private static Dictionary<IntPtr, DelegateHolder> s_Callbacks;

	private static Dictionary<string, DelegateHolder> s_StaticCallbacks;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetAllocationCount()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Helper), Member = "CanRemoveCallback")]
	[CalledBy(Type = typeof(HelperExtensions), Member = "IsOperationComplete")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsOperationComplete(Result result)
	{
		return default(bool);
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static extern int EOS_EResult_IsOperationComplete(Result result);

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(HelperExtensions), Member = "ToHexString")]
	[Calls(Type = typeof(string), Member = "Join")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static string ToHexString(byte[] byteArray)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet<T>(T[] source, out uint target)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref target) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 147)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet<T>(IntPtr source, out T target) where T : Handle, new()
	{
		target = null;
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static bool TryMarshalGet(int source, out bool target)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref target) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(Epic.OnlineServices.Leaderboards.DefinitionInternal), Member = "get_EndTime")]
	[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "get_UnlockTime")]
	[CalledBy(Type = typeof(UnlockedAchievement), Member = "Set")]
	[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
	[CalledBy(Type = typeof(OnAchievementsUnlockedCallbackV2InfoInternal), Member = "get_UnlockTime")]
	[CalledBy(Type = typeof(OnAchievementsUnlockedCallbackV2Info), Member = "Set")]
	[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "get_LastLoginTime")]
	[CalledBy(Type = typeof(ExternalAccountInfo), Member = "Set")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Leaderboards.DefinitionInternal), Member = "get_StartTime")]
	[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "get_UnlockTime")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Leaderboards.Definition), Member = "Set")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Stat), Member = "Set")]
	[CalledBy(Type = typeof(StatInternal), Member = "get_StartTime")]
	[CalledBy(Type = typeof(StatInternal), Member = "get_EndTime")]
	[CalledBy(Type = typeof(Stat), Member = "Set")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Leaderboards.Definition), Member = "Set")]
	internal static bool TryMarshalGet(long source, out DateTimeOffset? target)
	{
		System.Runtime.CompilerServices.Unsafe.As<DateTimeOffset?, @null>(ref target) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet<T>(IntPtr source, out T[] target, int arrayLength, bool isElementAllocated)
	{
		target = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet<T>(IntPtr source, out T[] target, uint arrayLength, bool isElementAllocated)
	{
		target = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 3)]
	internal static bool TryMarshalGet<T>(IntPtr source, out T[] target, int arrayLength)
	{
		target = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalGet<T>(IntPtr source, out T[] target, uint arrayLength)
	{
		target = null;
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static bool TryMarshalGet<TSource, TTarget>(TSource[] source, out TTarget[] target) where TSource : struct where TTarget : class, ISettable, new()
	{
		target = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	internal static bool TryMarshalGet<TSource, TTarget>(IntPtr source, out TTarget[] target, int arrayLength) where TSource : struct where TTarget : class, ISettable, new()
	{
		target = null;
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal static bool TryMarshalGet<TSource, TTarget>(IntPtr source, out TTarget[] target, uint arrayLength) where TSource : struct where TTarget : class, ISettable, new()
	{
		target = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static bool TryMarshalGet<T>(IntPtr source, out T? target) where T : struct
	{
		System.Runtime.CompilerServices.Unsafe.As<T?, @null>(ref target) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	internal static bool TryMarshalGet(byte[] source, out string target)
	{
		target = null;
		return default(bool);
	}

	[CallerCount(Count = 102)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalGet(IntPtr source, out object target)
	{
		target = null;
		return default(bool);
	}

	[CallerCount(Count = 154)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryFetch")]
	internal static bool TryMarshalGet(IntPtr source, out string target)
	{
		target = null;
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	internal static bool TryMarshalGet<T, TEnum>(T source, out T target, TEnum currentEnum, TEnum comparisonEnum)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref target) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalGet<TEnum>(int source, out bool? target, TEnum currentEnum, TEnum comparisonEnum)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool?, @null>(ref target) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalGet<T, TEnum>(T source, out T? target, TEnum currentEnum, TEnum comparisonEnum) where T : struct
	{
		System.Runtime.CompilerServices.Unsafe.As<T?, @null>(ref target) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalGet<T, TEnum>(IntPtr source, out T target, TEnum currentEnum, TEnum comparisonEnum) where T : Handle, new()
	{
		target = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	internal static bool TryMarshalGet<TEnum>(IntPtr source, out string target, TEnum currentEnum, TEnum comparisonEnum)
	{
		target = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	internal static bool TryMarshalGet<TInternal, TPublic>(IntPtr source, out TPublic target) where TInternal : struct where TPublic : class, ISettable, new()
	{
		target = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static bool TryMarshalGet<TInternal, TPublic>(TInternal source, out TPublic target) where TInternal : struct where TPublic : class, ISettable, new()
	{
		target = null;
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal static bool TryMarshalGet<TCallbackInfoInternal, TCallbackInfo>(IntPtr callbackInfoAddress, out TCallbackInfo callbackInfo, out IntPtr clientDataAddress) where TCallbackInfoInternal : struct, ICallbackInfoInternal where TCallbackInfo : class, ISettable, new()
	{
		callbackInfo = null;
		System.Runtime.CompilerServices.Unsafe.As<IntPtr, @null>(ref clientDataAddress) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal static bool TryMarshalSet<T>(ref T target, T source)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalSet<TTarget>(ref TTarget target, object source) where TTarget : ISettable, new()
	{
		return default(bool);
	}

	[CallerCount(Count = 188)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	internal static bool TryMarshalSet(ref IntPtr target, Handle source)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T? source) where T : struct
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T[] source, bool isElementAllocated)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T[] source)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T[] source, out int arrayLength, bool isElementAllocated)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref arrayLength) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T[] source, out uint arrayLength, bool isElementAllocated)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref arrayLength) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 3)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T[] source, out uint arrayLength)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref arrayLength) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(Epic.OnlineServices.Leaderboards.DefinitionInternal), Member = "set_EndTime")]
	[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "set_UnlockTime")]
	[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "set_UnlockTime")]
	[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "set_LastLoginTime")]
	[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_StartTime")]
	[CalledBy(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "set_EndTime")]
	[CalledBy(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "set_StartTime")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Leaderboards.DefinitionInternal), Member = "set_StartTime")]
	[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_EndTime")]
	[CalledBy(Type = typeof(StatInternal), Member = "set_StartTime")]
	[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "set_EndTime")]
	[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "set_StartTime")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime")]
	[CalledBy(Type = typeof(StatInternal), Member = "set_EndTime")]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 13)]
	internal static bool TryMarshalSet(ref long target, DateTimeOffset? source)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CreateLobbyOptionsInternal), Member = "set_PresenceEnabled")]
	[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "set_PresenceEnabled")]
	[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "set_AllowInvites")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Achievements.DefinitionInternal), Member = "set_IsHidden")]
	[CalledBy(Type = typeof(EntitlementInternal), Member = "set_Redeemed")]
	[CalledBy(Type = typeof(QueryEntitlementsOptionsInternal), Member = "set_IncludeRedeemed")]
	[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "set_RemoveAfterExit")]
	[CalledBy(Type = typeof(DefinitionV2Internal), Member = "set_IsHidden")]
	[CalledBy(Type = typeof(CatalogOfferInternal), Member = "set_AvailableForPurchase")]
	[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "set_AllowDelayedDelivery")]
	[CalledBy(Type = typeof(SessionModificationSetInvitesAllowedOptionsInternal), Member = "set_InvitesAllowed")]
	[CalledBy(Type = typeof(SessionModificationSetJoinInProgressAllowedOptionsInternal), Member = "set_AllowJoinInProgress")]
	[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "set_InvitesAllowed")]
	[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "set_AllowJoinInProgress")]
	[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "set_PresenceEnabled")]
	[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_PresenceEnabled")]
	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(OptionsInternal), Member = "set_IsServer")]
	internal static bool TryMarshalSet(ref int target, bool source)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalSet(ref byte[] target, string source, int length)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryAllocate")]
	[CallerCount(Count = 203)]
	internal static bool TryMarshalSet(ref IntPtr target, string source)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<T, TEnum>(ref T target, T source, ref TEnum currentEnum, TEnum comparisonEnum, IDisposable disposable = null)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<T, TEnum>(ref T target, T? source, ref TEnum currentEnum, TEnum comparisonEnum, IDisposable disposable = null) where T : struct
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Handle), Member = "Equals")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalSet<TEnum>(ref IntPtr target, Handle source, ref TEnum currentEnum, TEnum comparisonEnum, IDisposable disposable = null)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<TEnum>(ref IntPtr target, string source, ref TEnum currentEnum, TEnum comparisonEnum, IDisposable disposable = null)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<TEnum>(ref int target, bool? source, ref TEnum currentEnum, TEnum comparisonEnum, IDisposable disposable = null)
	{
		return default(bool);
	}

	[Calls(Type = typeof(AddNotifyAchievementsUnlockedOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal static bool TryMarshalSet<TInternal, TPublic>(ref IntPtr target, TPublic source) where TInternal : struct, ISettable where TPublic : class
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStatInfoInternal), Member = "Set")]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalSet<TInternal, TPublic>(ref IntPtr target, TPublic[] source, out int arrayLength) where TInternal : struct, ISettable where TPublic : class
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref arrayLength) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalSet<TInternal, TPublic>(ref IntPtr target, TPublic[] source, out uint arrayLength) where TInternal : struct, ISettable where TPublic : class
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref arrayLength) = null;
		return default(bool);
	}

	[CallerCount(Count = 121780)]
	[CallAnalysisNotSupported]
	[DeduplicatedMethod]
	internal static bool TryMarshalSet<TInternal, TPublic>(ref IntPtr target, TPublic[] source, out int arrayLength, bool isElementAllocated) where TInternal : struct, ISettable where TPublic : class
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref arrayLength) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallAnalysisNotSupported]
	[CallerCount(Count = 121780)]
	internal static bool TryMarshalSet<TInternal, TPublic>(ref IntPtr target, TPublic[] source, out uint arrayLength, bool isElementAllocated) where TInternal : struct, ISettable where TPublic : class
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref arrayLength) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "Copy")]
	internal static bool TryMarshalCopy(IntPtr target, byte[] source)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlatformInterface), Member = "GetActiveCountryCode")]
	[CalledBy(Type = typeof(PresenceInterface), Member = "GetJoinInfo")]
	[CalledBy(Type = typeof(PlayerDataStorageFileTransferRequest), Member = "GetFilename")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "GetActiveLocaleCode")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "GetInviteIdByIndex")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "GetOverrideLocaleCode")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "GetInviteIdByIndex")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "GetProductUserIdMapping")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "GetOverrideCountryCode")]
	[CalledBy(Type = typeof(TitleStorageFileTransferRequest), Member = "GetFilename")]
	[CalledBy(Type = typeof(Transaction), Member = "GetTransactionId")]
	[CalledBy(Type = typeof(EpicAccountId), Member = "ToString")]
	[CalledBy(Type = typeof(ContinuanceToken), Member = "ToString")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocateCacheOnly")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CalledBy(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(ProductUserId), Member = "ToString")]
	internal static bool TryMarshalAllocate(ref IntPtr target, int length)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(P2PInterface), Member = "ReceivePacket")]
	[CalledBy(Type = typeof(Common), Member = "ToString")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	internal static bool TryMarshalAllocate(ref IntPtr target, uint length)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "Dispose")]
	internal static bool TryMarshalDispose<TDisposable>(ref TDisposable disposable) where TDisposable : IDisposable
	{
		return default(bool);
	}

	[CallerCount(Count = 225)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	internal static bool TryMarshalDispose(ref IntPtr value)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalDispose<TEnum>(ref IntPtr member, TEnum currentEnum, TEnum comparisonEnum)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static T GetDefault<T>()
	{
		return (T)null;
	}

	[CallerCount(Count = 97)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	internal static void AddCallback(ref IntPtr clientDataAddress, object clientData, Delegate publicDelegate, Delegate privateDelegate, Delegate[] structDelegates)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
	[CalledBy(Type = typeof(LoggingInterface), Member = "SetCallback")]
	[CallsUnknownMethods(Count = 8)]
	internal static void AddStaticCallback(string key, Delegate publicDelegate, Delegate privateDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 3)]
	internal static bool TryAssignNotificationIdToCallback(IntPtr clientDataAddress, ulong notificationId)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "RemoveNotifyAchievementsUnlocked")]
	[CalledBy(Type = typeof(AuthInterface), Member = "RemoveNotifyLoginStatusChanged")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "RemoveNotifyLoginStatusChanged")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "RemoveNotifyAuthExpiration")]
	[CalledBy(Type = typeof(FriendsInterface), Member = "RemoveNotifyFriendsUpdate")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyLobbyUpdateReceived")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyLobbyMemberUpdateReceived")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyLobbyMemberStatusReceived")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyLobbyInviteReceived")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyJoinLobbyAccepted")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyLobbyInviteAccepted")]
	[CalledBy(Type = typeof(P2PInterface), Member = "RemoveNotifyPeerConnectionClosed")]
	[CalledBy(Type = typeof(PresenceInterface), Member = "RemoveNotifyOnPresenceChanged")]
	[CalledBy(Type = typeof(PresenceInterface), Member = "RemoveNotifyJoinGameAccepted")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "RemoveNotifySessionInviteReceived")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "RemoveNotifySessionInviteAccepted")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "RemoveNotifyJoinSessionAccepted")]
	[CalledBy(Type = typeof(UIInterface), Member = "RemoveNotifyDisplaySettingsUpdated")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(P2PInterface), Member = "RemoveNotifyPeerConnectionRequest")]
	internal static bool TryRemoveCallbackByNotificationId(ulong notificationId)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal static bool TryGetAndRemoveCallback<TCallback, TCallbackInfoInternal, TCallbackInfo>(IntPtr callbackInfoAddress, out TCallback callback, out TCallbackInfo callbackInfo) where TCallback : class where TCallbackInfoInternal : struct, ICallbackInfoInternal where TCallbackInfo : class, ICallbackInfo, ISettable, new()
	{
		callback = null;
		callbackInfo = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	internal static bool TryGetStructCallback<TDelegate, TCallbackInfoInternal, TCallbackInfo>(IntPtr callbackInfoAddress, out TDelegate callback, out TCallbackInfo callbackInfo) where TDelegate : class where TCallbackInfoInternal : struct, ICallbackInfoInternal where TCallbackInfo : class, ISettable, new()
	{
		callback = null;
		callbackInfo = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 23)]
	private static bool TryAllocate<T>(ref IntPtr target, T source)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private static bool TryAllocate<T>(ref IntPtr target, T? source) where T : struct
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	private static bool TryAllocate(ref IntPtr target, string source)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Helper), Member = "TryAllocate")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static bool TryAllocate<T>(ref IntPtr target, T[] source, bool isElementAllocated)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 4)]
	private static bool TryAllocateCacheOnly<T>(ref IntPtr target, T source)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 289)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(Marshal), Member = "ReadIntPtr")]
	[CallsUnknownMethods(Count = 33)]
	private static bool TryRelease(ref IntPtr target)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(TypeAllocationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	private static bool TryFetch<T>(IntPtr source, out T target)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref target) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(TypeAllocationException), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static bool TryFetch<T>(IntPtr source, out T? target) where T : struct
	{
		System.Runtime.CompilerServices.Unsafe.As<T?, @null>(ref target) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(ArrayAllocationException), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(TypeAllocationException), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "ReadIntPtr")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 7)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static bool TryFetch<T>(IntPtr source, out T[] target, int arrayLength, bool isElementAllocated)
	{
		target = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(Marshal), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private static bool TryFetch(IntPtr source, out string target)
	{
		target = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryConvert<THandle>(IntPtr source, out THandle target) where THandle : Handle, new()
	{
		target = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "Set")]
	internal static bool TryConvert<TSource, TTarget>(TSource source, out TTarget target) where TTarget : ISettable, new()
	{
		System.Runtime.CompilerServices.Unsafe.As<TTarget, @null>(ref target) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[Calls(Type = typeof(Handle), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private static bool TryConvert(Handle source, out IntPtr target)
	{
		System.Runtime.CompilerServices.Unsafe.As<IntPtr, @null>(ref target) = null;
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CalledBy(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CalledBy(Type = typeof(SocketIdInternal), Member = "get_SocketName")]
	[CallsUnknownMethods(Count = 4)]
	private static bool TryConvert(byte[] source, out string target)
	{
		target = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(SocketIdInternal), Member = "set_SocketName")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CalledBy(Type = typeof(Helper), Member = "TryConvert")]
	[Calls(Type = typeof(string), Member = "CreateString")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "PadHelper")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 4)]
	private static bool TryConvert(string source, out byte[] target, int length)
	{
		target = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryConvert(string source, out byte[] target)
	{
		target = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static bool TryConvert<T>(T[] source, out int target)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref target) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool TryConvert<T>(T[] source, out uint target)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref target) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal static bool TryConvert<TSource, TTarget>(TSource[] source, out TTarget[] target) where TTarget : ISettable, new()
	{
		target = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private static bool TryConvert(int source, out bool target)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref target) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private static bool TryConvert(bool source, out int target)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref target) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime")]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryConvert(DateTimeOffset? source, out long target)
	{
		System.Runtime.CompilerServices.Unsafe.As<long, @null>(ref target) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor")]
	private static bool TryConvert(long source, out DateTimeOffset? target)
	{
		System.Runtime.CompilerServices.Unsafe.As<DateTimeOffset?, @null>(ref target) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Helper), Member = "IsOperationComplete")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 3)]
	private static bool CanRemoveCallback<TCallbackInfo>(IntPtr clientDataAddress, TCallbackInfo callbackInfo) where TCallbackInfo : ICallbackInfo
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 14)]
	private static bool TryGetAndRemoveCallback<TCallback, TCallbackInfo>(IntPtr clientDataAddress, TCallbackInfo callbackInfo, out TCallback callback) where TCallback : class where TCallbackInfo : ICallbackInfo
	{
		callback = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	internal static bool TryGetStaticCallback<TCallback>(string key, out TCallback callback) where TCallback : class
	{
		callback = null;
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 29)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static bool TryGetStructCallback<TCallback>(IntPtr clientDataAddress, out TCallback structCallback) where TCallback : class
	{
		structCallback = null;
		return default(bool);
	}
}
