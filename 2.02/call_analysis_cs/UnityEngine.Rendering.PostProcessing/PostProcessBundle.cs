using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessBundle
{
	private PostProcessAttribute _003Cattribute_003Ek__BackingField;

	private PostProcessEffectSettings _003Csettings_003Ek__BackingField;

	private PostProcessEffectRenderer m_Renderer;

	public PostProcessAttribute attribute
	{
		[CallerCount(Count = 52)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public PostProcessEffectSettings settings
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	internal PostProcessEffectRenderer renderer
	{
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BakeMSVOMap")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessBundle), Member = "CastRenderer")]
		[Calls(Type = typeof(Activator), Member = "CreateInstance")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[CallsUnknownMethods(Count = 8)]
	internal PostProcessBundle(PostProcessEffectSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	internal void Release()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal void ResetHistory()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	internal T CastSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[CallsUnknownMethods(Count = 4)]
	internal T CastRenderer<T>() where T : PostProcessEffectRenderer
	{
		return null;
	}
}
