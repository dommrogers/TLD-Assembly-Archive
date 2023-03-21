using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct IsUserInSessionOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionName;

	private IntPtr m_TargetUserId;

	public string SessionName
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(IsUserInSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(IsUserInSessionOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(IsUserInSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(IsUserInSessionOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IsUserInSessionOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(IsUserInSessionOptionsInternal), Member = "set_TargetUserId")]
	public void Set(IsUserInSessionOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(IsUserInSessionOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(IsUserInSessionOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "IsUserInSession")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
