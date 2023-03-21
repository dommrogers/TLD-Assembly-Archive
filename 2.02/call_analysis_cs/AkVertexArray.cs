using System;
using Cpp2ILInjected.CallAnalysis;

public class AkVertexArray : AkBaseArray<AkVertex>
{
	protected override int StructureSize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkVertex_GetSizeOf")]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkVertexArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(default(int));
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkVertex_Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override AkVertex CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkVertex), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkVertex_Clone")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkVertex other)
	{
	}
}
