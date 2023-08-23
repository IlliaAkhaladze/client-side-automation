@Navigation
Feature: NavigationScenarios


Scenario: 1. Check that navigation link can redirecting
	Given I open main view
	When I open '<LinkToOpen>' link
	Then I see '<ExpectedValue>' header

Examples:
	| LinkToOpen                  | ExpectedValue               |
	| Ноутбуки та комп’ютери      | Комп'ютери та ноутбуки      |
	| Смартфони, ТВ і електроніка | Смартфони, ТВ і Електроніка |
	| Товари для геймерів         | Товари для геймерів         |

