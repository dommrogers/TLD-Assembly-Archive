using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CreateDeviceIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_DeviceModel;

	public string DeviceModel
	{
		[CalledBy(Type = typeof(CreateDeviceIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CreateDeviceIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CreateDeviceIdOptionsInternal), Member = "set_DeviceModel")]
	public void Set(CreateDeviceIdOptions other)
	{
	}

	[CalledBy(Type = typeof(ConnectInterface), Member = "CreateDeviceId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CreateDeviceIdOptionsInternal), Member = "set_DeviceModel")]
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
