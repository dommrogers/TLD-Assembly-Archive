using System;
using Cpp2ILInjected.CallAnalysis;

public class AkExternalSourceInfoArray : AkBaseArray<AkExternalSourceInfo>
{
	protected override int StructureSize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkExternalSourceInfo_GetSizeOf")]
		get
		{
			return default(int);
		}
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public AkExternalSourceInfoArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(default(int));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkExternalSourceInfo_Clear")]
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

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkExternalSourceInfo_Clone")]
	[Calls(Type = typeof(AkExternalSourceInfo), Member = "getCPtr")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkExternalSourceInfo other)
	{
	}
}
