## ✅ What is `ColorHelper`?

`ColorHelper` is a **static helper class** in `Microsoft.UI` that helps you:

1. **Create a Color** from RGBA values (`FromArgb`)
2. **Get a readable name** of a color (`ToDisplayName`)

---

## ✅ Namespace

```csharp
using Microsoft.UI;
```

---

## ✅ 1. Creating a Color using FromArgb

```csharp
var myColor = ColorHelper.FromArgb(255, 0, 120, 215); // A solid blue color
```

* `FromArgb(byte a, byte r, byte g, byte b)`
* `a`: Alpha (transparency); 255 = opaque, 0 = fully transparent
* `r`, `g`, `b`: Red, Green, Blue

### Example in UI (e.g. change Button background)

```csharp
myButton.Background = new SolidColorBrush(ColorHelper.FromArgb(255, 0, 120, 215));
```

---

## ✅ 2. Getting the Name of a Color (ToDisplayName)

```csharp
string name = ColorHelper.ToDisplayName(ColorHelper.FromArgb(255, 255, 165, 0)); // returns "Gold"
```

* This is useful for debugging or displaying color names in the UI.

---

## 🧠 Notes

* `ColorHelper` is just a **utility**, not a UI component.
* It simplifies converting raw RGBA values to `Color` structs.
* Works with `Windows.UI.Color` Class.

---

## ✅ When to Use

* When setting color manually by RGBA.
* When debugging or labeling UI with readable color names.
