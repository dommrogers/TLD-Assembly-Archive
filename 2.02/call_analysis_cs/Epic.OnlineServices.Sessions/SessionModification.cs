using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public sealed class SessionModification : Handle
{
	public const int SessionmodificationAddattributeApiLatest = 1;

	public const int SessionmodificationMaxSessionAttributeLength = 64;

	public const int SessionmodificationMaxSessionAttributes = 64;

	public const int SessionmodificationMaxSessionidoverrideLength = 64;

	public const int SessionmodificationMinSessionidoverrideLength = 16;

	public const int SessionmodificationRemoveattributeApiLatest = 1;

	public const int SessionmodificationSetbucketidApiLatest = 1;

	public const int SessionmodificationSethostaddressApiLatest = 1;

	public const int SessionmodificationSetinvitesallowedApiLatest = 1;

	public const int SessionmodificationSetjoininprogressallowedApiLatest = 1;

	public const int SessionmodificationSetmaxplayersApiLatest = 1;

	public const int SessionmodificationSetpermissionlevelApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SessionModification()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SessionModification(IntPtr innerHandle)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(SessionModificationAddAttributeOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public Result AddAttribute(SessionModificationAddAttributeOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Release()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SessionModificationRemoveAttributeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result RemoveAttribute(SessionModificationRemoveAttributeOptions options)
	{
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SessionModificationSetBucketIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public Result SetBucketId(SessionModificationSetBucketIdOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SessionModificationSetHostAddressOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result SetHostAddress(SessionModificationSetHostAddressOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SessionModificationSetInvitesAllowedOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result SetInvitesAllowed(SessionModificationSetInvitesAllowedOptions options)
	{
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(SessionModificationSetJoinInProgressAllowedOptionsInternal), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public Result SetJoinInProgressAllowed(SessionModificationSetJoinInProgressAllowedOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SessionModificationSetMaxPlayersOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result SetMaxPlayers(SessionModificationSetMaxPlayersOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SessionModificationSetPermissionLevelOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result SetPermissionLevel(SessionModificationSetPermissionLevelOptions options)
	{
		return default(Result);
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionModification_AddAttribute(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_SessionModification_Release(IntPtr sessionModificationHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionModification_RemoveAttribute(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionModification_SetBucketId(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionModification_SetHostAddress(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionModification_SetInvitesAllowed(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionModification_SetJoinInProgressAllowed(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionModification_SetMaxPlayers(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_SessionModification_SetPermissionLevel(IntPtr handle, IntPtr options);
}
