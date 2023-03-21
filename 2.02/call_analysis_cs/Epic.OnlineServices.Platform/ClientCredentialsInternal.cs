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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ClientCredentials), Member = "Set")]
		[CalledBy(Type = typeof(ClientCredentials), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ClientCredentialsInternal), Member = "Set")]
		[CalledBy(Type = typeof(ClientCredentialsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public string ClientSecret
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ClientCredentials), Member = "Set")]
		[CalledBy(Type = typeof(ClientCredentials), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ClientCredentialsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ClientCredentialsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(ClientCredentialsInternal), Member = "set_ClientSecret")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "set_ClientId")]
	public void Set(ClientCredentials other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "set_ClientId")]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "set_ClientSecret")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CalledBy(Type = typeof(OptionsInternal), Member = "Dispose")]
	public void Dispose()
	{
	}
}
