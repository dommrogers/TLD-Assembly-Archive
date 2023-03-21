using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Platform;

[StructLayout(0, Pack = 8, Size = 112)]
internal struct OptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Reserved;

	private IntPtr m_ProductId;

	private IntPtr m_SandboxId;

	private ClientCredentialsInternal m_ClientCredentials;

	private int m_IsServer;

	private IntPtr m_EncryptionKey;

	private IntPtr m_OverrideCountryCode;

	private IntPtr m_OverrideLocaleCode;

	private IntPtr m_DeploymentId;

	private PlatformFlags m_Flags;

	private IntPtr m_CacheDirectory;

	private uint m_TickBudgetInMilliseconds;

	public IntPtr Reserved
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string ProductId
	{
		[CalledBy(Type = typeof(OptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string SandboxId
	{
		[CalledBy(Type = typeof(OptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ClientCredentials ClientCredentials
	{
		[CalledBy(Type = typeof(OptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	public bool IsServer
	{
		[CalledBy(Type = typeof(OptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string EncryptionKey
	{
		[CalledBy(Type = typeof(OptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string OverrideCountryCode
	{
		[CalledBy(Type = typeof(OptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string OverrideLocaleCode
	{
		[CalledBy(Type = typeof(OptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string DeploymentId
	{
		[CalledBy(Type = typeof(OptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public PlatformFlags Flags
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string CacheDirectory
	{
		[CalledBy(Type = typeof(OptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint TickBudgetInMilliseconds
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(OptionsInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OptionsInternal), Member = "set_ProductId")]
	[Calls(Type = typeof(OptionsInternal), Member = "set_SandboxId")]
	[Calls(Type = typeof(OptionsInternal), Member = "set_ClientCredentials")]
	[Calls(Type = typeof(OptionsInternal), Member = "set_IsServer")]
	[Calls(Type = typeof(OptionsInternal), Member = "set_EncryptionKey")]
	[Calls(Type = typeof(OptionsInternal), Member = "set_OverrideCountryCode")]
	[Calls(Type = typeof(OptionsInternal), Member = "set_OverrideLocaleCode")]
	[Calls(Type = typeof(OptionsInternal), Member = "set_DeploymentId")]
	[Calls(Type = typeof(OptionsInternal), Member = "set_CacheDirectory")]
	public void Set(Options other)
	{
	}

	[CalledBy(Type = typeof(PlatformInterface), Member = "Create")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(ClientCredentialsInternal), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
