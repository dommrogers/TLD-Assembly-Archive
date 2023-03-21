using System;
using Cpp2ILInjected.CallAnalysis;

public class AkObjectInfoArray : AkBaseArray<AkObjectInfo>
{
	protected override int StructureSize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObjectInfo_GetSizeOf")]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkObjectInfoArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(default(int));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObjectInfo_Clear")]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	protected override AkObjectInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkObjectInfo), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObjectInfo_Clone")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObjectInfo other)
	{
	}
}
