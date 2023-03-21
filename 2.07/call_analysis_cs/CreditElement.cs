using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class CreditElement : MonoBehaviour
{
	private float m_PaddingAbove;

	private float m_PaddingBelow;

	public abstract bool IsContentValid(string[] content, Panel_Credits panel);

	public abstract void Populate(string[] content, Panel_Credits panel);

	public abstract Vector2 GetSize();

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void SetPosition(float yOffset)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetPaddingAbove()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetPaddingBelow()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected CreditElement()
	{
	}
}
