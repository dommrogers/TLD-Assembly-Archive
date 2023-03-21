using System;
using Cpp2ILInjected.CallAnalysis;

public class AkSourceSettingsArray : AkBaseArray<AkSourceSettings>
{
	protected override int StructureSize
	{
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSourceSettings_GetSizeOf")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkSourceSettingsArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(default(int));
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSourceSettings_Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override AkSourceSettings CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSourceSettings), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSourceSettings_Clone")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkSourceSettings other)
	{
	}
}
