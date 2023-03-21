using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public sealed class SessionDetails : Handle
{
	public const int SessiondetailsAttributeApiLatest = 1;

	public const int SessiondetailsCopyinfoApiLatest = 1;

	public const int SessiondetailsCopysessionattributebyindexApiLatest = 1;

	public const int SessiondetailsCopysessionattributebykeyApiLatest = 1;

	public const int SessiondetailsGetsessionattributecountApiLatest = 1;

	public const int SessiondetailsInfoApiLatest = 1;

	public const int SessiondetailsSettingsApiLatest = 2;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SessionDetails()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SessionDetails(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsCopyInfoOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public Result CopyInfo(SessionDetailsCopyInfoOptions options, out SessionDetailsInfo outSessionInfo)
	{
		outSessionInfo = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsCopySessionAttributeByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(SessionDetails), Member = "EOS_SessionDetails_Attribute_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopySessionAttributeByIndex(SessionDetailsCopySessionAttributeByIndexOptions options, out SessionDetailsAttribute outSessionAttribute)
	{
		outSessionAttribute = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsCopySessionAttributeByKeyOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(SessionDetails), Member = "EOS_SessionDetails_Attribute_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopySessionAttributeByKey(SessionDetailsCopySessionAttributeByKeyOptions options, out SessionDetailsAttribute outSessionAttribute)
	{
		outSessionAttribute = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsGetSessionAttributeCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetSessionAttributeCount(SessionDetailsGetSessionAttributeCountOptions options)
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
	internal static extern Result EOS_SessionDetails_CopyInfo(IntPtr handle, IntPtr options, ref IntPtr outSessionInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionDetails_CopySessionAttributeByIndex(IntPtr handle, IntPtr options, ref IntPtr outSessionAttribute);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_SessionDetails_CopySessionAttributeByKey(IntPtr handle, IntPtr options, ref IntPtr outSessionAttribute);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_SessionDetails_GetSessionAttributeCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_SessionDetails_Release(IntPtr sessionHandle);

	[PreserveSig]
	[CalledBy(Type = typeof(SessionDetails), Member = "CopySessionAttributeByIndex")]
	[CalledBy(Type = typeof(SessionDetails), Member = "CopySessionAttributeByKey")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_SessionDetails_Attribute_Release(IntPtr sessionAttribute);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_SessionDetails_Info_Release(IntPtr sessionInfo);
}
