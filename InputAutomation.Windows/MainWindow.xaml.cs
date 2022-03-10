using InputAutomation.Core;
using InputAutomation.Core.User32;
using System;

using System.Windows;

namespace InputAutomation.Windows;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow: Window {
	public MainWindow() {
		InitializeComponent();
	}

	private async void OnTestButtonClicked(object sender, RoutedEventArgs e) {
		TextField.Focus();

		var pInputs = new[] {
			new Input() {
				InputType = InputType.INPUT_KEYBOARD,
				Union = new() {
					Key = new() {
						wScan = ScanCodeShort.KEY_T,
						wvk = VirtualKeyShort.KEY_T
					}
				}
			},
			new Input() {
				InputType = InputType.INPUT_KEYBOARD,
				Union = new() {
					Key = new() {
						wScan = ScanCodeShort.KEY_E,
						wvk = VirtualKeyShort.KEY_E
					}
				}
			},
			new Input() {
				InputType = InputType.INPUT_KEYBOARD,
				Union = new() {
					Key = new() {
						wScan = ScanCodeShort.KEY_S,
						wvk = VirtualKeyShort.KEY_S
					}
				}
			},
			new Input() {
				InputType = InputType.INPUT_KEYBOARD,
				Union = new() {
					Key = new() {
						wScan = ScanCodeShort.KEY_T,
						wvk = VirtualKeyShort.KEY_T
					}
				}
			},
			new Input() {
				InputType = InputType.INPUT_MOUSE,
				Union = new() {
					Mouse = new() {
						dx = 0,
						dy = 0,
						dwFlags = MouseEventF.MOVE
					}
				}
			}
		};

		await API.ProcessInput(pInputs);
	}

	private void OnMinimizeButtonClick(object sender, RoutedEventArgs e) {

	}
}
