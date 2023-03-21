using Cpp2ILInjected.CallAnalysis;

public class UIButtonKeys : UIKeyNavigation
{
	public UIButtonKeys selectOnClick;

	public UIButtonKeys selectOnUp;

	public UIButtonKeys selectOnDown;

	public UIButtonKeys selectOnLeft;

	public UIButtonKeys selectOnRight;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonKeys), Member = "Upgrade")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "OnEnable")]
	protected override void OnEnable()
	{
	}

	[CalledBy(Type = typeof(UIButtonKeys), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void Upgrade()
	{
	}

	[CallerCount(Count = 0)]
	public UIButtonKeys()
	{
	}
}
