using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

public class AddNotifyPeerConnectionClosedOptions
{
	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private SocketId _003CSocketId_003Ek__BackingField;

	public ProductUserId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public SocketId SocketId
	{
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AddNotifyPeerConnectionClosedOptions()
	{
	}
}
