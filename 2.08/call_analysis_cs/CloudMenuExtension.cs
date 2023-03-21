using Cpp2ILInjected.CallAnalysis;

public class CloudMenuExtension : IBasicMenuExtension
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Init(BasicMenu menu)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ItemAdded(BasicMenu.BasicMenuItemModel item)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Update()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void UpdateButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CloudMenuExtension()
	{
	}
}
