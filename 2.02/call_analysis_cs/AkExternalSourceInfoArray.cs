using System;
using Cpp2ILInjected.CallAnalysis;

public class AkExternalSourceInfoArray : AkBaseArray<AkExternalSourceInfo>
{
	protected override int StructureSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkExternalSourceInfo_GetSizeOf")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkBaseArray<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AkExternalSourceInfoArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(0);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkExternalSourceInfo_Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override AkExternalSourceInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkExternalSourceInfo), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkExternalSourceInfo_Clone")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkExternalSourceInfo other)
	{
	}
}
