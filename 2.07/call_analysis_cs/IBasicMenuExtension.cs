using Cpp2ILInjected.CallAnalysis;

public interface IBasicMenuExtension
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void Init(BasicMenu menu);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void ItemAdded(BasicMenu.BasicMenuItemModel item);

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void Update();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void UpdateButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority);
}
