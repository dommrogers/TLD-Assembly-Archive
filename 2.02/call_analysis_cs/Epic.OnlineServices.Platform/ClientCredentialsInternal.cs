using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Platform;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct ClientCredentialsInternal : ISettable, IDisposable
{
	private IntPtr m_ClientId;

	private IntPtr m_ClientSecret;

	public string ClientId
	{
		[CalledBy(Type = typeof(ClientCredentials), Member = "Set")]
		[CalledBy(Type = typeof(ClientCredentials), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ClientCredentialsInternal), Member = "Set")]
		[CalledBy(Type = typeof(ClientCredentialsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ClientSecret
	{
		[CalledBy(Type = typeof(ClientCredentials), Member = "Set")]
		[CalledBy(Type = typeof(ClientCredentials), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ClientCredentialsInternal), Member = "Set")]
		[CalledBy(Type = typeof(ClientCredentialsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "set_ClientId")]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "set_ClientSecret")]
	public void Set(ClientCredentials other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "set_ClientId")]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "set_ClientSecret")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CalledBy(Type = typeof(OptionsInternal), Member = "Dispose")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
