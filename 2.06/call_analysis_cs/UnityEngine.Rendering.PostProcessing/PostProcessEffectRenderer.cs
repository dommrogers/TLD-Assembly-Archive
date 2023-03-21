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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void ResetHistory()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Release()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract void Render(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
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
