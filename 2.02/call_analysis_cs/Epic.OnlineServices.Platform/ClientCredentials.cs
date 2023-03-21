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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public string ClientSecret
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "get_ClientId")]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "get_ClientSecret")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(ClientCredentialsInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "get_ClientId")]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "get_ClientSecret")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ClientCredentials()
	{
	}
}
