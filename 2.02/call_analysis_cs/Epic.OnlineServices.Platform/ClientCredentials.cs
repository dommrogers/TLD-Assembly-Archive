using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Platform;

public class ClientCredentials : ISettable
{
	private string _003CClientId_003Ek__BackingField;

	private string _003CClientSecret_003Ek__BackingField;

	public string ClientId
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

	public string ClientSecret
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
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "get_ClientId")]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "get_ClientSecret")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void Set(ClientCredentialsInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "get_ClientId")]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "get_ClientSecret")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ClientCredentials()
	{
	}
}
