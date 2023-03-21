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
		[CalledBy(Type = typeof(IsUserInSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(IsUserInSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(IsUserInSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(IsUserInSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(SessionsInterface), Member = "IsUserInSession")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IsUserInSessionOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(IsUserInSessionOptionsInternal), Member = "set_TargetUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
