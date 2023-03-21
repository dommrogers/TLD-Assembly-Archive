using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class CreditElement : MonoBehaviour
{
	private float m_PaddingAbove;

	private float m_PaddingBelow;

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract bool IsContentValid(string[] content, Panel_Credits panel);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract void Populate(string[] content, Panel_Credits panel);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract Vector2 GetSize();

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void SetPosition(float yOffset)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetPaddingAbove()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetPaddingBelow()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	protected CreditElement()
	{
	}
}
