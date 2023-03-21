using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Metrics;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct BeginPlayerSessionOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private BeginPlayerSessionOptionsAccountIdInternal m_AccountId;

	private IntPtr m_DisplayName;

	private UserControllerType m_ControllerType;

	private IntPtr m_ServerIp;

	private IntPtr m_GameSessionId;

	public BeginPlayerSessionOptionsAccountId AccountId
	{
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	public string DisplayName
	{
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public UserControllerType ControllerType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string ServerIp
	{
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string GameSessionId
	{
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "set_AccountId")]
	[Calls(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "set_DisplayName")]
	[Calls(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "set_ServerIp")]
	[Calls(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "set_GameSessionId")]
	public void Set(BeginPlayerSessionOptions other)
	{
	}

	[CalledBy(Type = typeof(MetricsInterface), Member = "BeginPlayerSession")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "set_AccountId")]
	[Calls(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "set_DisplayName")]
	[Calls(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "set_ServerIp")]
	[Calls(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "set_GameSessionId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "Dispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
