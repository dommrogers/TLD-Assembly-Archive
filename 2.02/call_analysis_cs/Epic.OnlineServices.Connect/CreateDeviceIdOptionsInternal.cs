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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CreateDeviceIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CreateDeviceIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(CreateDeviceIdOptionsInternal), Member = "set_DeviceModel")]
	[CallerCount(Count = 0)]
	public void Set(CreateDeviceIdOptions other)
	{
	}

	[Calls(Type = typeof(CreateDeviceIdOptionsInternal), Member = "set_DeviceModel")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "CreateDeviceId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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
