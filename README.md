# InputForge C#

<br>
<pre align="center">
⠁⠀⠀⠀⠀⢠⣷⣼⢿⣇⣤⣶⣿⠛⠛⣿⣤⣷⠀⡿⡄⠀⠀⠀⠀⠀⠀⣿⠀⠀⢰⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⢷⡀⠀⠀⠀⠀⠀⠹⡇⠀⠀⠀⠀⠀⠀⠉⠳⠄⠀⠀
⠀⠀⠀⠀⠀⣾⣻⣿⣾⡟⠃⢰⡇⠀⠀⢿⣿⠿⡆⢻⣇⠀⠀⠀⠀⠀⠀⣿⠀⠀⣽⣳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⠀⠒⠒⠻⣦⡀⠀⠀⠀⠀⢿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢰⣿⣿⠋⢸⡄⠀⣼⡀⠀⠀⠘⣿⡀⣷⠈⣿⡀⠀⠀⠀⠀⠀⣿⠀⢠⣿⡟⠋⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢷⣄⠀⠀⠀⠈⢻⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⣼⡿⠁⠀⢸⠀⢰⡏⣃⣠⠤⠴⢻⣿⠙⣇⢹⣇⠀⠀⠀⠀⠀⢹⠀⣸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣷⡀⠀⠀⠀⢷⡀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢠⡿⠃⠀⣀⣼⡄⢸⠏⠁⠀⠀⠀⠀⢻⡄⢻⡄⣿⡄⠀⠀⠀⠀⢸⡄⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣆⠀⠀⠘⢧⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⣿⣧⠔⠋⠁⢸⡇⢼⠀⠀⠀⠀⠀⠀⠀⢻⣾⢷⡘⣷⠀⠀⠀⠀⠘⣧⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢷⡀⠀⠘⣇⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢰⡟⠀⠀⠀⠀⠀⣇⣿⠀⠀⠀⠀⠀⠀⠀⠀⢻⣄⢷⡹⣇⠀⠀⠀⠀⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣦⡀⠹⡆⠀⠀⠀⠀⠀⠀
⠀⠠⣿⠀⠀⠀⠀⠀⠀⢻⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣖⢻⣿⡆⠀⠀⠀⢻⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢷⣄⢻⡄⠀⠀⠀⠀⠀
⠀⣼⣻⡀⠀⠀⠀⠀⠀⠸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣾⣷⡄⠀⠀⠀⠸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢷⣷⡀⠀⠀⠀⠀
⢰⡿⢻⡇⠀⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣿⣿⡄⠀⠀⠀⣷⠀⠀⠀⠀⠀⠀⠀⢀⣀⣤⠤⠤⠴⠖⠒⠒⠒⠒⠒⠒⠒⠛⠛⠂⠀⠀⠀⠀⠈⠻⣧⠀⠀⠀⠀
⡿⠠⢰⣷⠀⠀⠀⠀⠀⠀⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⡝⣆⠀⠀⢸⡆⠀⠀⠀⠀⠀⠀⠀⣤⣤⣤⣶⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⠙⣇⠀⠀⠀
⣷⠀⠀⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⣟⢷⡀⠀⢷⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⢸⡆⠀⠀
⠁⣴⣷⢺⡇⠀⠀⠀⠀⠀⠀⠀⣀⣠⡤⠶⢖⣿⠃⠀⠀⠀⠀⠀⠀⠀⠙⢷⣽⢦⡸⡇⠀⠀⠀⠀⠀⠀⠿⠛⠛⠋⠉⠉⢫⡉⠉⣀⣰⠎⢻⣿⣿⣿⣿⠇⣿⡿⠀⠀⠀⢸⣿⡄⠀
⣤⣿⡰⠀⣧⠀⠀⣀⡤⢶⣚⣭⣵⣶⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣷⣿⣿⡄⠀⠀⠀⠀⠀⠀⣴⠒⠀⠀⠀⠀⢿⣿⣿⣿⠀⠂⠎⢩⠉⠰⣆⡟⠓⡄⠀⠀⢸⣿⣷⠀
⣿⠈⠁⠀⣿⣄⣬⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⡀⠀⠀⠀⠀⠀⠘⢆⣀⣀⣀⣀⣼⠿⠿⠿⠿⠿⠿⠿⠿⠟⠛⠛⠋⠁⠀⠀⢸⡇⡸⣇
⣿⠒⠀⣦⣼⡿⣿⣿⣿⡿⠟⠛⡽⢿⣿⣿⠟⡿⠳⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⣷⡀⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⢀⣀⣤⣤⡴⠖⠀⠀⠀⠰⣿⠂⢸⡇⠫⣿
⣿⠇⠂⠋⢸⣿⠈⣿⠁⠁⣾⣿⣷⣀⠉⣙⣤⡿⠿⠁⠀⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠋⠀⠙⡁⢀⠀⠀⠀⠀⠀⠀⠀⢸⡃⡇⠈
⣿⠀⡄⠀⠠⣿⡄⠸⡆⢀⣘⡿⠿⠟⠋⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠋⠀⠀⠀⠀⠀⠀⠀⢸⡅⠅⠀
⣿⠀⡇⠀⢠⣸⡇⠀⠙⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⣆⠀
⣿⠀⡇⠀⢠⣸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠇⠀⠀
⣿⠀⡇⠀⠀⣼⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⡀⠀⠀⠀⠀⠀⠀⣀⣤⠾⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⠀
⣿⠀⡁⠀⠠⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢦⣀⣀⡤⠴⠛⠉⠉⠛⠓⠚⠛⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⢲
⣿⠀⠄⠀⠀⣿⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⣨
⡿⠀⠂⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⢠⣼
⣿⠃⠁⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠁⡰⣿
⠧⠃⠁⡆⢠⡇⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⢱⡇
⢧⣐⡀⠃⢀⡇⣿⢻⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣇⣼⡗
⠈⢿⣬⠄⠈⡇⢸⠀⠘⣿⣶⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣴⠟⢻⣡⡟⠀
⠀⠀⢻⣦⠀⡇⢸⡄⠐⣿⡅⠀⠙⠛⠳⢦⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣴⠾⣿⠛⠛⠛⢻⣿⠃⠀
⠀⠀⠀⠹⣆⣧⠸⡇⠀⣿⡇⠀⠀⠀⠀⠀⠀⢹⡟⠛⠶⢦⣤⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⠴⠞⠋⠁⠀⠀⢿⡀⠀⠀⢸⣿⠃⠀
⠀⠀⠀⠀⠙⣿⠀⣇⢸⣿⣯⠰⠂⠀⠀⠀⠀⣹⡇⠢⢀⠀⣿⠈⠉⠙⠻⠶⢦⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⡤⠶⠚⠋⠁⠀⠀⠀⠀⠀⠀⠀⠘⣇⣠⡴⣾⡟⠀⠀
⠀⠀⠀⠀⠀⠘⠆⢿⢸⡇⣧⠆⠀⠀⠀⠀⠀⢹⡇⠀⠀⢀⣿⠁⠀⠀⠀⠀⠈⠙⢿⡟⢿⡶⢤⣄⣠⣤⠤⠶⠒⢾⠋⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⠴⠋⠁⢠⡿⢷⢀⢀
⠀⢀⡀⠀⠀⠀⠀⢸⣾⡇⠸⡄⠀⢀⡀⠀⠀⣾⡟⠀⠀⢹⣿⡤⠀⠀⢀⡀⠀⠀⢸⣧⣼⣀⣶⢿⠋⠀⠀⠀⠀⠈⡆⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣴⡚⠋⠀⠀⢀⡀⣼⠇⢓⣴⢞
</pre>

**InputForge C#** provides a powerful and intuitive .NET (C#) interface to simulate keyboard input using the native Win32 `SendInput` API. It abstracts all interop details, offering a modern and simple API to programmatically control input across Windows environments.

Ideal for **WPF**, **Windows Forms**, and **Console Applications**, InputForge allows full simulation of key presses, combinations, modifiers, and text input.

---
## 🔧 Features

- Simulate **any keyboard input**, including:
  - Control, Shift, Alt, Tab, Enter, Space, Backspace, and Windows key
  - Lock keys: Caps Lock, Num Lock, Scroll Lock
  - Function keys: F1–F24
  - Media keys: Volume Up/Down, Mute
  - Web & application keys: Search, Mail, Favorites
  - Modified key chords (e.g., Ctrl+Alt+Del)
- Simulate **text entry** and full strings
- Detect **key states** (pressed or toggled)
- Lightweight, no external dependencies
- NuGet-supported and production-ready

---

## 📦 Installation

Install via NuGet:

```bash
Install-Package InputSimulator
```

Or add to your `.csproj`:

```xml
<PackageReference Include="InputSimulator" Version="x.x.x" />
```

---

## 🧪 Usage Examples

### Press a Single Key

```csharp
InputSimulator.SimulateKeyPress(VirtualKeyCode.SPACE);
```

---

### Key Down and Up

```csharp
InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_H);
InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_I);
InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
```

---

### Complex Modified Keystrokes (e.g. Ctrl + K + C)

```csharp
InputSimulator.SimulateModifiedKeyStroke(
    VirtualKeyCode.CONTROL,
    new[] { VirtualKeyCode.VK_K, VirtualKeyCode.VK_C });
```

---

### Simulate Full Text Entry

```csharp
InputSimulator.SimulateTextEntry("Hello, world!");
```

---

### Check Key Status

```csharp
bool isShiftDown = InputSimulator.IsKeyDown(VirtualKeyCode.SHIFT);
bool isCapsLockOn = InputSimulator.IsTogglingKeyInEffect(VirtualKeyCode.CAPITAL);
```

---

## 🧰 API Overview

| Method | Description |
|--------|-------------|
| `SimulateKeyPress(key)` | Press and release a key |
| `SimulateKeyDown(key)` | Press and hold a key |
| `SimulateKeyUp(key)` | Release a held key |
| `SimulateModifiedKeyStroke(mod, key)` | Simulate a modified key combo (e.g., Ctrl+C) |
| `SimulateTextEntry(text)` | Simulate full text input |
| `IsKeyDown(key)` | Check if a key is currently pressed |
| `IsTogglingKeyInEffect(key)` | Check if a toggling key (e.g., Caps Lock) is on |

---

## 🖥️ Compatibility

- .NET Framework 4.5+
- .NET Core 3.1+
- .NET 5, 6, 7, 8
- Windows 7, 8, 10, 11

---

## 🤝 Contribution

Contributions are welcome. Please open an issue or submit a pull request for features, fixes, or improvements.

---
