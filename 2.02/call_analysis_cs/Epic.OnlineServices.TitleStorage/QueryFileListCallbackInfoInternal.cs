using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct QueryFileListCallbackInfoInternal : ICallbackInfoInternal
{
	private Result m_ResultCode;

	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private uint m_FileCount;

	public Result ResultCode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Result);
		}
	}

	public object ClientData
	{
		[CalledBy(Type = typeof(QueryFileListCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(QueryFileListCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return (IntPtr)0;
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(QueryFileListCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(QueryFileListCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public uint FileCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return 0u;
		}
	}
}
