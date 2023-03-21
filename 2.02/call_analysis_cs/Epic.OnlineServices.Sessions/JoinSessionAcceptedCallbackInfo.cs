using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class JoinSessionAcceptedCallbackInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private ulong _003CUiEventId_003Ek__BackingField;

	public object ClientData
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		[CompilerGenerated]
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

	public ProductUserId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		private set
		{
		}
	}

	public ulong UiEventId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return default(ulong);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JoinSessionAcceptedCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(JoinSessionAcceptedCallbackInfoInternal), Member = "get_LocalUserId")]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(JoinSessionAcceptedCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(JoinSessionAcceptedCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(JoinSessionAcceptedCallbackInfoInternal), Member = "get_LocalUserId")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public JoinSessionAcceptedCallbackInfo()
	{
	}
}
