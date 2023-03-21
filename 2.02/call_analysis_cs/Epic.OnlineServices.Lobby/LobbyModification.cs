using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public sealed class LobbyModification : Handle
{
	public const int LobbymodificationAddattributeApiLatest = 1;

	public const int LobbymodificationAddmemberattributeApiLatest = 1;

	public const int LobbymodificationMaxAttributeLength = 64;

	public const int LobbymodificationMaxAttributes = 64;

	public const int LobbymodificationRemoveattributeApiLatest = 1;

	public const int LobbymodificationRemovememberattributeApiLatest = 1;

	public const int LobbymodificationSetmaxmembersApiLatest = 1;

	public const int LobbymodificationSetpermissionlevelApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LobbyModification()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LobbyModification(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyModificationAddAttributeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result AddAttribute(LobbyModificationAddAttributeOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyModificationAddMemberAttributeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result AddMemberAttribute(LobbyModificationAddMemberAttributeOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Release()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyModificationRemoveAttributeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result RemoveAttribute(LobbyModificationRemoveAttributeOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyModificationRemoveMemberAttributeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result RemoveMemberAttribute(LobbyModificationRemoveMemberAttributeOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyModificationSetMaxMembersOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetMaxMembers(LobbyModificationSetMaxMembersOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyModificationSetPermissionLevelOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetPermissionLevel(LobbyModificationSetPermissionLevelOptions options)
	{
		return default(Result);
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbyModification_AddAttribute(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbyModification_AddMemberAttribute(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_LobbyModification_Release(IntPtr lobbyModificationHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbyModification_RemoveAttribute(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbyModification_RemoveMemberAttribute(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbyModification_SetMaxMembers(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbyModification_SetPermissionLevel(IntPtr handle, IntPtr options);
}
