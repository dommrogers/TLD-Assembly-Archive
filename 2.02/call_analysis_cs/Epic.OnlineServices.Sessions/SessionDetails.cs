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
	[CallerCount(Count = 2)]
	public SessionDetails()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SessionDetails(IntPtr innerHandle)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(SessionDetailsCopyInfoOptionsInternal), Member = "Set")]
	public Result CopyInfo(SessionDetailsCopyInfoOptions options, out SessionDetailsInfo outSessionInfo)
	{
		outSessionInfo = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(SessionDetailsCopySessionAttributeByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(SessionDetails), Member = "EOS_SessionDetails_Attribute_Release")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopySessionAttributeByIndex(SessionDetailsCopySessionAttributeByIndexOptions options, out SessionDetailsAttribute outSessionAttribute)
	{
		outSessionAttribute = null;
		return default(Result);
	}

	[Calls(Type = typeof(SessionDetails), Member = "EOS_SessionDetails_Attribute_Release")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsCopySessionAttributeByKeyOptionsInternal), Member = "Set")]
	public Result CopySessionAttributeByKey(SessionDetailsCopySessionAttributeByKeyOptions options, out SessionDetailsAttribute outSessionAttribute)
	{
		outSessionAttribute = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SessionDetailsGetSessionAttributeCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public uint GetSessionAttributeCount(SessionDetailsGetSessionAttributeCountOptions options)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern uint EOS_SessionDetails_GetSessionAttributeCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_SessionDetails_Release(IntPtr sessionHandle);

	[PreserveSig]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(SessionDetails), Member = "CopySessionAttributeByIndex")]
	[CalledBy(Type = typeof(SessionDetails), Member = "CopySessionAttributeByKey")]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_SessionDetails_Attribute_Release(IntPtr sessionAttribute);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_SessionDetails_Info_Release(IntPtr sessionInfo);
}
