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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 98)]
		get
		{
			return null;
		}
		[CallerCount(Count = 265)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public PostProcessEffectSettings settings
	{
		[CallerCount(Count = 44)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
		private set
		{
		}
	}

	internal PostProcessEffectRenderer renderer
	{
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BakeMSVOMap")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessBundle), Member = "CastRenderer")]
		[Calls(Type = typeof(Activator), Member = "CreateInstance")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal PostProcessBundle(PostProcessEffectSettings settings)
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal void Release()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void ResetHistory()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal T CastSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[CallsUnknownMethods(Count = 3)]
	internal T CastRenderer<T>() where T : PostProcessEffectRenderer
	{
		return null;
	}
}
