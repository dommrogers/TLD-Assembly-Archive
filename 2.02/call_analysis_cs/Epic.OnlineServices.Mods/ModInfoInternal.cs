using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct ModInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private int m_ModsCount;

	private IntPtr m_Mods;

	private ModEnumerationType m_Type;

	public ModIdentifier[] Mods
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CalledBy(Type = typeof(ModInfo), Member = "Set")]
		[CalledBy(Type = typeof(ModInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(ModInfoInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(ModInfoInternal), Member = "Set")]
		set
		{
		}
	}

	public ModEnumerationType Type
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(ModEnumerationType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ModInfoInternal), Member = "set_Mods")]
	public void Set(ModInfo other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ModInfoInternal), Member = "set_Mods")]
	public void Set(object other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
