using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public abstract class PostProcessEffectRenderer
{
	protected bool m_ResetHistory;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void Init()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual void ResetHistory()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Release()
	{
	}

	public abstract void Render(PostProcessRenderContext context);

	internal abstract void SetSettings(PostProcessEffectSettings settings);

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected PostProcessEffectRenderer()
	{
	}
}
public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer where T : PostProcessEffectSettings
{
	private T _003Csettings_003Ek__BackingField;

	public T settings
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 86)]
		internal set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal override void SetSettings(PostProcessEffectSettings settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected PostProcessEffectRenderer()
	{
	}
}
