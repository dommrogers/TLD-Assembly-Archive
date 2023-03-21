using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

public class SocketId : ISettable
{
	private string _003CSocketName_003Ek__BackingField;

	public string SocketName
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
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SocketIdInternal), Member = "get_SocketName")]
	[CallsUnknownMethods(Count = 1)]
	internal void Set(SocketIdInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SocketIdInternal), Member = "get_SocketName")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SocketId()
	{
	}
}
