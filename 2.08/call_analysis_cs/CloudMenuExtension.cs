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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdateButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CloudMenuExtension()
	{
	}
}
