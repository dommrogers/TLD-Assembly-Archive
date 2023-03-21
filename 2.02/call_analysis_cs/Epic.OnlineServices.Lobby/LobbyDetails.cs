using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public sealed class LobbyDetails : Handle
{
	public const int LobbydetailsCopyattributebyindexApiLatest = 1;

	public const int LobbydetailsCopyattributebykeyApiLatest = 1;

	public const int LobbydetailsCopyinfoApiLatest = 1;

	public const int LobbydetailsCopymemberattributebyindexApiLatest = 1;

	public const int LobbydetailsCopymemberattributebykeyApiLatest = 1;

	public const int LobbydetailsGetattributecountApiLatest = 1;

	public const int LobbydetailsGetlobbyownerApiLatest = 1;

	public const int LobbydetailsGetmemberattributecountApiLatest = 1;

	public const int LobbydetailsGetmemberbyindexApiLatest = 1;

	public const int LobbydetailsGetmembercountApiLatest = 1;

	public const int LobbydetailsInfoApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LobbyDetails()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LobbyDetails(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsCopyAttributeByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(LobbyInterface), Member = "EOS_Lobby_Attribute_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyAttributeByIndex(LobbyDetailsCopyAttributeByIndexOptions options, out Attribute outAttribute)
	{
		outAttribute = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsCopyAttributeByKeyOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(LobbyInterface), Member = "EOS_Lobby_Attribute_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyAttributeByKey(LobbyDetailsCopyAttributeByKeyOptions options, out Attribute outAttribute)
	{
		outAttribute = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsCopyInfoOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public Result CopyInfo(LobbyDetailsCopyInfoOptions options, out LobbyDetailsInfo outLobbyDetailsInfo)
	{
		outLobbyDetailsInfo = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(LobbyInterface), Member = "EOS_Lobby_Attribute_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyMemberAttributeByIndex(LobbyDetailsCopyMemberAttributeByIndexOptions options, out Attribute outAttribute)
	{
		outAttribute = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsCopyMemberAttributeByKeyOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(LobbyInterface), Member = "EOS_Lobby_Attribute_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyMemberAttributeByKey(LobbyDetailsCopyMemberAttributeByKeyOptions options, out Attribute outAttribute)
	{
		outAttribute = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsGetAttributeCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetAttributeCount(LobbyDetailsGetAttributeCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsGetLobbyOwnerOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public ProductUserId GetLobbyOwner(LobbyDetailsGetLobbyOwnerOptions options)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsGetMemberAttributeCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetMemberAttributeCount(LobbyDetailsGetMemberAttributeCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsGetMemberByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public ProductUserId GetMemberByIndex(LobbyDetailsGetMemberByIndexOptions options)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsGetMemberCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetMemberCount(LobbyDetailsGetMemberCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Release()
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbyDetails_CopyAttributeByIndex(IntPtr handle, IntPtr options, ref IntPtr outAttribute);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbyDetails_CopyAttributeByKey(IntPtr handle, IntPtr options, ref IntPtr outAttribute);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbyDetails_CopyInfo(IntPtr handle, IntPtr options, ref IntPtr outLobbyDetailsInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbyDetails_CopyMemberAttributeByIndex(IntPtr handle, IntPtr options, ref IntPtr outAttribute);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_LobbyDetails_CopyMemberAttributeByKey(IntPtr handle, IntPtr options, ref IntPtr outAttribute);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_LobbyDetails_GetAttributeCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern IntPtr EOS_LobbyDetails_GetLobbyOwner(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_LobbyDetails_GetMemberAttributeCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern IntPtr EOS_LobbyDetails_GetMemberByIndex(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_LobbyDetails_GetMemberCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_LobbyDetails_Release(IntPtr lobbyHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_LobbyDetails_Info_Release(IntPtr lobbyDetailsInfo);
}
