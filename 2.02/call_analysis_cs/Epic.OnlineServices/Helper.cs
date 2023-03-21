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
using Epic.OnlineServices.Metrics;
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
			[CallerCount(Count = 59)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 103)]
			private set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
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
				return false;
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
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 59)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 103)]
			private set
			{
			}
		}

		public Delegate Private
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 77)]
			private set
			{
			}
		}

		public Delegate[] StructDelegates
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 9)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 34)]
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
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		internal string _003CToHexString_003Eb__9_0(byte b)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public ulong notificationId;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass66_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal bool _003CTryRemoveCallbackByNotificationId_003Eb__0(KeyValuePair<IntPtr, DelegateHolder> pair)
		{
			return false;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CTryGetStructCallback_003Eb__95_0(Delegate delegat)
		{
			return false;
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
		return 0;
	}

	[CalledBy(Type = typeof(Helper), Member = "CanRemoveCallback")]
	[CalledBy(Type = typeof(HelperExtensions), Member = "IsOperationComplete")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsOperationComplete(Result result)
	{
		return false;
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static extern int EOS_EResult_IsOperationComplete(Result result);

	[CalledBy(Type = typeof(HelperExtensions), Member = "ToHexString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[Calls(Type = typeof(string), Member = "Join")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static string ToHexString(byte[] byteArray)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet<T>(T[] source, out uint target)
	{
		target = default(uint);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 147)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet<T>(IntPtr source, out T target) where T : Handle, new()
	{
		target = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalGet(int source, out bool target)
	{
		target = default(bool);
		return false;
	}

	[CalledBy(Type = typeof(Stat), Member = "Set")]
	[CalledBy(Type = typeof(StatInternal), Member = "get_StartTime")]
	[CalledBy(Type = typeof(StatInternal), Member = "get_EndTime")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Leaderboards.Definition), Member = "Set")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Leaderboards.DefinitionInternal), Member = "get_StartTime")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Leaderboards.DefinitionInternal), Member = "get_EndTime")]
	[CalledBy(Type = typeof(ExternalAccountInfo), Member = "Set")]
	[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "get_LastLoginTime")]
	[CalledBy(Type = typeof(OnAchievementsUnlockedCallbackV2Info), Member = "Set")]
	[CalledBy(Type = typeof(OnAchievementsUnlockedCallbackV2InfoInternal), Member = "get_UnlockTime")]
	[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
	[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "get_UnlockTime")]
	[CalledBy(Type = typeof(UnlockedAchievement), Member = "Set")]
	[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "get_UnlockTime")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet(long source, out DateTimeOffset? target)
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet<T>(IntPtr source, out T[] target, int arrayLength, bool isElementAllocated)
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet<T>(IntPtr source, out T[] target, uint arrayLength, bool isElementAllocated)
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalGet<T>(IntPtr source, out T[] target, int arrayLength)
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalGet<T>(IntPtr source, out T[] target, uint arrayLength)
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet<TSource, TTarget>(TSource[] source, out TTarget[] target) where TSource : struct where TTarget : class, ISettable, new()
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	internal static bool TryMarshalGet<TSource, TTarget>(IntPtr source, out TTarget[] target, int arrayLength) where TSource : struct where TTarget : class, ISettable, new()
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet<TSource, TTarget>(IntPtr source, out TTarget[] target, uint arrayLength) where TSource : struct where TTarget : class, ISettable, new()
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalGet<T>(IntPtr source, out T? target) where T : struct
	{
		target = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalGet(byte[] source, out string target)
	{
		target = null;
		return false;
	}

	[CallerCount(Count = 102)]
	[Calls(Type = typeof(Helper), Member = "TryFetch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalGet(IntPtr source, out object target)
	{
		target = null;
		return false;
	}

	[CallerCount(Count = 154)]
	[Calls(Type = typeof(Helper), Member = "TryFetch")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalGet(IntPtr source, out string target)
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValue), Member = "get_AsUtf8")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValueInternal), Member = "Set")]
	[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountId), Member = "get_Epic")]
	[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountId), Member = "get_External")]
	[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "Set")]
	[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "get_Epic")]
	[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "get_External")]
	[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "Set")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValue), Member = "get_AsUtf8")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "Set")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalGet<T, TEnum>(T source, out T target, TEnum currentEnum, TEnum comparisonEnum)
	{
		target = default(T);
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValueInternal), Member = "get_AsBool")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "get_AsBool")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalGet<TEnum>(int source, out bool? target, TEnum currentEnum, TEnum comparisonEnum)
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValueInternal), Member = "get_AsInt64")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValueInternal), Member = "get_AsDouble")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "get_AsInt64")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "get_AsDouble")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalGet<T, TEnum>(T source, out T? target, TEnum currentEnum, TEnum comparisonEnum) where T : struct
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "get_Epic")]
	[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "get_Epic")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalGet<T, TEnum>(IntPtr source, out T target, TEnum currentEnum, TEnum comparisonEnum) where T : Handle, new()
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValueInternal), Member = "get_AsUtf8")]
	[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "get_External")]
	[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "get_External")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "get_AsUtf8")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalGet<TEnum>(IntPtr source, out string target, TEnum currentEnum, TEnum comparisonEnum)
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	internal static bool TryMarshalGet<TInternal, TPublic>(IntPtr source, out TPublic target) where TInternal : struct where TPublic : class, ISettable, new()
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static bool TryMarshalGet<TInternal, TPublic>(TInternal source, out TPublic target) where TInternal : struct where TPublic : class, ISettable, new()
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal static bool TryMarshalGet<TCallbackInfoInternal, TCallbackInfo>(IntPtr callbackInfoAddress, out TCallbackInfo callbackInfo, out IntPtr clientDataAddress) where TCallbackInfoInternal : struct, ICallbackInfoInternal where TCallbackInfo : class, ISettable, new()
	{
		callbackInfo = null;
		clientDataAddress = default(IntPtr);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal static bool TryMarshalSet<T>(ref T target, T source)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalSet<TTarget>(ref TTarget target, object source) where TTarget : ISettable, new()
	{
		return false;
	}

	[CallerCount(Count = 188)]
	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalSet(ref IntPtr target, Handle source)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T? source) where T : struct
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T[] source, bool isElementAllocated)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T[] source)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T[] source, out int arrayLength, bool isElementAllocated)
	{
		arrayLength = default(int);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T[] source, out uint arrayLength, bool isElementAllocated)
	{
		arrayLength = default(uint);
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Epic.OnlineServices.TitleStorage.QueryFileListOptionsInternal), Member = "set_ListOfTags")]
	[CalledBy(Type = typeof(RegisterPlayersOptionsInternal), Member = "set_PlayersToRegister")]
	[CalledBy(Type = typeof(UnregisterPlayersOptionsInternal), Member = "set_PlayersToUnregister")]
	[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_UserIds")]
	[CalledBy(Type = typeof(QueryEntitlementsOptionsInternal), Member = "set_EntitlementNames")]
	[CalledBy(Type = typeof(QueryOwnershipOptionsInternal), Member = "set_CatalogItemIds")]
	[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "set_CatalogItemIds")]
	[CalledBy(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "set_EntitlementIds")]
	[CalledBy(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "set_ProductUserIds")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<T>(ref IntPtr target, T[] source, out uint arrayLength)
	{
		arrayLength = default(uint);
		return false;
	}

	[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "set_StartTime")]
	[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "set_EndTime")]
	[CalledBy(Type = typeof(StatInternal), Member = "set_StartTime")]
	[CalledBy(Type = typeof(StatInternal), Member = "set_EndTime")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Leaderboards.DefinitionInternal), Member = "set_StartTime")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Leaderboards.DefinitionInternal), Member = "set_EndTime")]
	[CalledBy(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "set_StartTime")]
	[CalledBy(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "set_EndTime")]
	[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_StartTime")]
	[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_EndTime")]
	[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "set_LastLoginTime")]
	[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "set_UnlockTime")]
	[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "set_UnlockTime")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime")]
	[CallsDeduplicatedMethods(Count = 3)]
	internal static bool TryMarshalSet(ref long target, DateTimeOffset? source)
	{
		return false;
	}

	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_PresenceEnabled")]
	[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "set_PresenceEnabled")]
	[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "set_AllowJoinInProgress")]
	[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "set_InvitesAllowed")]
	[CalledBy(Type = typeof(SessionModificationSetInvitesAllowedOptionsInternal), Member = "set_InvitesAllowed")]
	[CalledBy(Type = typeof(SessionModificationSetJoinInProgressAllowedOptionsInternal), Member = "set_AllowJoinInProgress")]
	[CalledBy(Type = typeof(OptionsInternal), Member = "set_IsServer")]
	[CalledBy(Type = typeof(SendPacketOptionsInternal), Member = "set_AllowDelayedDelivery")]
	[CalledBy(Type = typeof(InstallModOptionsInternal), Member = "set_RemoveAfterExit")]
	[CalledBy(Type = typeof(CreateLobbyOptionsInternal), Member = "set_PresenceEnabled")]
	[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "set_PresenceEnabled")]
	[CalledBy(Type = typeof(LobbyDetailsInfoInternal), Member = "set_AllowInvites")]
	[CalledBy(Type = typeof(CatalogOfferInternal), Member = "set_AvailableForPurchase")]
	[CalledBy(Type = typeof(EntitlementInternal), Member = "set_Redeemed")]
	[CalledBy(Type = typeof(QueryEntitlementsOptionsInternal), Member = "set_IncludeRedeemed")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Achievements.DefinitionInternal), Member = "set_IsHidden")]
	[CalledBy(Type = typeof(DefinitionV2Internal), Member = "set_IsHidden")]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalSet(ref int target, bool source)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalSet(ref byte[] target, string source, int length)
	{
		return false;
	}

	[CallerCount(Count = 203)]
	[Calls(Type = typeof(Helper), Member = "TryAllocate")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalSet(ref IntPtr target, string source)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValue), Member = "set_AsUtf8")]
	[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountId), Member = "set_Epic")]
	[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountId), Member = "set_External")]
	[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "set_Epic")]
	[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "set_External")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValue), Member = "set_AsUtf8")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<T, TEnum>(ref T target, T source, ref TEnum currentEnum, TEnum comparisonEnum, IDisposable disposable = null)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValueInternal), Member = "set_AsInt64")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValueInternal), Member = "set_AsDouble")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "set_AsInt64")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "set_AsDouble")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<T, TEnum>(ref T target, T? source, ref TEnum currentEnum, TEnum comparisonEnum, IDisposable disposable = null) where T : struct
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Handle), Member = "Equals")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<TEnum>(ref IntPtr target, Handle source, ref TEnum currentEnum, TEnum comparisonEnum, IDisposable disposable = null)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValueInternal), Member = "set_AsUtf8")]
	[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "set_External")]
	[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "set_External")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "set_AsUtf8")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<TEnum>(ref IntPtr target, string source, ref TEnum currentEnum, TEnum comparisonEnum, IDisposable disposable = null)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValueInternal), Member = "set_AsBool")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "set_AsBool")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryMarshalSet<TEnum>(ref int target, bool? source, ref TEnum currentEnum, TEnum comparisonEnum, IDisposable disposable = null)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddNotifyAchievementsUnlockedOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 3)]
	internal static bool TryMarshalSet<TInternal, TPublic>(ref IntPtr target, TPublic source) where TInternal : struct, ISettable where TPublic : class
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStatInfoInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalSet<TInternal, TPublic>(ref IntPtr target, TPublic[] source, out int arrayLength) where TInternal : struct, ISettable where TPublic : class
	{
		arrayLength = default(int);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool TryMarshalSet<TInternal, TPublic>(ref IntPtr target, TPublic[] source, out uint arrayLength) where TInternal : struct, ISettable where TPublic : class
	{
		arrayLength = default(uint);
		return false;
	}

	internal static bool TryMarshalSet<TInternal, TPublic>(ref IntPtr target, TPublic[] source, out int arrayLength, bool isElementAllocated) where TInternal : struct, ISettable where TPublic : class
	{
		arrayLength = default(int);
		return false;
	}

	internal static bool TryMarshalSet<TInternal, TPublic>(ref IntPtr target, TPublic[] source, out uint arrayLength, bool isElementAllocated) where TInternal : struct, ISettable where TPublic : class
	{
		arrayLength = default(uint);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalCopy(IntPtr target, byte[] source)
	{
		return false;
	}

	[CalledBy(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocateCacheOnly")]
	[CalledBy(Type = typeof(ContinuanceToken), Member = "ToString")]
	[CalledBy(Type = typeof(EpicAccountId), Member = "ToString")]
	[CalledBy(Type = typeof(ProductUserId), Member = "ToString")]
	[CalledBy(Type = typeof(TitleStorageFileTransferRequest), Member = "GetFilename")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "GetInviteIdByIndex")]
	[CalledBy(Type = typeof(PresenceInterface), Member = "GetJoinInfo")]
	[CalledBy(Type = typeof(PlayerDataStorageFileTransferRequest), Member = "GetFilename")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "GetActiveCountryCode")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "GetActiveLocaleCode")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "GetOverrideCountryCode")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "GetOverrideLocaleCode")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "GetInviteIdByIndex")]
	[CalledBy(Type = typeof(Transaction), Member = "GetTransactionId")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "GetProductUserIdMapping")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalAllocate(ref IntPtr target, int length)
	{
		return false;
	}

	[CalledBy(Type = typeof(Common), Member = "ToString")]
	[CalledBy(Type = typeof(P2PInterface), Member = "ReceivePacket")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalAllocate(ref IntPtr target, uint length)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "Dispose")]
	internal static bool TryMarshalDispose<TDisposable>(ref TDisposable disposable) where TDisposable : IDisposable
	{
		return false;
	}

	[CallerCount(Count = 225)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool TryMarshalDispose(ref IntPtr value)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Epic.OnlineServices.Sessions.AttributeDataValueInternal), Member = "Dispose")]
	[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "Dispose")]
	[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "Dispose")]
	[CalledBy(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "Dispose")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static bool TryMarshalDispose<TEnum>(ref IntPtr member, TEnum currentEnum, TEnum comparisonEnum)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal static T GetDefault<T>()
	{
		return default(T);
	}

	[CallerCount(Count = 97)]
	[Calls(Type = typeof(Helper), Member = "TryAllocateCacheOnly")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	internal static void AddCallback(ref IntPtr clientDataAddress, object clientData, Delegate publicDelegate, Delegate privateDelegate, Delegate[] structDelegates)
	{
	}

	[CalledBy(Type = typeof(PlatformInterface), Member = "Initialize")]
	[CalledBy(Type = typeof(LoggingInterface), Member = "SetCallback")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	internal static void AddStaticCallback(string key, Delegate publicDelegate, Delegate privateDelegate)
	{
	}

	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static bool TryAssignNotificationIdToCallback(IntPtr clientDataAddress, ulong notificationId)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIInterface), Member = "RemoveNotifyDisplaySettingsUpdated")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "RemoveNotifyJoinSessionAccepted")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "RemoveNotifySessionInviteAccepted")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "RemoveNotifySessionInviteReceived")]
	[CalledBy(Type = typeof(PresenceInterface), Member = "RemoveNotifyJoinGameAccepted")]
	[CalledBy(Type = typeof(PresenceInterface), Member = "RemoveNotifyOnPresenceChanged")]
	[CalledBy(Type = typeof(P2PInterface), Member = "RemoveNotifyPeerConnectionClosed")]
	[CalledBy(Type = typeof(P2PInterface), Member = "RemoveNotifyPeerConnectionRequest")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyJoinLobbyAccepted")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyLobbyInviteAccepted")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyLobbyInviteReceived")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyLobbyMemberStatusReceived")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyLobbyMemberUpdateReceived")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RemoveNotifyLobbyUpdateReceived")]
	[CalledBy(Type = typeof(FriendsInterface), Member = "RemoveNotifyFriendsUpdate")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "RemoveNotifyAuthExpiration")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "RemoveNotifyLoginStatusChanged")]
	[CalledBy(Type = typeof(AuthInterface), Member = "RemoveNotifyLoginStatusChanged")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "RemoveNotifyAchievementsUnlocked")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[Calls(Type = typeof(Enumerable), Member = "First")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	internal static bool TryRemoveCallbackByNotificationId(ulong notificationId)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	internal static bool TryGetAndRemoveCallback<TCallback, TCallbackInfoInternal, TCallbackInfo>(IntPtr callbackInfoAddress, out TCallback callback, out TCallbackInfo callbackInfo) where TCallback : class where TCallbackInfoInternal : struct, ICallbackInfoInternal where TCallbackInfo : class, ICallbackInfo, ISettable, new()
	{
		callback = null;
		callbackInfo = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	internal static bool TryGetStructCallback<TDelegate, TCallbackInfoInternal, TCallbackInfo>(IntPtr callbackInfoAddress, out TDelegate callback, out TCallbackInfo callbackInfo) where TDelegate : class where TCallbackInfoInternal : struct, ICallbackInfoInternal where TCallbackInfo : class, ISettable, new()
	{
		callback = null;
		callbackInfo = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 23)]
	private static bool TryAllocate<T>(ref IntPtr target, T source)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private static bool TryAllocate<T>(ref IntPtr target, T? source) where T : struct
	{
		return false;
	}

	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	[Calls(Type = typeof(Helper), Member = "TryAllocate")]
	[Calls(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static bool TryAllocate(ref IntPtr target, string source)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	[Calls(Type = typeof(Helper), Member = "TryAllocate")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr")]
	[Calls(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 37)]
	private static bool TryAllocate<T>(ref IntPtr target, T[] source, bool isElementAllocated)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Helper), Member = "AddCallback")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(ExternalAllocationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private static bool TryAllocateCacheOnly<T>(ref IntPtr target, T source)
	{
		return false;
	}

	[CallerCount(Count = 289)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(Marshal), Member = "ReadIntPtr")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 33)]
	private static bool TryRelease(ref IntPtr target)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(TypeAllocationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	private static bool TryFetch<T>(IntPtr source, out T target)
	{
		target = default(T);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(TypeAllocationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private static bool TryFetch<T>(IntPtr source, out T? target) where T : struct
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Marshal), Member = "ReadIntPtr")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(TypeAllocationException), Member = ".ctor")]
	[Calls(Type = typeof(ArrayAllocationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 45)]
	private static bool TryFetch<T>(IntPtr source, out T[] target, int arrayLength, bool isElementAllocated)
	{
		target = null;
		return false;
	}

	[CalledBy(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "Copy")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryFetch(IntPtr source, out string target)
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryConvert<THandle>(IntPtr source, out THandle target) where THandle : Handle, new()
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Epic.OnlineServices.Lobby.AttributeDataValueInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 3)]
	internal static bool TryConvert<TSource, TTarget>(TSource source, out TTarget target) where TTarget : ISettable, new()
	{
		target = default(TTarget);
		return false;
	}

	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Handle), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool TryConvert(Handle source, out IntPtr target)
	{
		target = default(IntPtr);
		return false;
	}

	[CalledBy(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CalledBy(Type = typeof(SocketIdInternal), Member = "get_SocketName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private static bool TryConvert(byte[] source, out string target)
	{
		target = null;
		return false;
	}

	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CalledBy(Type = typeof(Helper), Member = "TryAllocate")]
	[CalledBy(Type = typeof(Helper), Member = "TryConvert")]
	[CalledBy(Type = typeof(SocketIdInternal), Member = "set_SocketName")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[Calls(Type = typeof(string), Member = "CreateString")]
	[Calls(Type = typeof(string), Member = "PadHelper")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private static bool TryConvert(string source, out byte[] target, int length)
	{
		target = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryConvert")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryConvert(string source, out byte[] target)
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static bool TryConvert<T>(T[] source, out int target)
	{
		target = default(int);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool TryConvert<T>(T[] source, out uint target)
	{
		target = default(uint);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	internal static bool TryConvert<TSource, TTarget>(TSource[] source, out TTarget[] target) where TTarget : ISettable, new()
	{
		target = null;
		return false;
	}

	[CallerCount(Count = 0)]
	private static bool TryConvert(int source, out bool target)
	{
		target = default(bool);
		return false;
	}

	[CallerCount(Count = 0)]
	private static bool TryConvert(bool source, out int target)
	{
		target = default(int);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryConvert(DateTimeOffset? source, out long target)
	{
		target = default(long);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool TryConvert(long source, out DateTimeOffset? target)
	{
		target = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Nullable<>), Member = "get_Value")]
	[Calls(Type = typeof(Helper), Member = "IsOperationComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static bool CanRemoveCallback<TCallbackInfo>(IntPtr clientDataAddress, TCallbackInfo callbackInfo) where TCallbackInfo : ICallbackInfo
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	private static bool TryGetAndRemoveCallback<TCallback, TCallbackInfo>(IntPtr clientDataAddress, TCallbackInfo callbackInfo, out TCallback callback) where TCallback : class where TCallbackInfo : ICallbackInfo
	{
		callback = null;
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(PlatformInterface), Member = "AllocateMemoryFuncInternalImplementation")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "ReallocateMemoryFuncInternalImplementation")]
	[CalledBy(Type = typeof(PlatformInterface), Member = "ReleaseMemoryFuncInternalImplementation")]
	[CalledBy(Type = typeof(LoggingInterface), Member = "LogMessageFuncInternalImplementation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	internal static bool TryGetStaticCallback<TCallback>(string key, out TCallback callback) where TCallback : class
	{
		callback = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	private static bool TryGetStructCallback<TCallback>(IntPtr clientDataAddress, out TCallback structCallback) where TCallback : class
	{
		structCallback = null;
		return false;
	}
}
