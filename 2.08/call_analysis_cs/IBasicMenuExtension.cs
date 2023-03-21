using Cpp2ILInjected.CallAnalysis;

public interface IBasicMenuExtension
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void Init(BasicMenu menu);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void ItemAdded(BasicMenu.BasicMenuItemModel item);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void Update();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void UpdateButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority);
}
