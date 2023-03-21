using Cpp2ILInjected.CallAnalysis;

public interface IBasicMenuExtension
{
	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	void Init(BasicMenu menu);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void ItemAdded(BasicMenu.BasicMenuItemModel item);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Update();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void UpdateButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority);
}
