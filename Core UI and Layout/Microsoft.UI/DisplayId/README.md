### `Microsoft.UI.DisplayId`

`DisplayId` is a **struct** used to **uniquely identify a display/monitor** connected to the system.

#### Think of it like:

When you're managing multiple monitors in a WinUI app (like setting window positions or moving an `AppWindow` to a specific screen), you need to **reference each display** — that's what `DisplayId` is for.

---

### Key Points:

* **Namespace:** `Microsoft.UI`
* **Type:** `struct`
* **Purpose:** Identifies a **physical display** (monitor).
* **Usage:** Mostly used with the `DisplayArea` API or when working with multiple windows/screens.

---

### Internals:

`DisplayId` has a single field:

* `.Value` → A `ulong` that holds the actual identifier for the display.

But you never assign this manually. Instead, you **get** a `DisplayId` from APIs like:

```csharp
DisplayArea displayArea = DisplayArea.GetFromWindowId(windowId, DisplayAreaFallback.Nearest);
DisplayId displayId = displayArea.DisplayId;
```

---

### Summary:

* `DisplayId` = unique ID for a monitor.
* Used in multi-display/window scenarios.
* You get it via `DisplayArea`, not manually.
* Struct with just one field: `.Value`.
